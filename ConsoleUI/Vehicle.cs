using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Default driving behavior.");
        }
        public int Year { get; set; } = 1900;
        public string Make { get; set; } = "Default";
        public string Model { get; set; } = "Default";
    }
}





