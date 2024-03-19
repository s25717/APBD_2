using APBD2;

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        ContainerShip ship = new ContainerShip("MyShip", 20, 100, 20000);
        LiquidContainer liquidContainer = new LiquidContainer("KON-L-1", 10, 5, 5, 5000, 2);
        RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer("KON-C-1", 12, 6, 6, 6000, "Bananas", 5);

        try
        {
            ship.LoadContainer(liquidContainer);
            ship.LoadContainer(refrigeratedContainer);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}