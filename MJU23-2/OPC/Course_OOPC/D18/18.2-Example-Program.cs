namespace d18_övn_18_2_företagskund
{
    internal class Program
    {
        enum CustomerType { Private, Representative, Corporate }
        enum CheckType { NotChecked, MonthChecked, HalfYearChecked };
        abstract class Customer
        {
            abstract public CustomerType Type();
            string name;
            string? customerNumber; // Egentligen ett ID!
            string? contactPhone;
            string? contactEmail;
            string? deliveryAddress;
            public CheckType? checkStatus { get; set; }
            double? soldDate;
            string? product;
            abstract public void Print();
            public void CheckCustomer()
            {
                if (checkStatus != CheckType.HalfYearChecked)
                {
                    checkStatus++;
                }
            }
        }
        class PrivateCustomer : Customer
        {
            override public CustomerType Type() => CustomerType.Private;
            override public void Print() { }
        }
        class CorporateCustomer : Customer
        {
            override public CustomerType Type() => CustomerType.Corporate;
            Representative representative;
            override public void Print()
            {
                // ... sej själv ...
                Console.WriteLine("Kontaktperson:");
                representative.Print();
            }
        }
        class Representative : Customer
        {
            override public CustomerType Type() => CustomerType.Representative;
            override public void Print() { }
        }
        static List<Customer> customerList = new List<Customer>();
        static List<Customer> listNotChecked(List<Customer> customerList, CheckType stat)
        {
            List<Customer> result = new List<Customer>();
            foreach (Customer customer in customerList)
            {
                if (customer.checkStatus < stat)
                    result.Add(customer);
            }
            return result;
        }
        static void Print(List<Customer> customerList)
        {
            foreach (Customer customer in customerList)
            {
                customer.Print();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
