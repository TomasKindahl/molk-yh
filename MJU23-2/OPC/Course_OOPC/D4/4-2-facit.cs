namespace OPC1_övn_4_2
{
    internal class Program
    {
        abstract class Vehicle
        {
            protected double lat, lon, maxSpeed;
            public double Latitude {
                get { return lat; } set { lat = value; }
            }
            public double Longitude
            {
                get { return lon; } set { lon = value; }
            }
            public Vehicle(double lat, double lon, double maxSpeed)
            {
                this.lat = lat; this.lon = lon; this.maxSpeed = maxSpeed;
            }
            protected double travelDistance(double newlat, double newlon)
            {
                return distanceInKM(lat, lon, newlat, newlon);
            }
            protected double travelTime(double newlat, double newlon)
            {
                return travelDistance(newlat, newlon) / maxSpeed * 60.0;
            }
            public virtual double MoveTo(double newlat, double newlon)
            {
                double dist = travelDistance(newlat, newlon);
                lat = newlat; lon = newlon;
                return dist;
            }
            public abstract override string ToString();
        }
        class Car : Vehicle
        {
            double fuel, maxFuel, fuelPerKm;
            public Car(double lat, double lon, double fuel)
                : base(lat, lon, 130.0)
            {
                this.fuel = fuel;
                maxFuel = 45;
                fuelPerKm = 0.045;
            }
            public double Refuel(double amount)
            {
                if (amount + fuel > maxFuel)
                {
                    fuel = maxFuel;
                    return (amount + fuel) - maxFuel;
                }
                fuel += amount;
                return 0;
            }
            public override double MoveTo(double newlat, double newlon)
            {
                double distanceKm = distanceInKM(lat, lon, newlat, newlon);
                double fuelToGoal = distanceKm * fuelPerKm;
                if (fuelToGoal > fuel)
                {
                    return 0;
                }
                double timeToGoal = travelTime(newlat, newlon);
                base.MoveTo(newlat, newlon);
                return timeToGoal;
            }
            public override string ToString()
            {
                return $"car at lat={lat}, lon={lon}, fuel level={fuel}";
            }
        }
        class Bicycle : Vehicle
        {
            public Bicycle(double lat, double lon)
                : base(lat, lon, 20.0)
            { }
            public override double MoveTo(double newlat, double newlon)
            {
                double timeToGoal = travelTime(newlat, newlon);
                if (timeToGoal > 5) return 0;
                base.MoveTo(newlat, newlon);
                return timeToGoal;
            }
            public override string ToString()
            {
                return $"bicycle at lat={lat}, lon={lon}";
            }
        }
        static void Main(string[] args)
        {
            Vehicle car = new Car(58.60, 16.20, 0);
            Console.WriteLine(car);                            // gör en ToString!
            Console.WriteLine(" " + car.MoveTo(58.40, 15.26)); // ska inte funka!
            Console.WriteLine(car.Latitude);                   // gör en property Latitude!
            Console.WriteLine(car.Longitude);                  // gör en property Longitude!
            if (car is Car C)
                Console.WriteLine(C.Refuel(80));               // tanka 80 liter (egentligen 45)
            Console.WriteLine(" " + car.MoveTo(58.40, 15.26)); // ska funka nu!
            Console.WriteLine(car);
            Vehicle bike = new Bicycle(58.60, 16.20); 
            Console.WriteLine(bike);                           // gör en ToString!
            Console.WriteLine(" " + bike.MoveTo(58.45, 14.90)); // funkar det eller ej??
            Console.WriteLine(bike.Latitude);                  // gör en property Latitude!
            Console.WriteLine(bike.Longitude);                 // gör en property Longitude!
            Console.WriteLine(" " + bike.MoveTo(58.48, 16.32)); // funkar det eller ej??
            Console.WriteLine(bike.Latitude);                  // gör en property Latitude!
            Console.WriteLine(bike.Longitude);                 // gör en property Longitude!
        }
        static double distanceInKM(double lat1, double lon1, double lat2, double lon2)
        {
            double latDistKm = (lat1 - lat2) * 111.1;
            double lonDistKm = (lon1 - lon2) * 58.05;
            return Math.Sqrt(latDistKm * latDistKm + lonDistKm * lonDistKm);
        }
    }
}