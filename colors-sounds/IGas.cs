namespace Garage
{
    public interface IGas
    {
        double FuelCapacity{get; set;}
        void RefuelTank();
        double CurrentTankPercentage{get; set;}
        void DisplayCurrentFuel();
    }
}