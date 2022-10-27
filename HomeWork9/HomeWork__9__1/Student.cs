using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__9__1
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public int SubmissionYear;

        public Subject GetSubject()
        {
            return Subject.Math;
        }
        public int FinishYear()
        {
            int result = this.SubmissionYear + 4 - DateTime.Now.Year;
            return result;
        }
    }
}
