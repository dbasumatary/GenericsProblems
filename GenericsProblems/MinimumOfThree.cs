using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    internal class MinimumOfThree
    {
        
        public T FindMinimumOfThree<T>(T x, T y, T z) where T: IComparable<T>
        {
            //T firstNum, secondNum, thirdNum;
            T min = x;  // Assume 'x' is the minimum initially

            if (y.CompareTo(min) < 0)
            {
                min = y;  // Update 'min' if 'y' is smaller
                Console.WriteLine("\nThe minimum is " + min);
            }

            else if (z.CompareTo(min) < 0)
            {
                min = z;  // Update 'min' if 'z' is smaller
                Console.WriteLine("\nThe minimum is " + min);
            }
            else
            {
                Console.WriteLine("\nThe minimum is " + min);
            }
            return min;


        }
    }
}
