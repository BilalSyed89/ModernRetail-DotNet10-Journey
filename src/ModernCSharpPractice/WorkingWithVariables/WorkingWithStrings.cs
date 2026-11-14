//Verbatim literal strings
namespace ModernCSharpPractice.WorkingWithVariables;



public static class WorkingWithStrings
{
    public static void ConvertToVerbatimLiteralString()
    {
        string filePath =
            @"C:\Users\Black\source\repos\ModernRetail-DotNet10-Journey\src\ModernCSharpPractice\WorkingWithVariables\WorkingWithStrings.cs";

        WriteLine(filePath);
    }


    public static void InterpolatedStringLiterals()
    {
        var person=new {FIrstName="John",LastName="Doe"};

        string json = $$"""
{
  "first_name": "{{person.FIrstName}}",
  "last_name": {{person.LastName}},
  "calculation": "{{{ 1 + 2 }}}"
}
""";

        WriteLine(json);

        
    }
}

