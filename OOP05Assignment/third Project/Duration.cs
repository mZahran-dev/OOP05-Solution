using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05Assignment.third_Project
{
    internal class Duration
    {
        #region Properties (Q1)
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        #endregion

        #region Constructors (Q3)
        public Duration() : this(0, 0, 0) { }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalize();
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
            Normalize();
        } 
        #endregion

        #region Operators Overloading (Q4)


        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds() + d2.TotalSeconds());
        }


        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.TotalSeconds() + seconds);
        }


        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(seconds + d.TotalSeconds());
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds = d1.TotalSeconds() - d2.TotalSeconds();
            return new Duration(totalSeconds < 0 ? 0 : totalSeconds);
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.TotalSeconds() + 60);
        }


        public static Duration operator --(Duration d)
        {
            return new Duration(d.TotalSeconds() - 60);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        public static implicit operator DateTime(Duration d)
        {
            DateTime today = DateTime.Today;
            return today.AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() >= d2.TotalSeconds();
        }


        #endregion


        #region Overrided Method (Q2)
        public override string ToString()
        {
            string result = $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            if (Hours == 0 && Minutes == 0)
            {
                result = $"Seconds: {Seconds}";
            }
            else if (Hours == 0)
            {
                result = $"Minutes: {Minutes}, Seconds: {Seconds}";
            }
            return result;
        }
        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        #endregion

        // Method to Normalize the difference between Durations
        private void Normalize()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }

        // Helper method to calculate total seconds
        private int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

    }
}
