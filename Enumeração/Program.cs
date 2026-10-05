using Enumeração.Entities.Enums;
using Enumeração.Entities;
using Enumeração.Services;
namespace Enumeração;

class Program
{
    static void Main(string[] args)
    {
        Worker worker = WorkerServices.AddWorker();
        HourContract contract = ContractServices.AddContract();
        Department dp = new Department();
        IncomeServices.CalculateIncome(worker);

        Console.WriteLine("Name: " + worker.Name);
        Console.WriteLine("Department: "+worker.Department.Name);
        


        

    }

}