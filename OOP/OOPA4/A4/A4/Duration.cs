using System;
using System.Collections.Generic;
using System.Linq;
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
            Seconds %=  60;

            Hours += Minutes / 60;
            Minutes %= 60;


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
            if (Hours ==0)
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

            return new Duration(left.Hours , left.Minutes, left.Seconds + totalSeconds);
        }
        //D3=666+D3
        public static Duration operator +(int totalSeconds, Duration right)
        {

            return new Duration(right.Hours, right.Minutes, right.Seconds + totalSeconds);
        }
        //D3= ++D1 (Increase One Minute)
        public static Duration operator ++(Duration D)
        {
            return new Duration(D.Hours, D.Minutes+1 , D.Seconds );
        }
        //D3 = --D2 (Decrease One Minute)
        public static Duration operator --(Duration D)
        {
            return new Duration(D.Hours, D.Minutes - 1, D.Seconds);
        }
        //If (D1>D2)
        public static bool operator > (Duration left, Duration right)
        {

            if (left?.Hours > right?.Hours)
            {
                return left?.Hours > right?.Hours;
            }
            else if (left?.Minutes > right?.Minutes)
            {
                return left?.Minutes > right?.Minutes;
            }
            else if (left?.Seconds > right?.Seconds)
            {
                return left?.Seconds > right?.Seconds;
            }
            return false;
        }
        public static bool operator <(Duration left, Duration right)
        {

            if (left?.Hours < right?.Hours)
            {
                return left?.Hours <right?.Hours;
            }
            else if (left?.Minutes < right?.Minutes)
            {
                return left?.Minutes < right?.Minutes;
            }
            else if (left?.Seconds < right?.Seconds)
            {
                return left?.Seconds < right?.Seconds;
            }
            return false;
        }
        //D1= D1 -D2
        public static Duration operator -(Duration left, Duration right)
        {

            return new Duration(left.Hours - right.Hours, left.Minutes - right.Minutes, left.Seconds - right.Seconds);
        }
        //I still need to understand the requirment
        //● If (D1<=D2)
        //● If (D1)
        //● DateTime Obj = (DateTime) D
        #endregion


    }
}
