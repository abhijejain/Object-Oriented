using System;

namespace Test1
{
    public class Program
    { 
        static void Main(string[] args)
        {
            int someInt;
            //method1(ref someInt);
            Console.WriteLine(someInt);
            method2(out someInt);
            Console.WriteLine(someInt);
            method3(someInt);
            Console.WriteLine(someInt);
            Console.ReadLine();
        }

        private static void method3(int value)
        {
            value = 0;
        }

        private static void method2(out int value)
        {
            value = 1;
        }

        private static void method1(ref int value)
        {
            value = 2;   
        }
    }
}
