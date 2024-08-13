using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles


            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            var car = new Car()
            {
                HasTrunk = true,
                Year = "2006",
                Make = "Toyota",
                Model = "Corolla",
            };

            var motorcycle = new Motorcycle()
            { HasSideCart = false, Year = "2014", Model = "FLHXS", Make = "Harley Davidson" };
            Vehicle vehicle1 = new Car() { Year = "2002", Make = "Toyota", Model = "Avalon", HasTrunk = true };
            Vehicle vehicle2 = new Motorcycle() { Year = "2005", Make = "BMW", Model = "R1200RT", HasSideCart = false };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */



            vehicles.Add(car);
            vehicles.Add(motorcycle);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}\n Make: {vehicle.Make}\n Model: {vehicle.Model}\n");
            }

            // Call each of the drive methods for one car and one motorcycle
            car.DriveAbstract();
            car.DriveVirtual();
            motorcycle.DriveAbstract();
            motorcycle.DriveVirtual();
            #endregion
            Console.ReadLine();
        }
    }
}
