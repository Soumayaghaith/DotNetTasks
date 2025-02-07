using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace A1.Q1
{
    internal class Range<T> where T : IComparable<T>
    {

        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T min, T max)
        {
            if (min.CompareTo(max)>0)
            {
                Console.WriteLine("The min=imum value should be less than the maximum value");
            }
            Min = min;
            Max = max;
        }
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max)<=0;
        
        }
        //Think about it again
        //I searched for it and found that The dynamic keyword allows variables to
        //bypass compile-time type checking and defer type resolution to runtime.
        //This is useful when dealing with scenarios where the type is unknown at compile time
        public dynamic Length() 
        {
           
            return (dynamic)Max -(dynamic) Min ;
        }

    }
}
