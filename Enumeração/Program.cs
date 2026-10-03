using Enumeração.Entities.Enums;
using Enumeração.Entities;
using Enumeração.Services;
namespace Enumeração;

class Program
{
    static void Main(string[] args)
    {
        Worker worker = new Worker();
        HourContract contract = new HourContract();
        Department dp = new Department();


        WorkerServices.AddWorker(worker);
        ContractServices.AddContract(contract);
        
        Console.WriteLine("What month you want to calculate the income? ");
        string incomeDate = Console.ReadLine();

        string[] monthYear = incomeDate.Split('/'); // split para atribuir a data aos dois parametros

        int month = int.Parse(monthYear[0]);
        int year = int.Parse(monthYear[1]);

        worker.Income(month, year);

        Console.WriteLine("Name: " + worker.Name);
        Console.WriteLine("Department: "+dp.Name);
        Console.WriteLine("Income for: " + monthYear + ": " + worker.Income(month, year));


        

    }

}