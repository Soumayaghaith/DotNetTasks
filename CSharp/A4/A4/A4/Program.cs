using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace A4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //- Write a program that takes a number from the user then print yes if
            //that number can be divided by 3 and 4 otherwise print no.
            //Console.Write("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //if ((num % 3 == 0) && (num % 4 == 0))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region Q2
            //- Write a program that allows the user to insert an integer then print
            //negative if it is negative number otherwise print positive.
            //Console.Write("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //if (num < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Positive");
            //}
            #endregion

            #region Q3
            //Write a program that takes 3 integers from the user then prints the max
            //element and the min element.

            //Console.WriteLine("Please enter 3 numbers: ");
            //int.TryParse(Console.ReadLine(), out int num1);
            //int.TryParse(Console.ReadLine(), out int num2);
            //int.TryParse(Console.ReadLine(), out int num3);

            //if (num1 > num2 && num1 > num3)
            //{
            //    Console.WriteLine($"{num1} is the maximum number");
            //    if (num2 > num3)
            //    {
            //        Console.WriteLine($"{num3} is the minimum number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{num2} is the minimum number");
            //    }
            //}
            //else if (num2 > num1 && num2 > num3)
            //{
            //    Console.WriteLine($"{num2} is the maximum number");
            //    if (num1 > num3)
            //    {
            //        Console.WriteLine($"{num3} is the minimum number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{num1} is the minimum number");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{num3} is the maximum number");
            //    if (num1 > num2)
            //    {
            //        Console.WriteLine($"{num2} is the minimum number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{num1} is the minimum number");
            //    }
            //}

            #endregion

            #region Q4
            //Write a program that allows the user to insert an integer number then
            //check If a number is even or odd.
            //Console.Write("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}
            #endregion

            #region Q5
            //- Write a program that takes character from the user then if it is a
            //vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            Console.WriteLine("please enter a character");
            char.TryParse(Console.ReadLine(), out char chara);

            if ((chara >= 'a' && chara <= 'z') || (chara >= 'A' && chara <= 'Z'))
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }
            #endregion
        }
    }
}
