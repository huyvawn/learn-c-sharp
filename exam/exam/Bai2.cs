using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Base Vehicle class
class Vehicle
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(int id, string brand, string model, int year)
    {
        Id = id;
        Brand = brand;
        Model = model;
        Year = year;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}, Brand: {Brand}, Model: {Model}, Year: {Year}");
    }
}

// Derived Car class from Vehicle
class Car : Vehicle
{
    public Car(int id, string brand, string model, int year) : base(id, brand, model, year) { }
}

// Derived Motor class from Vehicle
class Motor : Vehicle
{
    public Motor(int id, string brand, string model, int year) : base(id, brand, model, year) { }
}

class Bai2
{
    static List<Vehicle> vehicles = new List<Vehicle>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nVehicle Management System");
            Console.WriteLine("1. Add a new Car");
            Console.WriteLine("2. Add a new Motor");
            Console.WriteLine("3. Remove a vehicle by ID");
            Console.WriteLine("4. Display all vehicles");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddVehicle(true);
                    break;
                case "2":
                    AddVehicle(false);
                    break;
                case "3":
                    RemoveVehicle();
                    break;
                case "4":
                    DisplayAllVehicles();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void AddVehicle(bool isCar)
    {
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter Brand: ");
        string brand = Console.ReadLine();
        Console.Write("Enter Model: ");
        string model = Console.ReadLine();
        Console.Write("Enter Year: ");
        int year = int.Parse(Console.ReadLine());

        Vehicle vehicle = isCar ? new Car(id, brand, model, year) : new Motor(id, brand, model, year);
        vehicles.Add(vehicle);
        Console.WriteLine("Vehicle added successfully!");
    }

    static void RemoveVehicle()
    {
        Console.Write("Enter the ID of the vehicle to remove: ");
        int id = int.Parse(Console.ReadLine());
        Vehicle vehicle = vehicles.Find(v => v.Id == id);
        if (vehicle != null)
        {
            vehicles.Remove(vehicle);
            Console.WriteLine("Vehicle removed successfully!");
        }
        else
        {
            Console.WriteLine("Vehicle not found!");
        }
    }

    static void DisplayAllVehicles()
    {
        if (vehicles.Count == 0)
        {
            Console.WriteLine("No vehicles available.");
            return;
        }
        Console.WriteLine("\nList of Vehicles:");
        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayInfo();
        }
    }
}
