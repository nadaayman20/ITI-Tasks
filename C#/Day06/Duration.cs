using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Duration
    {
        int Hours;
        int Minutes;
        int Seconds;

        public Duration(int hours, int minutes, int seconds)
        {
            int Sec = hours * 3600 + minutes + 60 + seconds;
            if (Sec > 0)
            {
                Hours = Sec / 3600;
                Minutes = (Sec % 3600) / 60;
                Seconds = Sec % 60;

            }
            else
            {
                Hours = 0;
                Minutes = 0;
                Seconds = 0;
            }
        }
        public Duration(int seconds)
        {
            if (seconds > 0)
            {
                Hours = seconds / 3600;
                Minutes = (seconds % 3600) / 60;
                Seconds = seconds % 60;
            }
            else
            {
                Hours = 0;
                Minutes = 0;
                Seconds = 0;
            }
        }
        private int convertToSecond()
        {
            return Hours * 3600 + Minutes + 60 + Seconds;
        }
        public override string ToString()
        {
            string T = "";
            if (Hours > 0)
                T += $"Hours: {Hours}, ";
            return T += $"Minutes: {Minutes}, Seconds: {Seconds}";
        }

        public void Show()
        {
            Console.WriteLine(ToString());
        }
        public static explicit operator string(Duration D1)
        {
            return D1.ToString();
        }

        public static Duration operator +(Duration D1, Duration D2)
        {
            return new Duration(D1.Hours + D2.Hours, D1.Minutes + D2.Minutes, D1.Seconds + D2.Seconds);
        }

        public static Duration operator +(Duration D1, int sec)
        {
            int hour = sec / 3600;
            int minute = (sec % 3600) / 60;
            int second = sec % 60;
            return new Duration(D1.Hours + hour, D1.Minutes + minute, D1.Seconds + second);
        }
        public static Duration operator +(int sec, Duration D1)
        {
            int hour = sec / 3600;
            int minute = (sec % 3600) / 60;
            int second = sec % 60;
            return new Duration(D1.Hours + hour, D1.Minutes + minute, D1.Seconds + second);
        }

        public static Duration operator ++(Duration D1)
        {
            return new Duration(D1.Hours, D1.Minutes + 1, D1.Seconds);
        }
        public static Duration operator --(Duration D2)
        {
            return new Duration(D2.Hours, D2.Minutes - 1, D2.Seconds);
        }
        public static bool operator ==(Duration D1, Duration D2)
        {
            return (D1.Hours == D2.Hours && D1.Minutes == D2.Minutes && D1.Seconds == D2.Seconds);
        }
        public static bool operator !=(Duration D1, Duration D2)
        {
            if (D1 == D2)
                return false;
            else return true;
        }
        public static bool operator >(Duration D1, Duration D2)
        {
            int d1 = D1.convertToSecond();
            int d2 = D2.convertToSecond();
            return (d1 > d2);
        }
        public static bool operator >=(Duration D1, Duration D2)
        {
            int d1 = D1.convertToSecond();
            int d2 = D2.convertToSecond();
            return (d1 >= d2);
        }
        public static bool operator <(Duration D1, Duration D2)
        {
            int d1 = D1.convertToSecond();
            int d2 = D2.convertToSecond();
            return (d1 < d2);
        }
        public static bool operator <=(Duration D1, Duration D2)
        {
            int d1 = D1.convertToSecond();
            int d2 = D2.convertToSecond();
            return (d1 <= d2);
        }
        public static implicit operator bool(Duration D1)
        {
            return (D1.Seconds != 0 || D1.Minutes != 0 || D1.Hours != 0);
        }

    }
}
