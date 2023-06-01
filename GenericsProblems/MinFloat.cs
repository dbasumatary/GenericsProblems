using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    internal class MinFloat
    {
        public void FindMinFloat() {
            Console.Write("Input first float number: ");
            float first = float.Parse(Console.ReadLine());
            Console.Write("\nInput second float number: ");
            float second = float.Parse(Console.ReadLine());
            Console.Write("\nInput third float number: ");
            float third = float.Parse(Console.ReadLine());

            Console.WriteLine("\nThe minimum of the three numbers is : " + Math.Min(first, Math.Min(second, third)));
        }
    }
}
