namespace APBD2
{
    public class Container : IContainer
    {
        private static int _instanceCount = 0;
       
        private readonly string _serialNumber;
        public string SerialNumber => _serialNumber;
        public double MassOfCargo { get; set; }
        public double Height { get; }
        public double TareWeight { get; }
        public double Depth { get; }
        public double MaximumPayload { get; }


        public Container(double height, double tareWeight, double depth, double maximumPayload)
        {
            _instanceCount++; // Increment the instance count for each new container
            _serialNumber = GenerateSerialNumber();
            Height = height;
            TareWeight = tareWeight;
            Depth = depth;
            MaximumPayload = maximumPayload;
        }
        private string GenerateSerialNumber()
        {
            // Fixed part of the serial number
            string prefix = "KON";

            // Combine the fixed part with the instance count to form the serial number
            return $"{prefix}-{_instanceCount}";
        }

        public virtual void LoadCargo(double cargoMass)
        {
            if (cargoMass > MaximumPayload)
                throw new OverfillException("Cargo mass exceeds maximum payload.");

            MassOfCargo += cargoMass;
        }

        public void EmptyCargo()
        {
            MassOfCargo = 0;
        }
    }

}