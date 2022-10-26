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

        public static string Call()
        {
            return "made a call";
        }

        public static string WriteCode()
        {
            return "wrote some code";
        }

        public static string Relax()
        {
            return "relaxed a bit";
        }

        public abstract void FillWorkDay();
    }
}
