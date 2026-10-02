
using Enumeração.Entities.Enums;

namespace Enumeração.Entities
{
    public class Worker
    {
        public string Name { get; set; } = string.Empty;
        public Level WorkerLevel { get; set; }
        public decimal BaseSalary { get; private set; }


        public Worker(string name, Level workerLevel, decimal baseSalary)
        {
            Name = name;
            WorkerLevel = workerLevel;
            BaseSalary = baseSalary;
        }


        public void AddContract(HourContract contract){
             List<HourContract> list = new List<HourContract>();

            Console.WriteLine("How many contracts you want to register? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("CONTRACT #"+ (i+1));
                Console.WriteLine();

                Console.WriteLine("Date DD/MM/YYYY: ");
                DateOnly date = DateOnly.Parse(Console.ReadLine());

                Console.WriteLine("Value per hour: ");
                decimal valuePerHour = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                contract = new HourContract(date, valuePerHour, hours);
            
            }
            

        
        
        }

        public void RemoveContract(HourContract contract)
        {
        }

        public decimal Income(int month, int year)
        {
            HourContract contract = new HourContract();

            Console.WriteLine("What month you want to calculate the income? ");
            string incomeDate = Console.ReadLine();

            string[] monthYear = incomeDate.Split('/'); // split para atribuir a data aos dois parametros

            month = int.Parse(monthYear[0]);
            year = int.Parse(monthYear[1]);

            return contract.TotalValue() + BaseSalary;


        }

    }
}
