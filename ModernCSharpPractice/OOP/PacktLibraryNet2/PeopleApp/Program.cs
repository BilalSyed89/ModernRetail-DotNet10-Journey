using Packt.Shared;




void ShowMessage(string message) { 

    Console.WriteLine(message);

}

//Action<string> ShowMessageAction = ShowMessage;

decimal salaryCalculator(decimal salary, int days)
{
    return salary * days;
}

decimal calculateBonus(decimal salary,decimal bonusRate) {


    return salary + bonusRate;


}

bool CheckDays(int days)
{
    if (days < 0)
    {
        ShowMessage("Days cannot be negative");
        return false;
    }
    return true;
}


void CalculateSalary(string employeeName,
    decimal Salary,
    int days,decimal bonusRate,Predicate<int> dayValidator,Func<decimal,int,decimal> calculator,Func<decimal,decimal,decimal> bonusCalculator,
    Action<string> notification) {
    
    if (!dayValidator(days))
    {

     
        return;
    }

    decimal totalSalary = calculator(Salary, days);

    decimal bonus = bonusCalculator(Salary, bonusRate);

    notification($"EmployeeName : {employeeName}");

    notification($"Salary : {Salary}");

    notification($"Days : {days}");

    notification($"Total Salary : {totalSalary}");

    notification($"Bonus : {bonusRate}");

    notification($"Salary after Bonus  : {bonus}");

    notification("Salary Calculation Completed");

    notification("--------------------------------------------------");

}


CalculateSalary("John", 1000, 20,3, CheckDays, salaryCalculator,calculateBonus, ShowMessage);
CalculateSalary("Jane", 1500, 15,3, CheckDays, salaryCalculator,calculateBonus, ShowMessage);
CalculateSalary("Bob", 2000, 10,3, CheckDays, salaryCalculator,calculateBonus, ShowMessage);
CalculateSalary("Alice", 2500, -1,3, CheckDays, salaryCalculator,calculateBonus  , ShowMessage);


