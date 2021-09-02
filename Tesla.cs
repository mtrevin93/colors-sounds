namespace colors-sounds
{
    public class Tesla  // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {Tesla.MainColor} Tesla zips by you. MMmmmmm!")
        }
    }
}