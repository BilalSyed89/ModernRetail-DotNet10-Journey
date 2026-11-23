using Packt.Shared;



Person harry = new() { Name = "Harry" ,
Born = DateTimeOffset.Now };

System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");


int key = 2; // Look up the value that has 2 as its key.
WriteLine(format: "Key {0} has value: {1}",
  arg0: key,
  arg1: lookupObject[key]);


WriteLine(format: "Key {0} has value: {1}",
  arg0: harry,
  arg1: lookupObject[harry]);


// Define a generic lookup collection.
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
//lookupIntString.Add(key: harry, value: "Delta");
lookupIntString.Add(key: 4, value: "Delta");

foreach (var item in lookupIntString)
{
    WriteLine(format: "Key {0} has value: {1}",
      arg0: item.Key,
      arg1: item.Value);

}


Person p1 = new();
DelegateWithReturnType d =new(p1.LengthOfText);

static void ShowMessage(string message)
{
    Console.WriteLine(message);
}

MessageHandler m = ShowMessage;

m("Hello, World!");

delegate int DelegateWithReturnType(string text);
public delegate void MessageHandler(string message);