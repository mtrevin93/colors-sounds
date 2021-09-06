namespace Garage
{
    public interface IGas
    {
        double FuelCapacity{get; set;}
        void RefuelTank();
        float CurrentTankPercentage{get; set;}
    }
}