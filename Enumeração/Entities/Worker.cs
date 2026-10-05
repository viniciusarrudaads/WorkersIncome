
using Enumeração.Entities.Enums;

namespace Enumeração.Entities
{
    public class Worker
    {
        public string Name { get; set; } = string.Empty;
        public Level WorkerLevel { get; set; }
        public decimal BaseSalary { get; private set; }
        public List<HourContract> Contract { get; private set;  } = new List<HourContract>(); // estamos associando o contrato ao worker
        public Department Department { get; set; } // e a classe department também


        public Worker() { }
        public Worker(string name, Level workerLevel, decimal baseSalary, Department department)
        {
            Name = name;
            WorkerLevel = workerLevel;
            BaseSalary = baseSalary;
            Department = department;
        }


        public void AddContract(HourContract contract){
            Contract.Add(contract); // utilizando o método das listas '' add '' para adicionar o contrato
            
       
        }

        public void RemoveContract(HourContract contract)
        {
            Contract.Remove(contract);
        }

        public decimal Income(int month, int year)
        {
            decimal sum = BaseSalary;

            foreach(HourContract contract in Contract) // aqui estamos usando um foreach para poder percorrer o contrato e verificar se a condição de month e year estão corretas.
            {
                if (contract.Date.Month == month && contract.Date.Year == year)
                {
                    return sum += contract.TotalValue();

                }
            }
            return sum;
        }

    }
}
