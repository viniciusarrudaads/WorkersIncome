using Enumeração.Entities.Enums;
using Enumeração.Entities;
namespace Enumeração;

class Program
{
    static void Main(string[] args)
    {
        
        Department department = new Department();
        HourContract hourContract = new HourContract();

        Console.WriteLine("Department: ");
        string dp = Console.ReadLine();
        dp = department.Name;
        
        
        Console.WriteLine("Worker Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Worker level (Junior, Mid_Level,Senior)");
        string level = Console.ReadLine();

        Level seniority = Enum.Parse<Level>(level);

        Console.WriteLine("Base salary: ");
        decimal baseSalary = decimal.Parse(Console.ReadLine());

        Worker worker = new Worker(name,seniority, baseSalary);

        worker.AddContract(hourContract);

        Console.WriteLine("What month you want to calculate the income? ");
        string incomeDate = Console.ReadLine();

        string[] monthYear = incomeDate.Split('/'); // split para atribuir a data aos dois parametros

        int month = int.Parse(monthYear[0]);
        int year = int.Parse(monthYear[1]);

        worker.Income(month, year);

        Console.WriteLine(worker);

    }

}