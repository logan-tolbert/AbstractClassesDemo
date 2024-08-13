using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /*
     * Create an abstract class called Vehicle
     * The vehicle class shall have three string properties: Year, Make, and Model
     * Set the defaults of the properties to something generic in the Vehicle class
     * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
     * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
     */
    internal abstract class Vehicle
    {
        public string Year { get; set; } = @"n\a";
        public string Make { get; set; } = @"n\a";
        public string Model { get; set; } = @"n\a";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Virtual driving (default): Engaged");
        }

    }
}
