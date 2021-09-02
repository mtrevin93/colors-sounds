using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public void Turn(string direction)
        {
            Console.WriteLine($"The {this} turns {direction}.");
        }
        public void Stop()
        {

        }
    }
}