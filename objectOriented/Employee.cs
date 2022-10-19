using System;
using System.Collections.Generic;
using System.Text;

namespace objectOriented
{
    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

    }
}
