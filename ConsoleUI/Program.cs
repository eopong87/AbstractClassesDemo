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
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - done
             * 
             * The vehicle class shall have three string properties Year, Make, and Model - done
             * 
             * Set the defaults to something generic in the Vehicle class - done
             * Vehicle shall have an abstract method called DriveAbstract with no implementation- done
             * 
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.-done
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle -done
             * 
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle- done
             * Provide the implementations for the abstract methods- done
             * Only in the Motorcycle class will you override the virtual drive method- done
            */

            // Create a list of Vehicle called vehicles

            var vehicle = new List<Vehicle>();
            

            var Car1 = new Car();
            Car1.DriveVirtual();
            Car1.DriveAbstract();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes*/
            Car Honda = new Car()
            {
                HasTrunk = true,
                Make = "Honda",
                Model = "Accord",
                Year = 2020,
            };

            Honda.DriveVirtual();
            Honda.DriveAbstract();

            var Motorcycle = new Motorcycle()
            
            {
                HasSideCart = false,
                Make = "bmw",
                Model = "sazuki",
                Year = 2000,


            };
            Motorcycle.DriveVirtual();
            Motorcycle.DriveAbstract();


            Vehicle SportsCar = new Car()
            {
                HasTrunk = true,
                Model = "CL series",
                Make = "benz",
                Year = 2011,
            };
            SportsCar.DriveVirtual();
            SportsCar.DriveAbstract();


            Vehicle Minivan = new Car()
            {
                HasTrunk = true,
                Make = "Dodge",
                Model = "Charger",
                Year = 2023,
            };
            Minivan.DriveVirtual();
            Minivan.DriveAbstract();

            /* Set the properties with object initializer syntax
 */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicle.Add(SportsCar);
            vehicle.Add(Minivan);
            vehicle.Add(Motorcycle);
            vehicle.Add(Honda);

            foreach (var item in vehicle)
            {
                Console.WriteLine($"Make{item.Make}");
                Console.WriteLine($"Model{item.Model}");
                Console.WriteLine($"Year {item.Year}");
            }
            // Call each of the drive methods for o
            // ne car and one motorcycle

            #endregion
            Console.ReadLine();
        }

 
        }
}

