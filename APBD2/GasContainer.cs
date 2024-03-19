using APBD2;

namespace APBD2
{
    public class GasContainer : Container, IHazardNotifier
    {
        private double _remainingCargo;

        public double Pressure { get; }

        public GasContainer(string serialNumber, double height, double tareWeight, double depth, double maximumPayload, double pressure)
            : base(height, tareWeight, depth, maximumPayload)
        {
            Pressure = pressure;
            _remainingCargo = maximumPayload * 0.05; // 5% left initially
        }

        public override void LoadCargo(double cargoMass)
        {
            if (cargoMass > MaximumPayload)
                throw new OverfillException("Cargo mass exceeds maximum payload.");

            base.LoadCargo(cargoMass);
        }

        public void NotifyHazardousSituation(string containerNumber)
        {
            Console.WriteLine($"Hazardous situation detected in container {containerNumber}");
        }

        public void EmptyGas()
        {
            _remainingCargo = MaximumPayload * 0.05;
        }
    }
}