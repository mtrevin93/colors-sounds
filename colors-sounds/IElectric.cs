namespace Garage

{
    public interface IElectric 
    {
        double BatteryKWh {get; set;}
        void ChargeBattery();
    }

}