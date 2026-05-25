using System.Net;
using System.Numerics;

namespace OPC1_uppg_2_5_1_facit
{
    internal class Program
    {
        class Person
        {
            private string persname, surname, phone, address;
            public Person(string persname, string surname, string phone, string address)
            {
                this.persname = persname;
                this.surname = surname;
                this.phone = phone;
                this.address = address;
            }
            public string Persname { get { return persname; } set { persname = value; } }
            public string Surname { get { return surname; } set { surname = value; } }
            public string Phone { get { return phone; } set { phone = value; } }
            public string Address { get { return address; } set { address = value; } }
            public string ToString()
            {
                return $"{persname} {surname}, {phone}, {address}";
            }
        }
        static void Main(string[] args)
        {
            Person Parne = new Person("Arne", "Olsson", "013-113 13 13", "Gränden 23B");
            Console.WriteLine(Parne.ToString());
            Person Perith = new Person("Berith", "Qvist", "013-141 15 16", "Storgatan 8B");
            Console.WriteLine(Perith.ToString());
            Person Paesar = new Person("Caesar", "Augustus", "0771-772 73 74", "Capitolium 8");
            Console.WriteLine(Paesar.ToString());
        }
    }
}