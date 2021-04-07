using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle , ICompany
    {
        public Car()
        {

        }

        public int trunksize { get; set; } = 18;

        public string Engine { get; set; } = "4 cylinders";

        public string Name { get; set; } = "Volkswagen Motors";
        public int NumberOfEmployess { get; set; } = 23000;

        public int Year { get; set; } = 2019;
        public string Make { get; set; } = "VW";
        public string Model { get; set; } = "Gol";
        public string TireSize { get; set; } = "15 inches";

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is driving forward");
        }
        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} is now in reverse mode");
        }
        public void Park()
        {
            Console.WriteLine($"{GetType().Name} is now in parking mode");
        }
    }
}
