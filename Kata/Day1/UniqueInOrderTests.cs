using System;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Kata
{
    [TestFixture]
    public class Day1Test
    {
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", Day1.UniqueInOrder(""));
        }
        [Test]
        public void ListTest()
        {
            Assert.AreEqual(new List<int> { 1, 2, 3 }, Day1.UniqueInOrder(new List<int> { 1, 2, 3, 3 }));
            Assert.AreEqual(new List<double> { 1, 2, 3 }, Day1.UniqueInOrder(new List<double> { 1, 2, 3, 3 }));
            Assert.AreEqual(new List<char> { '1', '2', '3' }, Day1.UniqueInOrder(new List<char> { '1', '2', '3', '3' }));
            Assert.AreEqual(new List<string> { "1", "2", "3" }, Day1.UniqueInOrder(new List<string> { "1", "2", "3", "3" }));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABCDAB", Day1.UniqueInOrder("AAAABBBCCDAABBB"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("aA", Day1.UniqueInOrder("aA"));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual("AD", Day1.UniqueInOrder("ADD"));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual("DA", Day1.UniqueInOrder("DDA"));
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual("1232456", Day1.UniqueInOrder("112332444566"));
        }
    }
}
