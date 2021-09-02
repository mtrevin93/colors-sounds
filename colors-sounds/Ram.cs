using System;

namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this} zips by you. Rrrrrruummmbbble!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this} gently rolls to a stop.")
        }
        public override string ToString()
        {
            return $"{MainColor} Ram";
        }
    }
}