using System;

namespace GenericDelegates
{
    class GenericDelegates
    {

      
        public static double AddNums1(int x, float y,double z)
        {
            return x + y + z;
        }
        public static void  AddNums2(int x, float y,double z)
        {
            Console.WriteLine( x + y + z);
        }
        public static bool CheckLength(string str)
        {
            if(str.Length > 5)
            {
                return true;
            }
            return false;
        }
        static void Main()
        {
            //Delegate1 obj1 = new Delegate1(AddNums1);
            Func<int,float,double,double> obj1 = AddNums1;

            double result = obj1.Invoke(100,34.5f,195.465);
            Console.WriteLine(result); 
            
            Action<int,float,double> obj2 = AddNums2;
            obj2.Invoke(100,34.5f,195.465);

            Predicate<string> obj3 = CheckLength;
            bool status = obj3.Invoke("Hello");
            Console.WriteLine(status);

            // with lambda expressions

            Func<int, float, double, double> obj = (x, y, z) =>
            {
                return x + y + z;
            };
            double result1 = obj.Invoke(100, 34.5f, 195.465);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
