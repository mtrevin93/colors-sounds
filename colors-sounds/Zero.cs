using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {this} zips by you. Yeeeeowwwww!");
        }
        public override string ToString()
        {
            return $"{MainColor} Zero";
        }
    }
}