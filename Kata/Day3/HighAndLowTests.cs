using System;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    [TestFixture]
    public class Day3Test
    {
        [Test]
        public void SomeTest()
        {
            Assert.AreEqual("542 -214", Day3.HighAndLow("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6"));
        }

        [Test]
        public void SortTest()
        {
            Assert.AreEqual("10 -10", Day3.HighAndLow("10 2 -2 -10"));
        }

        [Test]
        public void PlusMinusTest()
        {
            Assert.AreEqual("1 -1", Day3.HighAndLow("1 -1"));
        }

        [Test]
        public void PlusPlusTest()
        {
            Assert.AreEqual("1 1", Day3.HighAndLow("1 1"));
        }

        [Test]
        public void MinusMinusTest()
        {
            Assert.AreEqual("-1 -1", Day3.HighAndLow("-1 -1"));
        }

        [Test]
        public void PlusMinusZeroTest()
        {
            Assert.AreEqual("1 -1", Day3.HighAndLow("1 -1 0"));
        }

        [Test]
        public void PlusPlusZeroTest()
        {
            Assert.AreEqual("1 0", Day3.HighAndLow("1 1 0"));
        }

        [Test]
        public void MinusMinusZeroTest()
        {
            Assert.AreEqual("0 -1", Day3.HighAndLow("-1 -1 0"));
        }

        [Test]
        public void SingleTest()
        {
            Assert.AreEqual("42 42", Day3.HighAndLow("42"));
        }

        [Test]
        public void RandomTest()
        {
            Random r = new Random();
            List<int> numbers = new List<int>();
            for (int i = r.Next(1, 42); i > 0; i--)
                numbers.Add(r.Next(Int32.MinValue, Int32.MaxValue));
            Assert.AreEqual(numbers.Max().ToString() + " " + numbers.Min().ToString(), Day3.HighAndLow(String.Join(" ", numbers.Select(n => n.ToString()).ToArray())));
        }
    }
}
