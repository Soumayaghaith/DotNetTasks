﻿using System.Buffers.Text;
using System.ComponentModel;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace A5
{
    internal class Program
    {
        class TrialClass
        {
            public int X;
        }
        static void Main(string[] args)
        {
            #region Q1
            //- Explain the difference between passing (Value type parameters) by value and
            //by reference then write a suitable c# example.

            //Passing by value changes in the copy of the variable(stored in stack) not the variable itself
            //Passing by ref changes in the original variable 
            //int valType = 10, refType = 10;
            //Console.WriteLine("Before Function call");
            //Console.WriteLine($"The value type argu is {valType}");
            //Console.WriteLine($"The ref type argu is {refType}");
            //Console.WriteLine( "-------------------------------");
            //ModifyValue(valType);
            //ModifyRef(ref refType);

            //Console.WriteLine("After Function call");
            //Console.WriteLine($"The value type argu is {valType}");
            //Console.WriteLine($"The ref type argu is {refType}");

            #endregion

            #region Q2
            //Explain the difference between passing (Reference type parameters)
            //by value and by reference then write a suitable c# example.
            //Passing ref type by value --> you can modify the original data but you can't
            //modify the refernce to point to sth else
            //Passing ref type by ref   --> you can modify the orignial data and the ref

            //TrialClass obj1 = new TrialClass { X = 10 };
            //TrialClass obj2 = new TrialClass { X = 20 };

            //Console.WriteLine("Before Function call");
            //Console.WriteLine($"The value type argu is {obj1.X}");
            //Console.WriteLine($"The ref type argu is {obj2.X}");
            //Console.WriteLine("-------------------------------");
            //ModifyValue2(obj1);
            //ModifyRef2(ref obj2);

            //Console.WriteLine("After Function call");
            //Console.WriteLine($"The value type argu is {obj1.X}");
            //Console.WriteLine($"The ref type argu is {obj2.X}");


            #endregion

            #region Q3
            //3- Write a c# Function that accept 4 parameters from user and
            //return result of summation and subtracting of two numbers
            //I don't know which two numbers he means so I will assume that the func should return
            //the summation of the first two numbers and subtruct the others
            //int n1 = 3, n2 = 4, n3 = 100, n4 = 50;
            //(int sum, int sub) = SumSub(n1,n2,n3,n4);

            //Console.WriteLine($"{n1}+{n2}={sum}");
            //Console.WriteLine($"{n3}-{n4}={sub}");
            #endregion

            #region Q4
            //Write a program in C# Sharp to create a function to calculate the sum of
            //the individual digits of a given number.
            //Console.WriteLine("Please enter a number to calculate its digits");
            //int.TryParse(Console.ReadLine(), out int num);

            //int digSum= SumDigits(num);

            //Console.WriteLine($"The sum of digits in {num} is {digSum}");

            #endregion

            #region Q5
            //Console.Write("Please enter a number: ");
            //int.TryParse(Console.ReadLine(),out int num);
            //bool res = IsPrime(num);
            //Console.WriteLine(res);
            #endregion

            #region Q6
            //int[] arr = { 1, 2, 3 };
            //(int max, int min)=MinMaxArray(ref arr);
            //Console.WriteLine($"The max is {max}, The min is {min}");
            #endregion

            #region Q7
            //Create an iterative (non-recursive) function to calculate the factorial
            //of the number specified as parameter
            //Console.WriteLine("Please enter a number to specify its factorial");
            //int.TryParse(Console.ReadLine(), out int num);
            //int fact = GetFact(num);
            //Console.WriteLine(fact);

            #endregion

            #region Q8
            //Create a function named "ChangeChar" to modify a letter in a certain
            //position(0 based) of a string, replacing it with a different letter
            //Console.WriteLine("Please enter a string");
            //string text = Console.ReadLine();
            //Console.WriteLine("Please enter the index of the letter you want to replace with C letter");
            //int.TryParse(Console.ReadLine(), out int Index);
            //ChangeChar(ref text,Index);
            //Console.WriteLine(text);

            #endregion
        }

        static void ModifyValue(int X)
        {
            X += 5;
        }

        static void ModifyRef( ref int X)
        {
            X += 5;
        }

        static void ModifyValue2(TrialClass obj)
        {
            obj.X += 5; //modifies the data 
            obj = new TrialClass { X=100 }; //not visible otside the func scope
        }

        static void ModifyRef2(ref TrialClass obj)
        {
            obj.X += 5; //modifies the data 
            obj = new TrialClass { X = 100 }; //visible otside the func scope
        }

        static (int, int) SumSub(int n1, int n2 ,int n3 ,int n4)
        {
            int sum = n1 + n2;
            int sub = n3 - n4;
            return (sum, sub);
        }

        static int SumDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        static bool IsPrime(int num) 
        {
            bool flag = true;
            for (int i =2; i<num/2; i++)
            {
                if (num%i==0 ) 
                { 
                    flag = false;
                }
            }

            return flag;
        }

        static (int, int) MinMaxArray(ref int[]arr)
        {
            int max = int.MinValue, min = int.MaxValue;
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] > max)
                { 
                    max = arr[i];
                }
                if (arr[i] < min)
                { 
                    min = arr[i];
                }
            }

            return (max, min);

        }

        static int GetFact(int num)
        {
            int fact = 1;
            while (num > 0)
            {
                fact *= num;
                num -= 1;
            }

            return fact;
        
        }

        static void ChangeChar(ref string text, int index)
        {
            //since strings are immutable, meaning their content cannot be changed directly.
            // C# does not allow modifying individual characters in a string directly.
            char[] chars = text.ToCharArray();
            chars[index] = 'C';
            text = new string(chars);
         
        }
    }
}
