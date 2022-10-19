using System;
using System.Collections.Generic;
using System.Text;

namespace objectOriented
{
    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Part Time");
        }
    }
}
