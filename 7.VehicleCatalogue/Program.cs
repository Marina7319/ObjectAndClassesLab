using System;
using System.Collections.Generic;
using System.Linq;
namespace _7.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            List<string> names;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] tokens = command.Split("/");
                string types = tokens[0];
                switch (types)
                {
                    case "Truck":
                        Truck truck = new Truck
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            Weight = int.Parse(tokens[3])
                        };
                        catalogue.Trucks.Add(truck);
                        break;
                    case "Car":
                        Car car = new Car
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            HorsePower = int.Parse(tokens[3])
                        };
                        catalogue.Car.Add(car);
                        break;
                }
            }
            var orderlistCar = catalogue.Car.OrderBy(Car => Car.Brand).ToList();
            var orderlistTruck = catalogue.Trucks.OrderBy(Trucks => Trucks.Brand).ToList();
            if (catalogue.Car.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in orderlistCar)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderlistTruck)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Catalogue
    {
        public Catalogue()
        {
            this.Car = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Car { get; set; }
    }
}
