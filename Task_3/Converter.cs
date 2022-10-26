using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Converter
    {
        public static decimal Convert(Currency currencyFrom, Currency currencyTo, decimal amount)
        {
            decimal amountInUAH = amount * currencyFrom.RateToUAH;
            decimal searchedAmount = amountInUAH / currencyTo.RateToUAH;

            return searchedAmount;
        }
    }
}
