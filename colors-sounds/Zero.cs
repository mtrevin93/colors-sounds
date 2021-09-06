using System;

namespace Garage
{
    public class Zero : Vehicle, IElectric // Electric motorcycle
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