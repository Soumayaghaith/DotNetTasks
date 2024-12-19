using static System.Collections.Specialized.BitVector32;
using System.Drawing;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.NetworkInformation;
using System;
using System.Diagnostics.Metrics;
using System.ComponentModel;
using System.Reflection.Metadata;


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

            //double simpleInterest;
            //int principal, rate, time;

            //Console.WriteLine("Please enter the following");
            //Console.Write("principal amount: ");
            //principal= int.Parse(Console.ReadLine());
            //Console.Write("rate: ");
            //rate = int.Parse(Console.ReadLine());
            //Console.Write("time: ");
            //time = int.Parse(Console.ReadLine());

            //simpleInterest = (principal * rate * time) / 100;

            //Console.WriteLine($"The simple interest is {simpleInterest}");

            #endregion

            #region Q9
            //- Write a program that calculates the Body Mass Index (BMI)given a person's weight
            //in kilograms and heightin meters.The formula for BMI is
            //BMI = (Weight) / (Height * Height)

            //Console.Write("Please enter your weight: ");
            //int weight = int.Parse(Console.ReadLine());

            //Console.Write("Please enter your heightt: ");
            //int height = int.Parse(Console.ReadLine());

            //double BMI = (weight) / (height * height);

            //Console.WriteLine($"BMI = {BMI}");


            #endregion

            #region Q10
            //Write a program that uses the ternary operator to check if the temperature is too hot,
            //too cold, or just good.Assign the result in a variable then display the result.
            //Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything
            //else is "Just Good".
            //Console.WriteLine("Please enter the temprature degree");
            //int degree = int.Parse(Console.ReadLine());
            //string result = (degree < 10) ? "just cold" :(degree>30)? "Just Hot" : "Just Good";
            //Console.WriteLine(result);
            #endregion

            #region Q11
            //Write a program that takes the date from the user and displays
            //it in various formats using string interpolation.
            //Ex :
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001
            //Console.WriteLine("Please enter today's dtae (in numbers)");
            //Console.Write("Day: ");
            //int day = int.Parse(Console.ReadLine());
            //Console.Write("month: ");
            //int month = int.Parse(Console.ReadLine()); ;
            //Console.Write("year: ");
            //int year = int.Parse(Console.ReadLine()); ;
            //Console.WriteLine($"Today's date is {day} , {month} , {year}");
            //Console.WriteLine($"Today's date is {day} / {month} / {year}");
            //Console.WriteLine($"Today's date is {day} - {month} - {year}");

            #endregion

            #region Q12
            //What is the output of the following C# code?
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            //My answer would be 06/14/2024 and after running the code it was coorect 

            #endregion

            #region Q13
            //Which of the following statements is correct about the C#.NET code snippet given below?
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);

            // My answer woul be 1 and after running the code it was correct
            #endregion

            #region Q14
            //Which of the following is the correct output for the C# code given below?
            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            //My answer would be 6.5 1 and it was wrong 
            //The correct answer was 6 1
            //I don't know why the fraction was dropped, I think it is sth about the implemnetation 
            // of the console.writeLine
            #endregion

        }
    }
}
