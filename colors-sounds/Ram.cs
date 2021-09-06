using System;
using System.Globalization;

namespace Garage
{
    public class Ram : Vehicle, IGas // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 1.00;
        }
        public double CurrentTankPercentage { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"The {this} zips by you. Rrrrrruummmbbble!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this} gently rolls to a stop.");
        }
        public void DisplayCurrentFuel()
        {
            Console.WriteLine(CurrentTankPercentage.ToString("0.00%"));
        }
        public override string ToString()
        {
            return $"{MainColor} Ram";
        }
    }
}