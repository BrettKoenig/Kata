using System.Linq;

namespace Kata
{
    public static class Day2
    {
        //My Solution
        public static bool IsIsogram(string str)
        {
            return str.ToLower().ToCharArray().Distinct().Count() == str.Length;
        }
    }
}
