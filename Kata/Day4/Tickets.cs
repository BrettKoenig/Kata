using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Kata
{
    public static class Day4
    {
        //My Solution
        public static string Tickets(int[] peopleInLine)
        {
            Dictionary<int, int> cashOnHand =
                new Dictionary<int, int>();
            foreach (var i in peopleInLine)
            {
                if (cashOnHand.ContainsKey(i))
                {
                    cashOnHand[i] = cashOnHand[i] + 1;
                }
                else
                {
                    cashOnHand.Add(i, 1);
                }

                if (i > 25)
                {
                    var changeNeeded = i - 25;
                    foreach (var billValue in cashOnHand.Keys.Where(x => x <= changeNeeded).OrderByDescending(x => x))
                    {
                        int count = (int)(changeNeeded / billValue);
                        if (count > cashOnHand[billValue])
                        {
                            count = cashOnHand[billValue];
                        }
                        cashOnHand[billValue] = cashOnHand[billValue] - count;
                        changeNeeded -= count * billValue;
                    }

                    if (changeNeeded != 0)
                    {
                        return "NO";
                    }
                }
            }
            return "YES";
        }
        //Other Solutions
    }
}
