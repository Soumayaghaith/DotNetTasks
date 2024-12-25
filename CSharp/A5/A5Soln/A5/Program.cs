using System.ComponentModel;

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
    }
}
