using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace A4
{
    ///Q1) Write a class named Calculator that contains a method named Add.Overload
    ///the Add method to:
    ///● Accept two integers and return their sum.
    ///● Accept three integers and return their sum.
    ///● Accept two doubles and return their sum.
    internal class Calculator
    {
        public int Add(int num1, int num2)
        {
           return num1 + num2;
        }

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
