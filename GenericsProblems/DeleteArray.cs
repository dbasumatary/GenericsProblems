using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    internal class DeleteArray
    {
        public void DeleteInt(int[] intArray,int index)
        {
            //Shifting the values after index to delete to next index
            for(int i = index; i < intArray.Length - 1; i++)
            {
                intArray[i] = intArray[i + 1];
            }
            Console.Write("\nThe final integer array after deletion is : ");
            for(int i = 0; i < intArray.Length - 1; i++)
            {
                Console.Write(intArray[i] + " ");
            }
        }

        public void DeleteDouble(double[] doubleArray,int index)
        {
            //Shifting the values after index to delete to next index
            for (int i = index; i < doubleArray.Length - 1; i++)
            {
                doubleArray[i] = doubleArray[i + 1];
            }
            Console.Write("\nThe final double array after deletion is : ");
            for (int i = 0; i < doubleArray.Length - 1; i++)
            {
                Console.Write(doubleArray[i] + " ");
            }
        }

        public void DeleteChar(char[] charArray,int index) 
        {
            //Shifting the values after index to delete to next index
            for (int i = index; i < charArray.Length - 1; i++)
            {
                charArray[i] = charArray[i + 1];
            }
            Console.Write("\nThe final char array after deletion is : ");
            for (int i = 0; i < charArray.Length - 1; i++)
            {
                Console.Write(charArray[i] + " ");
            }
        }
    }
}
