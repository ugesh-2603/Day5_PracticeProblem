using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblem
{
    internal class Deleteusing_generics
    {
        public static T[] DeleteMethod<T>(T[] inputArray, T elementToDelete)
        {
            int newSize = 0;
            T[] newArray = new T[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (!inputArray[i].Equals(elementToDelete))
                {
                    newArray[newSize] = inputArray[i];
                    newSize++;
                }
            }

            Array.Resize(ref newArray, newSize);
            return newArray;
        }
    }
}
