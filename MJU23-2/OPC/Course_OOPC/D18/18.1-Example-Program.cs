namespace d18_övn_18_1_cykeluthyrning
{
    internal class Program
    {
        class Person 
        {
            string? name;
            string? personnummer;
            string? phone;
            public void Print()
            {
                /* ... nå't ... */
            }
        }
        class Bicycle
        {
            public enum Type { Child, Female, Male }
            public enum Status { Service, Available, RentedOut, Missing }
            public int id { get; set; }
            int wheelSize; /* Hjulstorlek */
            Type type;
            public Status status { get; set; }
            // BEHÖVS INTE!: public void setStatus(Status status) => this.status = status;
            string? rentalDate; // FIXME: DateTime, eller vad det heter
            Person? renter;
            public void Print()
            {
                Console.WriteLine("Bicycle:");
                Console.WriteLine($"  id = {id}");
                Console.WriteLine($"  wheel size = {wheelSize}");
                Console.WriteLine($"  type = {type}");
                Console.WriteLine($"  status = {status}");
            }
            public void PrintRent()
            {
                Print();
                if (status == Status.RentedOut)
                {
                    Console.WriteLine($"  rental date = {rentalDate}");
                    renter.Print();
                }
            }
            public bool RegisterBicycle(Person person, string date)
            {
                if(status == Status.Available) { 
                    this.renter = person;
                    this.rentalDate = date;
                    return true;
                }
                else
                {
                    Console.WriteLine($"Cannot rent out bicycle because status is {status}:");
                    Print();
                    return false;
                }
            }
        }
        static List<Bicycle> allBikes;
        static void listAvailable(List<Bicycle> allBikes)
        {
            foreach (var b in allBikes)
            {
                if (b.status == Bicycle.Status.Available)
                    b.Print();
            }
        }
        static void resetStatus(List<Bicycle> allBikes)
        {
            foreach (var b in allBikes) // REALLY??
            {
                if(b.status != Bicycle.Status.RentedOut)
                    b.status = Bicycle.Status.Missing;
            }
        }
        static Bicycle? getId(int id, List<Bicycle> allBikes)
        {
            foreach (var b in allBikes)
            {
                if(b.id == id) return b;
            }
            return null;
        }
        static List<Bicycle> getMissing(List<Bicycle> allBikes)
        {
            List<Bicycle> found = new List<Bicycle>();
            foreach (var b in allBikes)
            {
                if(b.status == Bicycle.Status.Missing)
                {
                    found.Add(b);
                }
            }
            return found;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
