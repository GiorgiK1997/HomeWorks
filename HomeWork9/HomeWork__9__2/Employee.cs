using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__9__2
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public EnumPosition Position;
        public int[] WorkedHours;

        public int GetAverageSalary()
        {
            int time = WorkedHours.Sum();
            int result = 0;
            int hourlyRateNormal = 0;
            if (this.Position == EnumPosition.Tester)
            {
                hourlyRateNormal = 20;
            }
            else if (this.Position == EnumPosition.Manager)
            {
                hourlyRateNormal = 40;
            }
            else if (this.Position == EnumPosition.Developer)
            {
                hourlyRateNormal = 30;
            }
            else
            {
                hourlyRateNormal = 10;
            }
            int hourlyRateOvertime = hourlyRateNormal + 5;
            int hourlyRateWeekend = hourlyRateNormal * 2;
            for (int i = 0; i < this.WorkedHours.Length; i++)
            {
                if (i <= WorkedHours.Length - 3)
                {

                    if (WorkedHours[i] <= 8)
                    {
                        result = result + (WorkedHours[i] * hourlyRateNormal);
                    }
                    if (WorkedHours[i] > 8)
                    {
                        result = result + (WorkedHours[i] - 8) * hourlyRateOvertime + 8 * hourlyRateNormal;
                    }
                }
                else
                {
                    result = result + (WorkedHours[i] * hourlyRateWeekend);
                }
            }
            
            if(time > 50)
            {
                result = result + (result) / 5; 
            }
            return result;
           
        }
    }
}
