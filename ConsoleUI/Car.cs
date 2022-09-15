using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("drives"); 
        }
        public bool HasTrunk = true;

        public bool IsFWD { get; set; }
    }
}
