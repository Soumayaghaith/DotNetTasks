using System.ComponentModel;

namespace A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //- Explain the difference between passing (Value type parameters) by value and
            //by reference then write a suitable c# example.

            //Passing by value changes in the copy of the variable(stored in stack) not the variable itself
            //Passing by ref changes in the original variable 
            int valType = 10, refType = 10;
            Console.WriteLine("Before Function call");
            Console.WriteLine($"The value type argu is {valType}");
            Console.WriteLine($"The ref type argu is {refType}");
            Console.WriteLine( "-------------------------------");
            ModifyValue(valType);
            ModifyRef(ref refType);

            Console.WriteLine("After Function call");
            Console.WriteLine($"The value type argu is {valType}");
            Console.WriteLine($"The ref type argu is {refType}");

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
    }
}
