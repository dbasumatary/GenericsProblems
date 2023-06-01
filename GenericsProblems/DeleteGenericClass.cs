using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    internal class DeleteGenericClass<T>
    {
        public void DeleteMethod<T>(T[] array, int index)
        {
            //Shifting the values after index to delete to next index
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Console.Write("\nThe final array after deletion using generics is : ");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
