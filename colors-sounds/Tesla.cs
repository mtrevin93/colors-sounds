using System;

namespace Garage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this} zips by you. MMmmmmm!");
        }
        public override string ToString()
        {
            return $"{MainColor} Tesla";
        }
    }
}