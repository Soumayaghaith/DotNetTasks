using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;

namespace OOPA1
{
    enum WeekDays{Sat,Sun,Mon,Tue,Wed,Thurs,Fri}
    enum Seasons { Spring, Summer, Autumn, Winter}
    [Flags] // Allows bitwise operations on the enum
    enum Permissions
    {
        None = 0,        
        Read = 1,        
        Write = 2,       
        Delete = 4,      
        Execute = 8      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1. Create an enum called "WeekDays" with the days of the week (Monday to Sunday)
            //as its members.Then, write a C# program that prints out all the days of the weekusing this enum.
            //Console.WriteLine("The days of the week are:");
            //for (int i=0; i<=6;i++)
            //{
            //    WeekDays day = (WeekDays)i;
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Q2
            //2.Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn,
            //Winter) as its members.Write a C# program that takes a season name as input from the
            //user and displays the corresponding month range for that season. Note range for
            //seasons(spring march to may, summer june to august, autumn September to
            //November, winter December to February
            //Console.WriteLine("Please enter a season name");
            //string input = Console.ReadLine();

            //Seasons.TryParse(input, out Seasons seasonNum);
            //switch (seasonNum)
            //{
            //    case Seasons.Spring:
            //        Console.WriteLine("Spring is from March to May");
            //        break;
            //    case Seasons.Summer:
            //        Console.WriteLine("Summer is from June to August");
            //        break;
            //    case Seasons.Autumn:
            //        Console.WriteLine("Autumn is from September to November");
            //        break;
            //    case Seasons.Winter:
            //        Console.WriteLine("Winter is from December to Feb");
            //        break;
            //    default:
            //        break;
            //}
            #endregion

            #region Q3
            //3. Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //● Create Variable from previous Enum to Add and Remove Permission from variable,
            //check if specific Permission is existed inside variable
            
        //    Permissions userPermissions = Permissions.None;

        //    //Adding permissions 
        //    userPermissions |= Permissions.Read; 
        //    userPermissions |= Permissions.Write;
        //    Console.WriteLine($"Permissions after adding Read and Write: {userPermissions}");

        //    //check if specific Permission is existed inside variable
        //    if ((userPermissions & Permissions.Read) == Permissions.Read)
        //    {
        //        Console.WriteLine("Read permission exists.");
        //    }

            
        //    userPermissions &= ~Permissions.Read; 
        //    Console.WriteLine($"Permissions after removing Read: {userPermissions}");

            
        //    if ((userPermissions & Permissions.Read) != Permissions.Read)
        //    {
        //        Console.WriteLine("Read permission does not exist.");
        //    }
        //}

        #endregion
    }
    }

