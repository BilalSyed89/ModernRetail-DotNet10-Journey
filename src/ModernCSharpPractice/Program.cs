Console.WriteLine("summary/chapter-02");


//How can you determine how many bytes a type like double uses in memory?

Console.WriteLine(sizeof(double));

Console.WriteLine("More-Examples");

Console.WriteLine($"byte: {sizeof(byte)}");
Console.WriteLine($"short: {sizeof(short)}");
Console.WriteLine($"int: {sizeof(int)}");
Console.WriteLine($"long: {sizeof(long)}");
Console.WriteLine($"float: {sizeof(float)}");
Console.WriteLine($"double: {sizeof(double)}");
Console.WriteLine($"decimal: {sizeof(decimal)}");

//When should you use the var keyword?

// Use var when the type is obvious from the right-hand side of the assignment and using var makes the code easier to read.

Dictionary<int, List<string>> customers =
    new Dictionary<int, List<string>>();

    var customers =
    new Dictionary<int, List<string>>();


    //What is the newest syntax to create an instance of a class like XmlDocument?

    XmlDocument xmlDocument = new XmlDocument();

    XmlDocument xmlDocument = new();

    //How do you right-align a format string?

    // In C# string interpolation, use a comma and a width value inside the braces
    //{value,width}

    int apples = 12;

Console.WriteLine($"|{apples,10}|");

// What type would you choose for the following “numbers”?

public record Medicine(
    int Id,
    string Name,
    decimal SalePrice,
    decimal PurchasePrice,
    double WeightInKg);
