using System;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    [TestFixture]
    public class Day4Test
    {
        [Test]
        public void Test1()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            Assert.AreEqual("YES", Day4.Tickets(peopleInLine));
        }

        [Test]
        public void Test2()
        {
            int[] peopleInLine = new int[] { 25, 100 };
            Assert.AreEqual("NO", Day4.Tickets(peopleInLine));
        }

        [Test]
        public void Test3()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 };
            Assert.AreEqual("YES", Day4.Tickets(peopleInLine));
        }

        [Test]
        public void Test4()
        {
            int[] peopleInLine = new int[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };
            Assert.AreEqual("NO", Day4.Tickets(peopleInLine));
        }

        [Test]
        public void Test5()
        {
            int[] peopleInLine = new int[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 };
            Assert.AreEqual("NO", Day4.Tickets(peopleInLine));
        }

        [Test]
        public void Test6()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 50, 100, 50 };
            Assert.AreEqual("YES", Day4.Tickets(peopleInLine));
        }

        [Test]
        public void Test7()
        {
            int[] peopleInLine = new int[] { 25, 25 };
            Assert.AreEqual("YES", Day4.Tickets(peopleInLine));
        }

        [Test]
        public void Test8()
        {
            int[] peopleInLine = new int[] { 50, 100, 100 };
            Assert.AreEqual("NO", Day4.Tickets(peopleInLine));
        }

        [Test]
        public void Test9()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 25, 25, 25, 50, 50, 50, 100, 100, 100, 100 };
            Assert.AreEqual("NO", Day4.Tickets(peopleInLine));
        }

        [Test]
        public void Test10()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50, 100 };
            Assert.AreEqual("NO", Day4.Tickets(peopleInLine));
        }
        [Test]
        public void Test11()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 25, 100, 100 };
            Assert.AreEqual("NO", Day4.Tickets(peopleInLine));
        }
    }
}
