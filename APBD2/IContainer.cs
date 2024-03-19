namespace APBD2
{
    public interface IContainer
    {
        string SerialNumber { get; }
        double MassOfCargo { get; }
        double Height { get; }
        double TareWeight { get; }
        double Depth { get; }
        double MaximumPayload { get; }
        void LoadCargo(double mass);
        void EmptyCargo();
    }
}
