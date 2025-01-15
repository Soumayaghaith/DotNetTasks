using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace A4
{
    internal class Duration
    {

        #region Properties 
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Constructors 
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalizer();
        }
        public Duration(int seconds)
        {

            Hours = seconds / 3600;
            seconds = seconds % 3600;

            Minutes = seconds / 60;
            Seconds = seconds % 60;




        }
        #endregion

        #region Methods
        private void Normalizer()
        {
            Minutes += Seconds / 60;
            Seconds %= 60;

            Hours += Minutes / 60;
            Minutes %= 60;


        }

        private int GetTotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
        #endregion

        #region Overriding System.Object Members 
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            if (Hours == 0)
            {
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }

        }
        #endregion

        #region Operator Overloading
        //D3=D1+D2

        public static Duration operator +(Duration left, Duration right)
        {

            return new Duration(left.Hours + right.Hours, left.Minutes + right.Minutes, left.Seconds + right.Seconds);
        }
        //D3=D1 + 7800
        public static Duration operator +(Duration left, int totalSeconds)
        {

            return new Duration(left.Hours, left.Minutes, left.Seconds + totalSeconds);
        }
        //D3=666+D3
        public static Duration operator +(int totalSeconds, Duration right)
        {

            return new Duration(right.Hours, right.Minutes, right.Seconds + totalSeconds);
        }
        //D3= ++D1 (Increase One Minute)
        public static Duration operator ++(Duration D)
        {
            return new Duration(D.Hours, D.Minutes + 1, D.Seconds);
        }
        //D3 = --D2 (Decrease One Minute)
        public static Duration operator --(Duration D)
        {
            return new Duration(D.Hours, D.Minutes - 1, D.Seconds);
        }
        //If (D1>D2)
        public static bool operator >(Duration left, Duration right)
        {
            return left.GetTotalSeconds() > right.GetTotalSeconds();
        }
        public static bool operator <(Duration left, Duration right)
        {

            return left.GetTotalSeconds() < right.GetTotalSeconds();
        }
        //D1= D1 -D2
        public static Duration operator -(Duration left, Duration right)
        {

            return new Duration(left.Hours - right.Hours, left.Minutes - right.Minutes, left.Seconds - right.Seconds);
        }

        //● If (D1<=D2)
        public static bool operator <=(Duration left, Duration right)
        {

            return left.GetTotalSeconds() <= right.GetTotalSeconds();
        }
        public static bool operator >=(Duration left, Duration right)
        {

            return left.GetTotalSeconds() >= right.GetTotalSeconds();
        }
        //● If (D1)
        public static bool operator true(Duration D)
        { 
            return D.GetTotalSeconds()>0;
        }
        public static bool operator false(Duration D)
        {
            return D.GetTotalSeconds() == 0;
        }

        //● DateTime Obj = (DateTime) D
        public static DateTime operator Datetime(Duration D)
        { 
            DateTime dateTime = DateTime.Now;
            return dateTime.AddHours(D.Hours).AddMinutes(D.Minutes).AddSeconds(D.Seconds);
        }
        #endregion


    }
}
