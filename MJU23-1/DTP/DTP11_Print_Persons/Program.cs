namespace DTP11_Print_Persons
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        static List<Person> addressList = new List<Person>();
        /// <summary>
        /// Person class for managing entries in an address list
        /// </summary>
        class Person
        {
            /// <summary>
            /// name includes [AGRAJAG]
            /// </summary>
            public string name;
            public string phone;
            public string address;
            /// <summary>
            /// Main constructor
            /// </summary>
            /// <param name="name">name of the Person</param>
            /// <param name="phone">phone number</param>
            /// <param name="address">street address</param>
            /// <example></example>
            public Person(string name, string phone, string address)
            {
                this.name = name; this.phone = phone; this.address = address;
            }
            /// <summary>
            /// getter for full name of a person
            /// </summary>
            /// <returns>the full name</returns>
            /// <example><code>string name = p.GetName();</code></example>
            public string GetName() => name;
            /// <summary>
            /// [SIMSALABIM]
            /// </summary>
            public string Phone { get => phone; set => phone = value; }
            public void Print()
                => Console.WriteLine($"{name,-20} {phone,-15} {address,-20}");
        }
        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args">args not currently used</param>
        static void Main(string[] args)
        {
            addressList.Add(new Person("Arne Svensson", "013-113 13 13", "COBOLgränd 77B"));
            addressList.Add(new Person("Berith Qvist", "014-115 16 17", "Pascalgatan 13"));
            foreach (Person p in addressList)
                p.Print();
        }
    }
}