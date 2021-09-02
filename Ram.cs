namespace colors-sounds
{
    public class Ram  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {Ram.MainColor} Ram zips by you. Rrrrrruummmbbble!")
        }
    }
}