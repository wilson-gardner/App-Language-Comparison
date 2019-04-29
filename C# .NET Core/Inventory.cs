using System;
using System.Collections.Generic;

namespace CarCatalog
{
    public class Inventory
    {
        public readonly List<Car> Vehicles;

        public Inventory()
        {
            Vehicles = new List<Car>();
        } 

        public void AddVehicle(Car vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public Car FindVehicle(string serialNumber)
        {
            foreach (Car vehicle in Vehicles)
            {
                if (String.Equals(vehicle.SerialNumber, serialNumber, StringComparison.InvariantCultureIgnoreCase))
                {
                    return vehicle;
                }
            }
            return null;
        }
    }
}