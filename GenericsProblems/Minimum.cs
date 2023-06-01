using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    internal class Minimum<T> where T : IComparable<T>
    {
        T num1, num2, num3;

        //Constructor parameter
        public Minimum(T num1, T num2, T num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }

        public void TestMinimum<T>() where T : IComparable<T>
        {

            if (num1.CompareTo(num2) < 0 && num1.CompareTo(num3) < 0)
            {
                Console.WriteLine("\nThe minimum is " + num1);
            }

            else if (num2.CompareTo(num1) < 0 && num2.CompareTo(num3) < 0)
            {
                Console.WriteLine("\nThe minimum is " + num2);
            }
            else
            {
                Console.WriteLine("\nThe minimum is " + num3);
            }
        }
    }
}
