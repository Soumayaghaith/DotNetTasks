using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1.Q2
{
    internal class ReverseArrayHelper
    {
        public static void ReverseArrayList(int[] array)
        {
            if (array == null)
            {
                return;
            }

            int start = 0; 
            int end = array.Length-1;

            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                start++;
                end--;
            }
        }
    }
}
