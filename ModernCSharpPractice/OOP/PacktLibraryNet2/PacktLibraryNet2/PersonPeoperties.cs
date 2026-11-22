namespace Packt.Shared;

public partial class Person
{


    #region Properties: Methods to get and/or set data or state.
    // A readonly property defined using C# 1 to 5 syntax.
    public string Origin
    {
        get
        {
            return string.Format("{0} was born on {1}.",
              arg0: Name, arg1: HomePlanet);
        }
    }
    // Two readonly properties defined using C# 6 or later
    // lambda expression body syntax.
    public string Greeting => $"{Name} says 'Hello!'";
    public int Age => DateTime.Today.Year - Born.Year;
    #endregion

    public string? FavoriteIceCream { get; set; }

   // private string? _favoritePrimaryColor;
    // A public property to read and write to the field.
    public string? FavoritePrimaryColor
    {
        get
        {
            return field;

        }
        set
        {
            switch (value?.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                  field = value;
                    break;
                default:
                    throw new ArgumentException(
                    $"{value} is not a primary color. " +
                    "Choose from: red, green, blue.");
            }
        }
    }


}