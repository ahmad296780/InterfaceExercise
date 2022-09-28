using System;
using System.Collections.Generic;

namespace InterfaceExercise
{

    class Program
    {

        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car honda = new Car()
            {
                HasTrunk = true,
                sedan = true,
                Logo = "H",
                MadeIn = "Japan",
                numberOfDoors = 4,
                numberOfSeats = 5,
                numberOfWheels = 4,
                numberOfWindows = 4
            };


            Truck ford = new Truck()
            {
                numberOfWindows = 4,
                numberOfWheels = 6,
                numberOfSeats = 4,
                numberOfDoors = 4,
                MadeIn = "America",
                Logo = "ford",
                HasOpenTrunk = true,
                truck = true
            };

            Suv esclade = new Suv()
            {
                Logo = "cadilac",
                MadeIn = "america",
                numberOfDoors = 4,
                numberOfSeats = 7,
                numberOfWheels = 4,
                numberOfWindows = 6,
                Has7Seats = true,
                suv = true
            };
            List<IVehicle> list = new List<IVehicle>();
            list.Add(honda);
            list.Add(ford);
            list.Add(esclade);
            foreach (var item in list)
            {
                Console.WriteLine($"{item.MadeIn}, " +
                    $"{item.numberOfWindows} ," +
                    $"{item.numberOfWheels}, " +
                    $"{item.Logo},{item.numberOfSeats}, " +
                    $"{item.numberOfDoors}");

            }

        }
    }
}
