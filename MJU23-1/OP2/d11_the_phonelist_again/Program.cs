using System;

namespace d11_the_phonelist_again
{
    internal class Program
    {
        abstract class Address
        {
            public enum Sector { Work, Private }
            Sector sector;
            public Address(Sector sector)
            {
                this.sector = sector;
            }
            public abstract string TypeString();
            public virtual string FullString()
                => sector == Sector.Work ? "arbetet" : "privat";
        }
        class PostalAddress : Address
        {
            string street, postalcode, city;
            public PostalAddress(string address, Address.Sector sector = Address.Sector.Private)
                : base(sector)
            {
                string[] parts = address.Split(',', StringSplitOptions.TrimEntries);
                street = parts[0];
                postalcode = parts[1];
                city = parts[2];
            }
            public override string TypeString() => "PostalAddress";
            public override string FullString() => $"adress: {street}, {postalcode}, {city}";
        }
        class Email : Address
        {
            string address;
            public Email(string address, Address.Sector sector = Address.Sector.Private)
                : base(sector)
            {
                this.address = address;
            }
            public override string TypeString() => "Email";
            public override string FullString() => $"epost {base.FullString()}: {address}";
        }
        class Phone : Address
        {
            string number;
            public Phone(string number, Address.Sector sector = Address.Sector.Private)
                : base(sector)
            {
                this.number = number;
            }
            public override string TypeString() => "Phone";
            public override string FullString() => $"telefon {base.FullString()}: {number}";
        }
        class Person
        {
            string? persname, surname;
            List<string>? middleNames;
            List<Address>? addresses;
            public Person(string persname, string surname)
            {
                this.persname = persname;
                this.surname = surname;
                addresses = new List<Address>();
                middleNames = new List<string>();
            }
            public void AddMiddleName(string name)
            {
                middleNames.Add(name);
            }
            public void AddPhone(string number, Address.Sector sector = Address.Sector.Private)
            {
                addresses.Add(new Phone(number, sector));
            }
            public void AddStreet(string street, Address.Sector sector = Address.Sector.Private)
            {
                addresses.Add(new PostalAddress(street, sector));
            }
            public void AddEmail(string address, Address.Sector sector = Address.Sector.Private)
            {
                addresses.Add(new Email(address, sector));
            }
            public string MiddleNames
            {
                get
                {
                    if (middleNames.Count == 0) return "";
                    else
                    {
                        string res = "";
                        foreach (string item in middleNames)
                        {
                            res += $"{item} ";
                        }
                        return res;
                    }
                }
            }
            public string Addresses
            {
                get
                {
                    if (addresses.Count == 0) return "--\n";
                    else
                    {
                        string res = "";
                        foreach (Address item in addresses)
                        {
                            res += $"    {item.FullString()}\n";
                        }
                        return res;
                    }
                }
            }
            public override string ToString()
            {
                return $"{persname} {surname}";
            }
            public string FullString()
            {
                string res = $"NAMN: {persname} {MiddleNames}{surname}\n";
                res += $"  ADRESSER:\n{Addresses}";
                return res;
            }
        }
        static void Main(string[] args)
        {
            string path = @"..\..\..\";
            List<Person> addresslist = new List<Person>();
            using (StreamReader sr = new StreamReader($"{path}phone.txt"))
            {
                for (string line = sr.ReadLine(); line != null; line = sr.ReadLine())
                {
                    // Personal name and surname, and create object:
                    string[] part = line.Split(';', StringSplitOptions.TrimEntries);
                    string name = part[0];
                    string[] nameParts = name.Split(' ', StringSplitOptions.TrimEntries);
                    Person pers = new Person(nameParts[0], nameParts[nameParts.Length - 1]);
                    // Middle names:
                    if (nameParts.Length >= 3)
                    {
                        for (int i = 1; i < nameParts.Length - 1; i++)
                        {
                            pers.AddMiddleName(nameParts[i]);
                        }
                    }
                    // All other fields:
                    for (int i = 1; i < part.Length; i++)
                    {
                        string[] partP = part[i].Split(":", StringSplitOptions.TrimEntries);
                        switch (partP[0])
                        {
                            case "adress":
                                pers.AddStreet(partP[1]); break;
                            case "telefon privat":
                                pers.AddPhone(partP[1]); break;
                            case "telefon arbete":
                                pers.AddPhone(partP[1], Address.Sector.Work); break;
                            case "epost privat":
                                pers.AddEmail(partP[1]); break;
                            case "epost arbete":
                                pers.AddEmail(partP[1], Address.Sector.Work); break;
                            default:
                                Console.WriteLine($"VARNING: ignorerar skräp {partP[1]}"); break;
                        }
                    }
                    addresslist.Add(pers);
                }
                Console.WriteLine("Welcome to the address list!");
                PrintHelp();
                do
                {
                    Console.Write("command: ");
                    string[] command = Console.ReadLine().Split(' ', StringSplitOptions.TrimEntries);
                    if (command[0] == "exit")
                    {
                        break;
                    }
                    else if (command[0] == "help")
                    {
                        PrintHelp();
                    }
                    else if (command[0] == "list")
                    {
                        for (int i = 0; i < addresslist.Count; i++)
                            Console.WriteLine($"  {i}: {addresslist[i]}");
                    }
                    else if (command[0] == "show")
                    {
                        for (int i = 0; i < addresslist.Count; i++)
                        {
                            if (addresslist[i].ToString().IndexOf(command[1]) != -1)
                            {
                                Console.WriteLine($"---- {i} ----");
                                Console.WriteLine(addresslist[i].FullString());
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"  Unknown command: {command[0]}");
                    }
                } while (true);
                Console.WriteLine("Bye!");
            }
        }
        public static void PrintHelp()
        {
            string[] help =
            {
                "Commands: ",
                "exit         - quit the program ",
                "help         - print this help",
                "list         - list all adresses",
                "show /name/  - show all addresses matching /name/",
            };
            foreach (string line in help)
            {
                Console.WriteLine($"  {line}");
            }
        }
    }
}
