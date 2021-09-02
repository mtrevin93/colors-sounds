using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero{BatteryKWh = 100.5, MainColor = "Blue", MaximumOccupancy = 2};
            Tesla modelS = new Tesla{BatteryKWh = 200.5, MainColor = "Black", MaximumOccupancy =2};
            Cessna mx410 = new Cessna{FuelCapacity = 300.2, MainColor = "Red", MaximumOccupancy =4};
            Ram ramThing = new Ram{FuelCapacity = 500.4, MainColor = "White", MaximumOccupancy = 4};

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            ramThing.Drive();

            fxs.Turn("left");
        }
    }
}