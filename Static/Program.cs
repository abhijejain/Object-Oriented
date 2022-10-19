using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee = new Department();
        }
    }

    abstract class Salary
    {

    }
    class Department:IEmployee 
    {
        public Department()
        {

        }

        static Department()
        {

        }
        static void show()
        {

        }

        public void showDetails()
        {
            throw new NotImplementedException();
        }
    }    
    static class Employee                                                                                                                                                                      
    {
        public static int Name { get; set; }

        static Employee()
        {
                
        }

       
    }

    public interface IEmployee
    {
        void showDetails();
    }
}
