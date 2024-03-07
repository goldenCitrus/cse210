using System.Runtime.InteropServices;
using Internal;
// using Microsoft.CodeQuality.Analyzers.ApiDesignGuidelines;

abstract class Employee
{

    public string name;

    public abstract decimal CalculatePay();
    public Employee(string name)
    {
        this.name = name;
    }
}

class SalaryEmployee : Employee
{
    protected decimal annualSalary;

    public SalaryEmployee(string name, double annualSalary) : base(name)
    {
        this.annualSalary = (decimal) annualSalary;
    }

    public override decimal CalculatePay()
    {
        return annualSalary / 26; //Bi-weekly
    }
}


class HourlyEmployee : Employee
{

    protected decimal HourlyRate;
    protected int hoursWorked;

    public HourlyEmployee(string name, double HourlyRate, int hoursWorked) : base(name)
    {
        this.HourlyRate = (decimal) HourlyRate;
        this.hoursWorked = hoursWorked;
    }

    public override decimal CalculatePay()
    {
        return (HourlyRate * hoursWorked) * 2;
    }

}

SalaryEmployee salaryEmployee = new SalaryEmployee("Jhon", 96000.89);
HourlyEmployee hourlyEmployee = new HourlyEmployee("Jhon", 13.50, 80);

Console.WriteLine($"{salaryEmployee.name} makes ${salaryEmployee.CalculatePay() :N2} bi-weekly");
Console.WriteLine($"{hourlyEmployee.name} makes ${hourlyEmployee.CalculatePay() :N2} bi-weekly")