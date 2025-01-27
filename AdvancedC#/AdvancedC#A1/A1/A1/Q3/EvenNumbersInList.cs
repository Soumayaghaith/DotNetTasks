using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1.Q3
{
    internal class EvenNumbersInList
    {
        public static int[] GetEvenNumbers(int[] numbers)
        {
            int Counter = 0;
            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i]%2 == 0) 
                { Counter++; }
            }
            int[] evenNumbers = new int[Counter];
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                { 
                    evenNumbers[index] = numbers[i];
                    index++;
                }
            }
            return evenNumbers;
            }
    }
}
