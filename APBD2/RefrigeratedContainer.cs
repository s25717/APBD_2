namespace APBD2
{
    public class RefrigeratedContainer : Container
    {
        public string ProductType { get; }
        public double Temperature { get; }

        public RefrigeratedContainer(string serialNumber, double height, double tareWeight, double depth, double maximumPayload, string productType, double temperature)
            : base(height, tareWeight, depth, maximumPayload)
        {
            ProductType = productType;
            Temperature = temperature;
        }

        public override void LoadCargo(double cargoMass)
        {
            if (cargoMass > MaximumPayload)
                throw new OverfillException("Cargo mass exceeds maximum payload.");

            base.LoadCargo(cargoMass);
        }
    }
}