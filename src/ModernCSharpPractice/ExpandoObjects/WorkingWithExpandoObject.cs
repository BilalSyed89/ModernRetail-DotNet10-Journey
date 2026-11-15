namespace ModernCSharpPractice.ExpandoObjects;
public class    WorkingWithExpandoObject
{
    public static void CreateExpandoObject()
    {
        dynamic person = new ExpandoObject();
        person.FirstName = "bilal";
        person.LastName = "haider";
        person.Age = 30;

        WriteLine($"First Name: {person.FirstName}");
        WriteLine($"Last Name: {person.LastName}");
        WriteLine($"Age: {person.Age}");

        // using dictonary
        var personinfo=(IDictionary<string, object>)person;
    foreach (var kvp in personinfo)
        {
            WriteLine($"{kvp.Key}: {kvp.Value}");
        }

    }
}