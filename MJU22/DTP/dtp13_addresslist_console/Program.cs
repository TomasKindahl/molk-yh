using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace dtp13_addresslist_console
{
    public class Person
    {
        public string persname, surname;
        public string phone;
        public string address;
        public Person(string persname, string surname)
        {
            this.persname = persname;
            this.surname = surname;
        }
        public void SetPhone(string phone)
        {
            this.phone = phone;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public Person(string lineFromFile)
        {
            string[] field = lineFromFile.Split('|');
            string[] name = field[0].Trim().Split(' ');
            persname = name[0]; surname = name[1];
            phone = field[1].Trim();
            address = field[2].Trim();
        }
        public string ToString(bool forFile = false)
        {
            if (forFile)
            {
                return $"{persname} {surname}|{phone}|{address}";
            }
            else
            {
                string name = $"{persname} {surname}";
                return $"{name,-20}|{phone,-18}|{address,-25}";
            }
        }
    }
    public class Program
    {
        static List<Person> ReadPersonsFromFile(string fileName)
        {
            List<Person> addressList = new List<Person>();
            using (StreamReader file = new StreamReader(fileName))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                    addressList.Add(new Person(line));
            }
            return addressList;
        }
        static void PrintAddressList(List<Person> addressList)
        {
            foreach (Person p in addressList)
                Console.WriteLine(p.ToString());
        }
        public static void Main(string[] args)
        {
            List<Person> addressList = ReadPersonsFromFile("address.lis");
            PrintAddressList(addressList);
        }
    }
}
