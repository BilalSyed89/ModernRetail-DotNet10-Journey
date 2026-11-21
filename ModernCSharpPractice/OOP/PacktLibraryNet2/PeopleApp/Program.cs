using Packt.Shared;
using PacktLibraryNet2;

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