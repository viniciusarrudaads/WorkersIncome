
using Enumeração.Entities.Enums;

namespace Enumeração.Entities
{
    public class Worker
    {
        public string Name { get; set; } = string.Empty;
        public Level WorkerLevel { get; set; }
        public decimal baseSalary { get; private set; }


    }
}
