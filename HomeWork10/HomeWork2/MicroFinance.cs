using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class MicroFinance : IFinanceOperation
    {
        public bool CheckUserHistory()
        {
            return true;
        }
        public double CalculateLoanPercent(int month, double totalAmount)
        {
             int procent = 10;
             var result = totalAmount +( totalAmount / 100 * procent) + (month * 4);
             return result;

        }
    }
}
