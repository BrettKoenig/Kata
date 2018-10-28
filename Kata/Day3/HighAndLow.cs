using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Kata
{
    public static class Day3
    {
        //My Solution
        public static string HighAndLow(string numbers)
        {
            int high = Int32.MinValue;
            int low = Int32.MaxValue;

            foreach (var s in numbers.Split(' '))
            {
                var test = Int32.Parse(s);
                if (test < low)
                {
                    low = test;
                }

                if (test > high)
                {
                    high = test;
                }
            }

            return high + " " + low;
        }
        ////Other Solutions
        //public static string HighAndLow(string numbers)
        //{
        //    var parsed = numbers.Split().Select(int.Parse);
        //    return parsed.Max() + " " + parsed.Min();
        //}
        ////Other Solutions
        //public static string HighAndLow(string numbers)
        //{
        //    var numbersList = numbers.Split(' ').Select(x => Convert.ToInt32(x));
        //    return string.Format("{0} {1}", numbersList.Max(), numbersList.Min());
        //}
    }
}
