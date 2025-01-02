using System.ComponentModel;

namespace OOPA2
{
    internal class Program
    {
        //struct person
        //{ 
        //    public string name;
        //    public int age;

        //    //constructor
        //    public person(string In_name, int In_age)
        //    { 
        //        name = In_name; 
        //        age = In_age;
        //    }

        //    //Method for displaying
        //    public void display()
        //    {
        //        Console.WriteLine($"Name: {name}, Age: {age}");
        //    }

        //}
        struct Point
        {
            public double X;
            public double Y;

            //constructor
            public Point(double In_X, double In_Y)
            {
                X = In_X;
                Y = In_Y;
            }

            //Method for displaying
            public double DistanceTo(Point In_point)
            {
                double distance;
                distance = Math.Sqrt(Math.Pow(In_point.X- X,2) + Math.Pow(In_point.Y - Y,2));         

                return distance;
            }

        }
        static void Main(string[] args)
        {
            #region Q1
            //Define a struct "Person" with properties "Name" and "Age". Create an array of
            //three "Person" objects and populate it with data. Then, write a C# program to
            //display the details of all the persons in the array.
            //person[] persons = new person[3];
            //persons[0] = new person("Sarah",25);
            //persons[1] = new person("Lamisse",12);
            //persons[2] = new person("Nadine",26);

            //Console.WriteLine("Persons info:");
            //foreach (person person in persons)
            //{
            //    person.display();
            //}



            #endregion

            #region Q2
            //Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates the
            //distance between them.
            //Point P1, P2;
            //Console.WriteLine("Please enter two points' X and Y");
            //Console.Write("X1:");
            //double.TryParse(Console.ReadLine(),out P1.X);
            //Console.Write("Y1:");
            //double.TryParse(Console.ReadLine(), out P1.Y);

            //Console.Write("X2:");
            //double.TryParse(Console.ReadLine(), out P2.X);
            //Console.Write("Y2:");
            //double.TryParse(Console.ReadLine(), out P2.Y);

            //double distance = P1.DistanceTo(P2);
            //Console.WriteLine($"Distance between the two points is {distance}");


            #endregion
        }
    }
}
