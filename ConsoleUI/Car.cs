﻿using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine("The car is driving.");
        }


        public Car()
        {
        }
    }
}

