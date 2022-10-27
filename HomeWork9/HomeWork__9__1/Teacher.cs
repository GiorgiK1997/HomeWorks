using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__9__1
{
    public class Teacher
    {
        public string FirstName;
        public bool IsCertifaed;
        
      public  string  ChekStudent(Subject studentSubject)
        {
            string result = "";
            if(studentSubject == Subject.Math)
            {
                Random rand = new Random();
                result = (rand.Next() + rand.Next()).ToString();
            }
           else if(studentSubject == Subject.English)
            {
                result = "CocaCola";
            }
           else if(studentSubject == Subject.Chemistry)
            {
                result = " H20";
            }
            else
            {
                result = "Not Competent ";
            }
            return result;

        }
    }
}
