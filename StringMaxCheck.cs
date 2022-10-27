using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxString
{
    internal class StringMaxCheck
    {
        public static string MaxString(string  firstValue, string secondValue, string thirdValue)
        {
            //checking which value  is greater
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
    }
}
