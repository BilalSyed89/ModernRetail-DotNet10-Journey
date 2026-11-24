public abstract class Vehicle
{

    public string? ElectricEngine { get; set; }

    public string? CombustionEngine { get; set; }

    public string? HybridEngine { get; set; }

    public abstract void Start();

    

}

public class Car : Vehicle
{

    public override void Start()
    {
        Console.WriteLine("Car is starting...");
    }

    public void OpenTrunk()
    {
        Console.WriteLine("Car is opening trunk...");
    }

}

public class Scooter : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Scooter is starting...");
    }

    public void KickStart()
    {
        Console.WriteLine("Scooter is kick starting...");
    }
}