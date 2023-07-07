using System;
namespace ConsoleUI
{
	public class Motorcycle: Vehicle
	{
        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()

		{
			Console.WriteLine("The Motorcycle drives fast");
		}
        public override void DriveVirtual()
        {
			Console.WriteLine("This Motercycle can drive"); 
        }
        public Motorcycle()
		{
		}
	}
}

