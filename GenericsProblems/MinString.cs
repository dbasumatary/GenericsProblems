using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    internal class MinString
    {
        public void FindMinString() {
            Console.Write("Input first string: ");
            string first = Console.ReadLine();
            Console.Write("\nInput second string: ");
            string second = Console.ReadLine();
            Console.Write("\nInput third string: ");
            string third = Console.ReadLine();

            string min = first;  // Assume 'first' is the minimum initially

            if (string.Compare(second, min) < 0)
            {
                min = second;  // Update 'min' if 'second' is smaller
                Console.WriteLine("\nThe minimum string is '" + min + "'");
            }

            else if (string.Compare(third, min) < 0)
            {
                min = third;  // Update 'min' if 'third' is smaller
                Console.WriteLine("\nThe minimum string is '" + min + "'");
            }
            else
            {
                Console.WriteLine("\nThe minimum string is '" + min + "'");
            }
        }
    }
}
