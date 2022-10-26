using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Currency
    {
        public string Name { get; }
        public decimal RateToUAH { get; }

        public Currency(string name, decimal rateToUAH)
        {
            Name = name;
            RateToUAH = rateToUAH;
        }
    }
}
