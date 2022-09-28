using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle : ICompany
    {
        int numberOfWheels { get; set; }
        int numberOfDoors { get; set; }
        int numberOfWindows { get; set; }
        int numberOfSeats { get; set; }

    }
    public interface ICompany
    {
        string Logo { get; set; }
        string MadeIn { get; set; }

    }

    public class Car : IVehicle
    {
        public bool HasTrunk { get; set; }
        public bool sedan { get; set; }
        public string Logo { get; set; }
        public string MadeIn { get; set; }
        public int numberOfWheels { get; set; }
        public int numberOfDoors { get; set; }
        public int numberOfWindows { get; set; }
        public int numberOfSeats { get; set; }


    }
    public class Truck : IVehicle
    {
        public bool HasOpenTrunk { get; set; }
        public bool truck { get; set; }
        public int numberOfWheels { get; set; }
        public int numberOfDoors { get; set; }
        public int numberOfWindows { get; set; }
        public int numberOfSeats { get; set; }
        public string Logo { get; set; }
        public string MadeIn { get; set; }
    }
    public class Suv :  IVehicle
    {
        public bool suv { get; set; }
        public bool Has7Seats { get; set; }

        public int numberOfWheels { get; set; }
        public int numberOfDoors { get; set; }
        public int numberOfWindows { get; set; }
        public int numberOfSeats { get; set; }
        public string Logo { get; set; }
        public string MadeIn { get; set; }
    }
}
