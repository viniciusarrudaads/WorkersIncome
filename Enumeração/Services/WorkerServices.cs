using Enumeração.Entities.Enums;
using Enumeração.Entities;
namespace Enumeração.Services;

public class WorkerServices
{
    public static Worker AddWorker()
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
         return new Worker(name, seniority, baseSalary,dp);
    }


}
