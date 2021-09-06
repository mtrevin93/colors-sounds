using System;
using System.Globalization;

namespace Garage
{
    public class Tesla : Vehicle, IElectric // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 1.0;
        }
        public double CurrentChargePercentage { get; set; }
        public void DisplayCurrentCharge()
        {
            Console.WriteLine(CurrentChargePercentage.ToString("0.## %"));
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this} zips by you. MMmmmmm!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this} silently stop as if it never moved.");
        }
        public override string ToString()
        {
            return $"{MainColor} Tesla";
        }
    }
}