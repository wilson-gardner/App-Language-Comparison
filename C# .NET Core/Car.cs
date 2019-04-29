using System;
using CarCatalog.Options;
using CarCatalog.CarComponents;

namespace CarCatalog
{
    public class Car
    {
        public readonly string Year;
        public readonly string Make;
        public readonly string Model;
        public readonly string SerialNumber;
        public readonly Package Package;
        public readonly double MSRP;

        public Car(string year, string make, string model, string serialNumber, Package package, double msrp)
        {
            Year = year;
            Make = make;
            Model = model;
            SerialNumber = serialNumber;
            Package = package;
            MSRP = msrp;
        }

        public void PrintCarDetails()
        {
            Console.WriteLine("Vehicle Details:");
            Console.WriteLine($"{Year} {Make} {Model} : {Package.Name}");
            Console.WriteLine($"Engine: {Package.Engine.HorsePower}hp {Package.Engine.Size}");
            Console.WriteLine($"Color: {Package.PaintScheme.Name}");
            Console.WriteLine($"Fuel Economy:\nCity MPG: {Package.Engine.CityMPG}\nHighway MPG: {Package.Engine.HighwayMPG}");
            Console.WriteLine($"MSRP: {MSRP:N2}");
            Console.WriteLine($"{Package.Name} Price: {Package.Price:N2}");
            Console.WriteLine($"Total Price: {(Package.Price + MSRP):N2}");
        }

        public string GetVehicleName()
        {
            return string.Join(" ", Make, Model, Package.Name);
        }
    }
}