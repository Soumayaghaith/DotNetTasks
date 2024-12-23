using System;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            //Console.WriteLine("please enter a character");
            //char.TryParse(Console.ReadLine(), out char chara);

            //if ((chara >= 'a' && chara <= 'z') || (chara >= 'A' && chara <= 'Z'))
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}
            #endregion

            #region Q6
            // Write a program that allows the user to insert an integer then print
            //all numbers between 1 to that number.

            //Console.WriteLine("Please enter a number");
            //int.TryParse(Console.ReadLine(), out int num);

            //for (int i=1; i<=num; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q7
            //Write a program that allows the user to insert an integer then
            //print a multiplication table up to 12.

            //Console.WriteLine("Please enter a number");
            //int.TryParse(Console.ReadLine(), out int num);

            //for (int i=1; i<=12; i++)
            //{
            //    Console.WriteLine($"{num}*{i}={num*i}");
            //}

            #endregion

            #region Q8
            //Write a program that allows to user to insert number then print all
            //even numbers between 1 to this number
            //Console.WriteLine("Please enter a number");
            //int.TryParse(Console.ReadLine(), out int num);

            //Console.WriteLine($"The even numbers between 1 and {num} are");
            //for (int i = 1; i <= num; i++)
            //{
            //    if (i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}


            #endregion

            #region Q9
            //Write a program that takes two integers then prints the power.
            //Console.WriteLine("Please enter the base number");
            //int.TryParse(Console.ReadLine(), out int num);

            //Console.WriteLine("Please enter its power");
            //int.TryParse(Console.ReadLine(), out int pow);

            //int result =1;
            //for (int i = 1; i <= pow; i++)
            //{
            //    result *= num;
            //}
            //Console.WriteLine($"{num}^{pow}= {result}");
            #endregion

            #region Q10
            //Write a program to enter marks of five subjects and calculate total,
            //average and percentage.

            //Console.Write("Please enter the marks of 5 subjects: ");
            //float.TryParse(Console.ReadLine(), out float mark1);
            //float.TryParse(Console.ReadLine(), out float mark2);
            //float.TryParse(Console.ReadLine(), out float mark3);
            //float.TryParse(Console.ReadLine(), out float mark4);
            //float.TryParse(Console.ReadLine(), out float mark5);

            //float sum = mark1 + mark2 + mark3 + mark4 + mark5;
            //Console.WriteLine($"Total:{sum}");
            //Console.WriteLine($"Average:{sum/5}");
            //Console.WriteLine($"Percentage:{(sum/500)*100}");




            #endregion

            #region Q11
            //Write a program to input the month number and print the number of days
            //in that month.
            //Console.Write("Please enter a month number: ");
            //int.TryParse(Console.ReadLine(), out int num);

            //switch (num)
            //{
            //    default:
            //        Console.WriteLine("This is not a valid month number");
            //        break;
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("30 days");
            //        break;


            //    case 2:
            //        Console.WriteLine("28 or 29 days");
            //        break;
            //}
            #endregion

            #region Q12
            //Write a program to create a Simple Calculator
            //Console.WriteLine("Please enter two operands");
            //int.TryParse(Console.ReadLine(), out int num1);
            //int.TryParse(Console.ReadLine(), out int num2);
            //Console.WriteLine("Please enter the opertor between them + - * /");
            //char.TryParse(Console.ReadLine(), out char op);


            //switch (op)
            //{
            //    default:
            //        Console.WriteLine("This is not a valid operator");
            //        break;
            //    case '+':
            //        Console.WriteLine($"{num1}+ {num2} = {num1+ num2}");
            //        break;
            //    case '-':
            //        if (num1 > num2)
            //        {
            //            Console.WriteLine($"{num1}- {num2} = {num1 - num2}");
            //        }
            //        else 
            //        {
            //            Console.WriteLine($"{num2} - {num1} = {num2 - num1}");
            //        }
            //        break;
            //    case '*':
            //        Console.WriteLine($"{num1}* {num2} = {num1 * num2}");
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //        {
            //            Console.WriteLine($"{num1}/ {num2} = {num1 / num2}");
            //        }
            //        break;
            //}
            #endregion

            #region Q13
            //Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.WriteLine("Please enter a string to reverse it");
            //string text = Console.ReadLine();
            //Console.WriteLine(text.Reverse().ToArray());
            //text.Reverse(): This reverses the characters in the string and returns an IEnumerable<char>.
            //ToArray(): Converts the reversed IEnumerable<char> into a character array.
            #endregion

            #region Q14
            //Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.WriteLine("Please enter an integer to reverse it");
            //int.TryParse(Console.ReadLine(),out int num);
            //int reversedInt=0;
            //while (num> 0)
            //{
            //    reversedInt= reversedInt*10 + num%10;
            //    num /= 10;
            //}
            //Console.WriteLine(reversedInt);
            #endregion

            #region Q15
            //- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Please enter the starting number: ");
            //int.TryParse(Console.ReadLine(), out int num1);

            //Console.Write("Please enter the ending number: ");
            //int.TryParse(Console.ReadLine(), out int num2);

            //int flag ;
            //Console.WriteLine($"Prime numbers between {num1} and {num2} are :");
            //for (int i= num1; i<=num2; i++)
            //{
            //    flag = 1;
            //    for (int j=2;j<i/2; j++ )
            //    {
            //        if (i%j==0 && i!=j)
            //        {
            //            flag = 0;
            //            break;
            //        }

            //    }
            //    if (flag == 1 && i!= 1)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            #endregion

            #region Q16
            //Write a program in C# Sharp to convert a decimal number into binary
            //Console.Write("Enter a number to convert: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //int binNum = 0b0;
            //int bitPos = 0;
            //while (num > 0)
            //{
            //    if (num % 2 == 1)
            //    {
            //        binNum |= (1<<bitPos);
            //    }

            //    bitPos++;
            //    num /= 2;
            //}
            //Console.WriteLine(Convert.ToString(binNum,2));
            #endregion

            #region Q17
            //17- Create a program that asks the user to input three points (x1, y1),
            //(x2, y2), and(x3, y3), and determines whether these points lie on a single straight line
            Console.WriteLine("Please enter the X1 and Y1");
            int.TryParse(Console.ReadLine(),out int X1);
            int.TryParse(Console.ReadLine(), out int Y1);
            

            Console.WriteLine("Please enter the X2 and Y2");
            int.TryParse(Console.ReadLine(), out int X2);
            int.TryParse(Console.ReadLine(), out int Y2);
            

            Console.WriteLine("Please enter the X3 and Y3");
            int.TryParse(Console.ReadLine(), out int X3);
            int.TryParse(Console.ReadLine(), out int Y3);

            //This (((X1 == X2) && (X2 == X3)) || ((Y1 == Y2) && (Y2 == Y3)))
            //works out as long as we are dealing with vertical or horizontal lines
            //so to be more generic it is better to use the slope equation
            if ( ((Y2-Y1)*(X3-X1)) == ((Y3-Y1)*(X2-X1))    )
            {
                Console.WriteLine("these points lie on a single straight line");
            }
            else
            {
                Console.WriteLine("these points don't lie on a single straight line");
            }    
            
            #endregion
        }
    }
}

