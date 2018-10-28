using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public static class Day1
    {
        //My Solution
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            List<T> finalList = new List<T>();
            var i = 0;
            using (var enumerator = iterable.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var element = enumerator.Current;
                    if (i == 0 || !finalList[finalList.Count - 1].Equals(element))
                    {
                        finalList.Add(element);
                    }
                    i++;
                }
            }
            return finalList;
        }
        //Other Solutions
        public static IEnumerable<T> UniqueInOrder1<T>(IEnumerable<T> iterable)
        {
            T previous = default(T);
            foreach (T current in iterable)
            {
                if (!current.Equals(previous))
                {
                    previous = current;
                    yield return current;
                }
            }
        }
        //OtherSolutions
        public static IEnumerable<T> UniqueInOrder2<T>(IEnumerable<T> iterable)
        {
            var e = iterable.GetEnumerator();
            if (e.MoveNext())
            {
                var c = e.Current;
                while (e.MoveNext())
                {
                    if (!e.Current.Equals(c)) yield return c;
                    c = e.Current;
                }
                yield return c;
            }
        }
    }
}
