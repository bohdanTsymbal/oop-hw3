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
            WorkDay = "8 hours a day, 5 day a week";
            random = new Random();
        }

        public override void FillWorkDay()
        {
            int callsNumber = random.Next(1, 11);
            for (int i = 0; i < callsNumber; i++)
                Call();

            Relax();

            callsNumber = random.Next(1, 6);
            for (int i = 0; i < callsNumber; i++)
                Call();
        }
    }
}
