using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectric // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public double 
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