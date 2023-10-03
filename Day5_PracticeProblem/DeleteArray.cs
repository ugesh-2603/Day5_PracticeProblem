using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblem
{
    class DeleteArray
    {
        public static object[] DeleteMethod(object[] inputArray, object elementToDelete)
        {
            int newSize = 0;
            object[] newArray = new object[inputArray.Length];

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
