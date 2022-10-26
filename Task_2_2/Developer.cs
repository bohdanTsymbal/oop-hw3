using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    internal class Developer : Worker
    {
        public override string Position { get; protected set; }
        public override string WorkDay { get; protected set; }

        public Developer(string name) : base(name)
        {
            Position = "Розробник";
            WorkDay = "";
        }

        public override void FillWorkDay()
        {
            List<string> workDayList = new() { WriteCode(), Call(), Relax(), WriteCode() };
            WorkDay = string.Join(", ", workDayList.ToArray());
        }
    }
}
