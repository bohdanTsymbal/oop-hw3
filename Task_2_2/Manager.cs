using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    internal class Manager : Worker
    {
        public override string Position { get; protected set; }
        public override string WorkDay { get; protected set; }
        
        private readonly Random random;

        public Manager(string name) : base(name)
        {
            Position = "Менеджер";
            WorkDay = "";
            random = new Random();
        }

        public override void FillWorkDay()
        {
            List<string> workDayList = new() { };

            int callsNumber = random.Next(1, 11);
            for (int i = 0; i < callsNumber; i++)
                workDayList.Add(Call());

            workDayList.Add(Relax());

            callsNumber = random.Next(1, 6);
            for (int i = 0; i < callsNumber; i++)
                workDayList.Add(Call());

            WorkDay = string.Join(", ", workDayList.ToArray());
        }
    }
}
