using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    internal class Team
    {
        public string Name { get; }
        public List<Worker> Employees { get; }

        public Team(string name)
        {
            Name = name;
            Employees = new List<Worker> { };
        }
    }
}
