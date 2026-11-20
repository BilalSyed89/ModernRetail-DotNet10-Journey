Console.WriteLine("Null-coalescing operators");


// Before null-coalescing


string name;
string inputName=null;

if (inputName != null)
{
    name = inputName;
}
else
{
    name = "Unknown";
}

Console.WriteLine(name);

//Much simpler with ??

 name = inputName ?? "Unknown";

 Console.WriteLine(name);

 //Null-Coalescing Operator (??)

 string? medicineName=null;

 Console.WriteLine(medicineName ?? "No Medicine ");

 int? age = null;

int displayAge = age ?? 0;

Console.WriteLine(displayAge);