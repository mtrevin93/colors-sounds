using System;
using System.Globalization;

namespace Garage
{
    public class Cessna : Vehicle, IGas // Propellor light aircraft

    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 1.0;
        }
        public double CurrentTankPercentage { get; set; }
        public void DisplayCurrentFuel()
        {
            Console.WriteLine(CurrentTankPercentage.ToString("P", CultureInfo.InvariantCulture));
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this} zips by you. Zzzzooooomm!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this} rolls to a stop after rolling a mile down the runway");
        }
        public override string ToString()
        {
            return $"{MainColor} Cessna";
        }
    }
}