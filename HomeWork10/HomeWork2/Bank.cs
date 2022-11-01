using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Bank :IFinanceOperation
    {
        public bool CheckUserHistory()
        {
          return true;
        }
        public double  CalculateLoanPercent(int month , double totalAmount)
        {
            double result = 0;
            int  procent = 5;
            result = totalAmount + (totalAmount / 100) * procent;
            return result;
           
        }

       
    }

}
