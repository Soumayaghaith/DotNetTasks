using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace A4
{
    ///Q3) Define a class Complex Number that represents a complex number with real
    ///and imaginary parts.
    ///
    /// * Note: Overload the +, - operator to add and subtract two complex numbers.
    internal class Complex
    {
        #region Properties
        public int Real { get; set; }
        public int Img { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }


        #endregion

        #region Operators Overloading
        public static Complex operator +(Complex left, Complex right)
        {

            return new Complex()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Img = (left?.Img ?? 0) + (right?.Img ?? 0)
            };
        }
        public static Complex operator -(Complex left, Complex right)
        {

            return new Complex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Img = (left?.Img ?? 0) - (right?.Img ?? 0)
            };
        }
        


        #endregion

    }
}
