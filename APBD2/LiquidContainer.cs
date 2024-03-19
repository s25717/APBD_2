namespace APBD2
{
    public class LiquidContainer : Container, IHazardNotifier
    {
        private bool _isHazardous;
        public double Pressure { get; }

        public LiquidContainer(string serialNumber, double height, double tareWeight, double depth, double maximumPayload, double pressure)
            : base(height, tareWeight, depth, maximumPayload)
        {
            Pressure = pressure;
            _isHazardous = true; // For demonstration purposes
        }

        public override void LoadCargo(double cargoMass)
        {
            if (_isHazardous && cargoMass > MaximumPayload * 0.5)
                throw new OverfillException("Hazardous cargo cannot exceed 50% of maximum payload.");

            base.LoadCargo(cargoMass);
        }

        public void NotifyHazardousSituation(string containerNumber)
        {
            Console.WriteLine($"Hazardous situation detected in container {containerNumber}");
        }
    }
}
