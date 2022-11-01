using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public interface IFinanceOperation
    {
        public double CalculateLoanPercent(int month , double totalAmount);
        public bool CheckUserHistory();

    }
}
