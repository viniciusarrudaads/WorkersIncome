using Enumeração.Entities.Enums;
using Enumeração.Entities;

namespace Enumeração.Services
{
    public class IncomeServices
    {
        public static decimal AddIncome(Worker worker)
        {
            Console.WriteLine("What month you want to calculate the income? ");
            string incomeDate = Console.ReadLine();

            string[] monthYear = incomeDate.Split('/'); // split para atribuir a data aos dois parametros

            int month = int.Parse(monthYear[0]);
            int year = int.Parse(monthYear[1]);

            return worker.Income(month, year);


        }   

    }
}
