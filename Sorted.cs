using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreThan3Para
{
    //starting with the generic class, T is different datatypes
    public class GenericMaximum<T> where T : IComparable 
    {
        public T[] value;
        //creating method
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }
        //sorting the array
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);

            return sorted_values[sorted_values.Length - 1];
        }
        //method for maximum value
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        //method for printing maximum value
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
}
