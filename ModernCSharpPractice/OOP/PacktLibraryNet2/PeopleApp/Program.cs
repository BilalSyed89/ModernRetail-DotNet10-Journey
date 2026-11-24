

using Packt.Shared;
using PacktLibraryNet2;
public partial class Program
{
    public static void Main()
    {



                    

        EMployee emp = new()
        {
            Name2 = "John Doe",

            Born2 = new DateTimeOffset(
            year: 1990,
            month: 7,
            day: 28,
            hour: 0,
            minute: 0,
            second: 0,
            offset: TimeSpan.Zero)
        };

        emp.WriteToConsole();

        emp.EmployeeCode = "E12345";
        emp.
            HireDate = new DateOnly(year: 2020, month: 1, day: 15);

        WriteLine($"{emp.Name2} was hired on {emp.HireDate:dddd, d MMMM yyyy} with employee code {emp.EmployeeCode}.");



      
    











    }
}


