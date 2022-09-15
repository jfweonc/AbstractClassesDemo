using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle: Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("canDrive");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("driveVirtual"); 
        }
        public bool HasSide = true; 
    }
}
