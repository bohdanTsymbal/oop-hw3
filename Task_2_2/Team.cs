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

        public void AddEmployee(Worker newEmployee)
        {
            Employees.Add(newEmployee);
        }

        private void PrintInfo(Func<Worker, string> formatEmployeeData)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Команда '{Name}', співробітники:");

            int index = 0;
            foreach (var employee in Employees)
            {
                employee.FillWorkDay();
                Console.WriteLine($"{++index}. {formatEmployeeData(employee)}");
            }
        }

        public void PrintBriefInfo()
        {
            PrintInfo(employee => $"{employee.Name}");
        }

        public void PrintDetailedInfo()
        {
            PrintInfo(employee => $"{employee.Name} - {employee.Position} - {employee.WorkDay}");
        }
    }
}
