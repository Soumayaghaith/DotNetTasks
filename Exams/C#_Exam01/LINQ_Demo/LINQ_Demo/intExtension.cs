using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo
{
    internal static class intExtension
    {
        //By using the keyword this, we tell the compiler that the parameter will be the caller
        //making the function an extension method
        //An extension method must be inside a static and non-generic class 
        public static int Reverse(this int number)
        {
            int reversedNum = 0, remainder;
            while (number > 0)
            {
                remainder = number % 10;
                reversedNum = reversedNum * 10 + remainder;
                number /= 10;
            }
            return reversedNum ;
        }

        public static long Reverse(this long number)
        {
            long reversedNum = 0, remainder;
            while (number > 0)
            {
                remainder = number % 10;
                reversedNum = reversedNum * 10 + remainder;
                number /= 10;
            }
            return reversedNum;
        }


    }

}
