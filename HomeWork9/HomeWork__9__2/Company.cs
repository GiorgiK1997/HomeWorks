using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__9__2
{
    public class Company
    {
       public bool IsDomestic;
    
        public int  GetTaxRate()
        {
            int result = 0;
            if (this.IsDomestic)
            {

                result = 18;
            }
            else
            {

                result = 5;
            }
            return result;

        }
        public int GetTaxRateAmount(int profit)
        {
            int pct = this.GetTaxRate();
            int result = profit /100 * pct;
            return result;
        }
    }
}
