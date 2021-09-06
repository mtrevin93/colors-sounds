using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero() {BatteryKWh = 500, CurrentChargePercentage = 0.3234};
            Zero fx = new Zero() { BatteryKWh = 300, CurrentChargePercentage = 0.73456 };
            Tesla modelS = new Tesla() { BatteryKWh = 250, CurrentChargePercentage = 0.9234 };

            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectric ev in electricVehicles)
            {
                ev.DisplayCurrentCharge();
            }

            foreach(IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram () { FuelCapacity = 35, CurrentTankPercentage = 0.5646 };
            Cessna cessna150 = new Cessna () { FuelCapacity = 25, CurrentTankPercentage = 0.8246 };

            List<IGas> gasVehicles = new List<IGas>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGas gv in gasVehicles)
            {
                gv.DisplayCurrentFuel();
            }

            foreach(IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}