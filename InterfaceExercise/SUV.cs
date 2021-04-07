using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle , ICompany
    {
        public SUV()
        {

        }

        public int NumberOfSeats { get; set; } = 7;
        public bool IsfourWheeldrive { get; set; } = true;

        public string Name { get; set; } = "General Motors";
        public int NumberOfEmployess { get; set; } = 32000;

        public int Year { get; set; } = 2021;
        public string Make { get; set; } = "GM";
        public string Model { get; set; } = "Tahoe";
        public string TireSize { get; set; } = "17 Inches";

        public void Drive()
        {
            if (IsfourWheeldrive == true)
            {
                Console.WriteLine($"fourwheeldrive {GetType().Name} is driving forward");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is driving forward");
            }
        }

        public void Reverse()
        {
            if (IsfourWheeldrive == true)
            {
                Console.WriteLine($"fourwheeldrive {GetType().Name} is now in reverse mode");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is now in reverse mode");
            }
        }
        public void Park()
        {
            if (IsfourWheeldrive == true)
            {
                Console.WriteLine($"fourwheeldrive {GetType().Name} is now in parking mode");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is now in parking mode");
            }
        }
    }
}
