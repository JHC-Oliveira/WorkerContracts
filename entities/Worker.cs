using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerContracts.entities.enums;

namespace WorkerContracts.entities
{
    public class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        public Department DepName { get; set; }


        public Worker(string name, double baseSalary, WorkerLevel level, Department depName)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            DepName = depName;
        }

        List<Contract> contracts = new List<Contract>();

        public void AddContract(Contract contract) { contracts.Add(contract); }
        public void RemoveContract(Contract contract) { contracts.Remove(contract); }   



        public double GetMonthAndYearIncome(int month, int year)
        {
            double sum = BaseSalary;

            foreach (Contract contract in contracts)
            {
                if((contract.Date.Year == year) && (contract.Date.Month == month))
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }

        public string DisplayIncome(int month, int year)
        {
            return $"Name: {Name}\n" +
                $"Department: {DepName.Name}\n" +
                $"Income for {month}/{year}: {GetMonthAndYearIncome(month, year)}";
        }
    }
}
