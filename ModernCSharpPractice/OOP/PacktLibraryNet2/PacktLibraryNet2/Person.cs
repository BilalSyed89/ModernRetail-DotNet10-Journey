
using CustomerInfo = (string Title, string Address, string Contact);


using PacktLibraryNet2;

namespace Packt.Shared;

public partial class Person 
{
    public WondersOfTheAncientWorld BucketList;
    public WondersOfTheAncientWorld FavoriteAncientWonder;

    public ProfessionalGames FavoriteProfessionalGame;

    public List<Person> Children = new();

    public const string Species = "Homo Sapiens";
    public readonly string HomePlanet = "Earth";


    #region Fields: Data or state for this person.
    public string? Name; // ? means it can be null.
    public DateTimeOffset Born;
    #endregion


    public void PassingParameters(int w, in int x, ref int y, out int z)
    {
        // out parameters cannot have a default and they
        // must be initialized inside the method.
        z = 100;
        // Increment each parameter except the read-only x.
        w++;
        // x++; // Gives a compiler error!
        y++;

        z++;
        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
    }


    public void ParamsParameters(
     string text, params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)

        {
            total += number;
        }
        WriteLine($"{text}: {total}");
    }

    //Tuples

    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }


    public (string MedicineName, int Price) GetMedicineInfo()
    {

        return ("Paracetamol", 10);

    }



    public CustomerInfo GetCustomerInfo()


    {

        StockCalculator calculator = new();
        calculator.CalculateValue();


        return ("PoundsSHop", "123 Main St", "555-1234");
    }


    // Local Functions

    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(
              $"{nameof(number)} cannot be less than zero.");
        }
        return localFactorial(number);

        int localFactorial(int localNumber) // Local function.
        {
            if (localNumber == 0) return 1;
            return localNumber * localFactorial(localNumber - 1);
        }
    }



}