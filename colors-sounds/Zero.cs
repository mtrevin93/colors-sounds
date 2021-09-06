using System;
using System.Globalization;

namespace Garage
{
    public class Zero : Vehicle, IElectric // Electric motorcycle
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
            Console.WriteLine($"The {this} zips by you. Yeeeeowwwww!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this} gently comes to a stop.");
        }
        public override string ToString()
        {
            return $"{MainColor} Zero";
        }
    }
}