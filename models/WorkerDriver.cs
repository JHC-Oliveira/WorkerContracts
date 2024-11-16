

using System.Net.WebSockets;
using WorkerContracts.entities;
using WorkerContracts.entities.enums;

namespace WorkerContracts.models
{
    public class WorkerDriver
    {
        public void Run()
        {
            Console.Write("Enter department's name: ");
            string depName = Console.ReadLine()!;
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string workerName = Console.ReadLine()!;

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()!);

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine()!);

            Worker worker = new Worker(workerName, baseSalary, level, new Department(depName));

            Console.Write("\nHow many contracts to this worker: ");
            int numberOfContraccts = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < numberOfContraccts; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i+1} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = new DateTime();
                date = DateTime.Parse(Console.ReadLine()!);
                Console.Write("Valuer per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine()!);
                Console.Write("Duration: ");
                int duration = int.Parse(Console.ReadLine()!);

                //Contract contract = new Contract(date, valuePerHour, duration);
                //worker.AddContract(contract);
                worker.AddContract(new Contract(date, valuePerHour, duration));

            }
        
            Console.Write("\nEnter month and year to calculate income: (MM/YYYY): ");
            string monthAndYear = Console.ReadLine()!;
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine(worker.DisplayIncome(month, year));

        }

        
    }


}
