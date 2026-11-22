using Packt.Shared;
using PacktLibraryNet2;
using Dumpify;
using Person = Packt.Shared.Person;
ConfigureConsole(); // Sets current culture to US English

Person bob = new();

bob.Name = "Bob Smith";


// Works with all versions of C#.
Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);


bob.Children.Add(new Person { Name = "Bella" });
// Works with C# 9 and later.
bob.Children.Add(new() { Name = "Zoe" });
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}




BankAccount.InterestRate = 0.012M; // Store a shared value in static field.
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine(format: "{0} earned {1:C} interest.",
  arg0: jonesAccount.AccountName,
  arg1: jonesAccount.Balance * BankAccount.InterestRate);
BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
  arg0: gerrierAccount.AccountName,
  arg1: gerrierAccount.Balance * BankAccount.InterestRate);



// Constant fields are accessible via the type.
WriteLine($"{bob.Name} is a {Person.Species}.");

WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");



bob.Dump(label: "Default output");
bob.Dump(label: "Include fields and non-public members",
  members: new MembersConfig
  {
      IncludeFields = true,
      IncludeNonPublicMembers = true
  });



int a = 10;
int b = 20;
int c = 30;
int d = 40;
WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");
bob.PassingParameters(a, b, ref c, out d);
WriteLine($"After: a={a}, b={b}, c={c}, d={d}");




bob.ParamsParameters("Sum using commas",
  3, 6, 1, 2);
bob.ParamsParameters("Sum using collection expression",
  [3, 6, 1, 2]);
bob.ParamsParameters("Sum using explicit array",
  new int[] { 3, 6, 1, 2 });
bob.ParamsParameters("Sum (empty)");


(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");


var medicineInfo = bob.GetMedicineInfo();

WriteLine($"Medicine Name: {medicineInfo.MedicineName}, Price: {medicineInfo.Price}");


var customerInfo = bob.GetCustomerInfo();

WriteLine($"Customer Name: {customerInfo.Title}, Address: {customerInfo.Address}, Phone: {customerInfo.Contact}");


// Deconstruct the return value into two separate variables.
(string title, string address, string contact) = bob.GetCustomerInfo();
// You can then access the separate variables.
WriteLine($"Customer Name: {title}, Address: {address}, Phone: {contact}");


int number = 5;
try
{
    WriteLine($"{number}! is {Person.Factorial(number)}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}.");
}


WriteLine($"Cost of batch : {Person.CostOfBatch("A100"):C}");




// Demonstrate partial methods and classes.

MedicineBatch batch = new();

batch.ChangeBatchNumber("BATCH-001");
batch.ChangeBatchNumber("BATCH-002");

Console.WriteLine($"Current batch: {batch.BatchNumber}");


Person sam = new()
{
    Name = "Sam",
    Born = new(1969, 6, 25, 0, 0, 0, TimeSpan.Zero)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);



sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
string color = "Red";
try
{
    sam.FavoritePrimaryColor = color;
    WriteLine($"Sam's favorite primary color is {sam.
  FavoritePrimaryColor}.");
    
}
catch (Exception ex)
{
    WriteLine("Tried to set {0} to '{1}': {2}",
      nameof(sam.FavoritePrimaryColor), color, ex.Message);
}


//init only properties

ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Winger"
};

ImmutableVehicle car = new()
{
    Wheels = 4,
    Color = "Red",
    Brand = "Toyota"
};

ImmutableVehicle repaintedCar = car
  with
{ Color = "Polymetal Grey Metallic" };

WriteLine($"Original car color was {car.Color}.");
WriteLine($"New car color is {repaintedCar.Color}.");

//example of positional record
Engineer engineer = new("Sarah", "Aerospace");

WriteLine($"Engineer {engineer.Name} specializes in {engineer.Specialty}.");



//Example of protected access modifier

Car cars = new();
cars.StartInspection(); // Allowed because StartInspection is public
