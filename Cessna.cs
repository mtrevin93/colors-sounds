namespace colors-sounds
{
    public class Cessna  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {Cessna.MainColor} Cessna zips by you. Zzzzooooomm!")
        }
    }
}