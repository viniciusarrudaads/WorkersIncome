using Enumeração.Entities.Enums;
using Enumeração.Entities;

namespace Enumeração.Services;

public class ContractServices
{

    public static void AddContract(HourContract contract)
    {
        Worker worker = new Worker();
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

            contract = new HourContract(date, valuePerHour, hours);

            worker.AddContract(contract);


        }


    }

}
