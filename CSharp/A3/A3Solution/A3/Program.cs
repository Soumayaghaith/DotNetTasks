﻿using static System.Collections.Specialized.BitVector32;
using System.Drawing;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Write a program that allows the user to enter a number then print it
            //Console.WriteLine("Please enter a number to print it");
            //int num;
            //num =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num);
            #endregion

            #region Q2 - Write C# program that converts a string to an integer, but the string contains non - numericcharacters.

            //string stringTrial = "This is a Non numeric string";

            //Using the convert class will throw an exception
            //int num =Convert.ToInt32(stringTrial);
            //Console.WriteLine(num);

            //Using the parse method will throw an exception
            //int num = int.Parse(stringTrial);
            //Console.WriteLine(num);

            //Using the TryParse method will print the defualt value
            //int num;
            //int.TryParse(stringTrial,out num);
            //Console.WriteLine(num);
            #endregion

            #region Q3 Write C# program that Perform a simple arithmetic operation with floating - point numbers
            //double num1=2.5, num2 = 10.5;
            //Console.WriteLine(num1+num2);
            //I actually don't know what is the point of this question =)
            #endregion

            #region Q4 Write C# program that Extract a substring from a given string.
            //This is a nice one
            //Console.WriteLine("Please enter the original string");
            //string OriginalString = Console.ReadLine();

            //Console.WriteLine("Please enter the start index of the substring");
            //int StartIndex = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter the length of the substring");
            //int Length = int.Parse(Console.ReadLine());

            //string SubString = OriginalString.Substring(StartIndex, Length);
            //Console.WriteLine(SubString);
            #endregion

            #region Q5 Write C# program that Assigning one value type variable to another and modifying the value of one variable 
            //int X = 10;
            //int Y = X;

            //X =20 ; //The value will be assigned succesfully 
            ////A copy of the value will be created and the two varibles are indpendant of each other
            //// Changing one of them won't affect the other 
            //Console.WriteLine($"X={X} and Y={Y}"); //X= 20 and Y=10;
            #endregion
        }
    }
}
