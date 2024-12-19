using static System.Collections.Specialized.BitVector32;
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
            double num1=2.5, num2 = 10.5;
            Console.WriteLine(num1+num2);
            //I actually don't know what is the point of this question =)
            #endregion

        }
    }
}
