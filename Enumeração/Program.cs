using Enumeração.Entities;
using Enumeração.Entities.Enums;
namespace Enumeração;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Department: ");
        string dpName = Console.ReadLine();

        Console.WriteLine("Worker Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Worker level (Junior, Mid_Level,Senior)");
        string level = Console.ReadLine();

        Level seniority = Enum.Parse<Level>(level);
        
        Console.WriteLine("Base salary: ");
        decimal baseSalary = decimal.Parse(Console.ReadLine());
        
        Department dp = new Department(dpName);
        Worker worker = new Worker(name, seniority, baseSalary, dp);

        Console.WriteLine("How many contracts you want to register? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("CONTRACT #" + (i + 1));
            Console.WriteLine();

            Console.WriteLine("Date DD/MM/YYYY: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Value per hour: ");
            decimal valuePerHour = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Hours: ");
            int hours = int.Parse(Console.ReadLine());

            HourContract contract = new HourContract(date, valuePerHour, hours);
            worker.AddContract(contract);
        }

        Console.WriteLine("What month you want to calculate the income? ");
        string incomeDate = Console.ReadLine();

        int month = int.Parse(incomeDate.Substring(0,2));
        int year = int.Parse(incomeDate.Substring(3));   //08/2026

        worker.Income(month, year);

        Console.WriteLine($"Name:{worker.Name} ");
        Console.WriteLine($"Department: {dp.Name}");
        Console.WriteLine($"Income for {month}/{year}:{worker.Income(month,year)}");


    }

}