using MaxString;
using System;
namespace StringUC3
{
    class program
    {
        public static void Main(string[] args)
        {
            string output = StringMaxCheck.MaxString("55", "88", "99");
            Console.WriteLine("The maximum string value is: "+output);
        }
    }
}
