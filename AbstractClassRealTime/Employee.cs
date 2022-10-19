using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassRealTime
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetFullName()
        {
            return this.FirstName + " " + LastName;
        }
        public abstract int GetMonthlySalary();
       
    }
}
