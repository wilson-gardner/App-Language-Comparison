using System;
using CarCatalog.Options;
using CarCatalog.CarComponents;

namespace CarCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory dealershipInventory = new Inventory();
            Engine premiumEngine = new Engine(Engine.Cylinders.V8, 456, 32, 30);
            Paint premiumPaint = new Paint("Frost White", Paint.PaintClass.Premium, new int[]{255, 255, 255});
            Package premiumPackage = new Package("Premium", 3095.40, premiumEngine, premiumPaint);
            
            var mustang = new Car("2019", "Ford", "Mustang", "FM2019", premiumPackage, 54990.00);
            dealershipInventory.AddVehicle(mustang);

            // Test search
            Console.Write("Please enter the serial number of the vehicle you are looking for: ");
            var serialNumber = Console.ReadLine();

            try {
                dealershipInventory.FindVehicle(serialNumber).PrintCarDetails();
            } catch (Exception e) {
                Console.WriteLine($"{e.Message} : {e.HResult}");
            }
            
        }
    }
}
