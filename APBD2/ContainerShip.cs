namespace APBD2
{
    public class ContainerShip
    {
        public string ShipName { get; }
        public double MaxSpeed { get; }
        public int MaxContainers { get; }
        public double MaxWeight { get; }

        private List<IContainer> _containers;

        public IReadOnlyList<IContainer> Containers => _containers;

        public ContainerShip(string shipName, double maxSpeed, int maxContainers, double maxWeight)
        {
            ShipName = shipName;
            MaxSpeed = maxSpeed;
            MaxContainers = maxContainers;
            MaxWeight = maxWeight;
            _containers = new List<IContainer>();
        }

        public void LoadContainer(IContainer container)
        {
            if (_containers.Count >= MaxContainers)
                throw new InvalidOperationException("Ship is already at maximum capacity.");

            double currentWeight = _containers.Sum(c => c.MassOfCargo);
            if (currentWeight + container.MassOfCargo > MaxWeight)
                throw new InvalidOperationException("Adding this container exceeds the maximum weight.");

            _containers.Add(container);
        }

        public void UnloadContainer(IContainer container)
        {
            _containers.Remove(container);
        }
    }

}