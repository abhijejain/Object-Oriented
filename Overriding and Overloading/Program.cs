using System;

namespace Overriding_and_Overloading
{
   public  class Program
    {
        static void Main(string[] args)
        {

            //Method overrriding  will invoke child class method
            Parent p = new Child();
            p.Print();

            Parent p1 = new Parent();
            p1.Print();

            Child c = new Child();
            c.Print();

            ///  Child c1 = new Parent(); // not possible  only with typecasting 
            ///  
            //child c = (child)p; // p originally holds a reference to child

            //parent p = new parent();
            //child c = (child)p; // p is a parent object hence this is illegal

        }
    }

    public class Parent
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Parent class print method");
        }
    }
    public class Child : Parent
    {
        // method overrding 
        public override void Print()
        {
            Console.WriteLine("I am a child class print method");
        }

        // method hiding 
        //public new void Print()
        //{
        //    Console.WriteLine("I am a child class print method");
        //}
    }
}
