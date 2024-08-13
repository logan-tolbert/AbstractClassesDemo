using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart;
        public override void DriveAbstract()
        {
            Console.WriteLine("Abstract Driving (Motorcycle): Engaged");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Virtual Driving (Motorcycle: Engaged");    
        }
    }
}
