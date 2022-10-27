using MaxRefactorClass;
using System;
namespace UsingMethod
{
    class Program
    {
       //Main method
        public static void Main(string[] args)
        {
            GenericMax<int> a = new GenericMax<int>(25, 35, 45);
            Console.WriteLine("the maximum value is: " + a.MaxValue);
            GenericMax<double> b = new GenericMax<double>(25.23, 35.56, 45.2);
            Console.WriteLine("the maximum value is: " + b.MaxValue);
            GenericMax<string> c = new GenericMax<string>("apple", "Mango", "Banana");
            Console.WriteLine("the maximum value is: " + c.MaxValue);
        }
    }
}
