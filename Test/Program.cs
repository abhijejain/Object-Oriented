using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = (from m in list
                          where m % 3 == 0
                          select m).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
