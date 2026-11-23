using Packt.Shared;




static void ShowMessage(string message)
{
    Console.WriteLine(message);
}








 

    static void CalculateSalary(
        string employeeName,
        decimal dailySalary,
        int workingDays,
       Action<string> notification)
    {
        decimal totalSalary = dailySalary * workingDays;

        notification($"Calculating salary for {employeeName}...");
    notification($"Daily salary: {dailySalary:C}");
    notification($"Working days: {workingDays}");
    notification($"Total salary: {totalSalary:C}");
   

    notification("Summary Ends....");

    notification("============================================================");


}

CalculateSalary("Bilal", 65.5m, 20, ShowMessage);
CalculateSalary("Hadi", 70, 20, ShowMessage);
CalculateSalary("Hassan", 90m, 20, ShowMessage);
CalculateSalary("Hassan", 120m, 20, ShowMessage);





