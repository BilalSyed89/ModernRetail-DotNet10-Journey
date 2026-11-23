using Packt.Shared;




static void ShowMessage(string message)
{
    Console.WriteLine(message);
}



static void CalculateSalary(
    string employeeName,
    decimal dailySalary,
    int workingDays,
    Func<decimal, int, decimal> calculator,
    Action<string> notification)
{
    decimal totalSalary = calculator(dailySalary, workingDays);

    notification($"Calculating salary for {employeeName}...");
    notification($"Daily salary: {dailySalary:C}");
    notification($"Working days: {workingDays}");
    notification($"Total salary: {totalSalary:C}");
    notification("Summary Ends....");
    notification("============================================================");
}






Func<decimal, int, decimal> salaryCalculator =
    (dailySalary, workingDays) => dailySalary * workingDays;





CalculateSalary(
    "Bilal",
    65.5m,
    20,
    salaryCalculator,
    ShowMessage);

CalculateSalary(
    "Hadi",
    70m,
    20,
    salaryCalculator,
    ShowMessage);

CalculateSalary(
    "Hassan",
    90m,
    20,
    salaryCalculator,
    ShowMessage);

CalculateSalary(
    "Haider",
    120m,
    20,
    salaryCalculator,
    ShowMessage);