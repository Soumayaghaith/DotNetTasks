using static System.Collections.Specialized.BitVector32;
using System.Drawing;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.NetworkInformation;
using System;


namespace A3
{
    class Point
    {
        public int X;
        public int Y;
        
    }

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

            #region Q6 Simply Refernce Value Assignment
            // I Created a class called Point for trial
            //Point P1 = new Point();
            //P1.X = 5;
            //P1.Y=10;
            //Console.WriteLine($"Before assignment P1.X= {P1.X} and P1.Y={P1.Y}");

            //Point P2=P1;
            //Console.WriteLine($"After assignment P2.X={P2.X} and P2.Y= {P2.Y}");


            //P2.X = 50;
            //P2.Y= 100;

            //Console.WriteLine("After Modifying P2");
            //Console.WriteLine($"P2.X={P2.X} and P2.Y= {P2.Y}");
            ////P1 is also affected becuase they both point at the same data in heap

            //Console.WriteLine($"P1.X= {P1.X} and P1.Y={P1.Y}"); 



            #endregion

            #region Q7 Write C# program that take two string variables and print them as one variable
            //Console.WriteLine("Please enter the first string");
            //string first = Console.ReadLine();

            //Console.WriteLine("Please enter the second string");
            //string second = Console.ReadLine();

            //Console.WriteLine(string.Format("{0} {1}", first, second));

            #endregion

            #region Q8
            //Write a program that calculates the simple interest given the principal amount,
            //rate of interest, and time.The formula for simple interest is
            //Interest = (principal * rate * time) / 100.

            double simpleInterest;
            int principal, rate, time;

            Console.WriteLine("Please enter the following");
            Console.Write("principal amount: ");
            principal= int.Parse(Console.ReadLine());
            Console.Write("rate: ");
            rate = int.Parse(Console.ReadLine());
            Console.Write("time: ");
            time = int.Parse(Console.ReadLine());

            simpleInterest = (principal * rate * time) / 100;

            Console.WriteLine($"The simple interest is {simpleInterest}");

            #endregion

        }
    }
}
