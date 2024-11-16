using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerContracts.entities
{
    public class Contract
    {
        public DateTime Date {  get; set; }
        public double ValuePerHour {  get; set; }
        public int Duration { get; set; }

        public Contract(DateTime date, double valuePerHour, int duration)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Duration = duration;
        }

        public double TotalValue()
        {
            return ValuePerHour * Duration;
        }
    }
}
