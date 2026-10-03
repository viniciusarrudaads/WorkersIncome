
using Enumeração.Entities.Enums;

namespace Enumeração.Entities
{
    public class Worker
    {
        public string Name { get; set; } = string.Empty;
        public Level WorkerLevel { get; set; }
        public decimal BaseSalary { get; private set; }
        public List<HourContract> Contract { get; private set;  } = new List<HourContract>();
        public Department Department { get; set; }


        public Worker() { }
        public Worker(string name, Level workerLevel, decimal baseSalary, Department department)
        {
            Name = name;
            WorkerLevel = workerLevel;
            BaseSalary = baseSalary;
            Department = department;
        }


        public void AddContract(HourContract contract){
            Contract.Add(contract);
            
       
        }

        public void RemoveContract(HourContract contract)
        {
            Contract.Remove(contract);
        }

        public decimal Income(int month, int year)
        {
            decimal sum = BaseSalary;

            foreach(HourContract contract in Contract)
            {
                if (contract.Date.Month == month && contract.Date.Year == year)
                {
                    return sum += contract.TotalValue();

                }
            }
            return sum;
        }

        public override string ToString()
        {
            return "Name: " + Name + Income;
        }

 

    }
}
