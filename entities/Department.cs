using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerContracts.entities
{
    public class Department
    {
        public string Name { get; set; }

        public Department(string DepName)
        {
            this.Name = DepName;
        }
    }
}
