using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle , ICompany
    {
        public Truck()
        {

        }

        public int bedsize { get; set; } = 90;

        public int loadcapacity { get; set; } = 6000;

        public string Name { get; set; } = "Nissan Industries";
        public int NumberOfEmployess { get; set; } = 15000;

        public int Year { get; set; } = 2027;
        public string Make { get; set; } = "Nissan";
        public string Model { get; set; } = "Frontier";
        public string TireSize { get; set; } = " 18 Inches";

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
