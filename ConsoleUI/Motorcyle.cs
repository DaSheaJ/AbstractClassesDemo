﻿using System;
namespace ConsoleUI
{
    public class Motorcyle : Vehicle
    {
        public Motorcyle()
        {
        }

        public bool HasSideCart { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle is in drive");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a { GetType().BaseType.Name } that is virtually in drive");
        }



    }
}
