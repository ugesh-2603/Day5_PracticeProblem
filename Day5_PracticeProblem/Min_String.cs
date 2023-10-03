using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblem
{
    internal class Min_String
    {
        public string FindMin(string str1, string str2, string str3)
        {
            if (str1.CompareTo(str2) <= 0)
            {
                if (str1.CompareTo(str3) <= 0)
                {
                    return str1;
                }
                else
                {
                    return str3;
                }
            }
            else
            {
                if (str2.CompareTo(str3) <= 0)
                {
                    return str2;
                }
                else
                {
                    return str3;
                }
            }
        }
    }
}
