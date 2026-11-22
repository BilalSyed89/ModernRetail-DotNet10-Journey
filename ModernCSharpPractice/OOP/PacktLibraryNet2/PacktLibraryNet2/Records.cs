namespace Packt.Shared;

public class ImmutablePerson
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
}


public record ImmutableVehicle
{
    public int Wheels { get; init; }
    public string? Color { get; init; }
    public string? Brand { get; init; }
}


public record Engineer(string Name, string? Specialty);

// Example of internal access modifier
internal class StockCalculator
{
    internal decimal CalculateValue()
    {
        return 100m;
    }
}


//Exmple of protected access modifier
public class Vehicle
{
    private protected  void CheckEngine()
    {
        Console.WriteLine("Checking engine...");
    }
}

public class Car : Vehicle
{
    public void StartInspection()
    {
        CheckEngine(); // Allowed
    }
}
