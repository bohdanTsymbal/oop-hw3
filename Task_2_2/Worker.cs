using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    internal abstract class Worker
    {
        public string Name { get; }
        public abstract string Position { get; protected set; }
        public abstract string WorkDay { get; protected set; }

        public Worker(string name) => Name = name;

        public static void Call()
        {
            Console.WriteLine("Make a call");
        }

        public static void WriteCode()
        {
            Console.WriteLine("Write some code");
        }

        public static void Relax()
        {
            Console.WriteLine("Just relax a bit");
        }

        public abstract void FillWorkDay();
    }
}
