using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("beep!"); 
        }
    }
}
