using System.IO;
using System.Security;

namespace d11_debug_persons
{
    internal class Program
    {
        abstract class Address
        {

        }
        class Street : Address
        {
            string street;
            string postalCode;
            string city;
            public Street(string fullAddress)
            {
                string[] parts = fullAddress.Split(", ");
                street = parts[0];
                postalCode = parts[1];
                city = parts[2];
            }
            public override string ToString()
            {
                return $"{street}, {postalCode}, {city}";
            }
        }
        class Phone : Address
        {
            string phone;
            public Phone(string phone)
            {
                this.phone = phone;
            }
            public override string ToString()
            {
                return $"{phone}";
            }
        }
        class Person
        {
            string name;
            List<Address> addresses;
            public Person(string name)
            {
                this.name = name;
                addresses = new List<Address>();
            }
            public void SetAddress(string street)
            {
                addresses.Add(new Street(street));
            }
            public void SetPhone(string phone)
            {
                addresses.Add(new Phone(phone));
            }
            public Address GetStreet
            {
                get
                {
                    foreach (var address in addresses)
                    {
                        if (address is Street) return address;
                    }
                    return null;
                }
            }
            public override string ToString()
            {
                string res = $"Person: {name}\n";
                res += $"  address: {GetStreet}\n";
                res += $"  phone:\n";
                foreach(var address in addresses)
                {
                    if (address is Phone) {
                        res += $"    {address}";
                    }
                }
                return res;
            }
        }
        static void Main(string[] args)
        {
            Person arne = new Person("Arne Svensson");
            arne.SetPhone("013-113 13 13");
            arne.SetAddress("Gränden 23, 234 56, Svantemåla");
            Console.WriteLine(arne);
            Person berith = new Person("Berith Qvist");
            berith.SetPhone("013-114 15 16");
            berith.SetAddress("Bredgatan 22");
            Console.WriteLine(berith);
        }
    }
}
