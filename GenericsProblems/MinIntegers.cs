using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    internal class MinIntegers
    {
        public void FindMinInteger()
        {
            Console.Write("Input first integer: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInput second integer: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInput third integer: ");
            int third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe minimum of the three integers is : " + Math.Min(first, Math.Min(second, third)));
        }
    }
}
