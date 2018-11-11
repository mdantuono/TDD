using NUnit.Framework;
using SmallestService;
using System;


namespace Tests
{
    public class Tests
    {
        [Test]
        public void ThrowsExceptionIfArrayInputIsEmpty()
        {
            var finder = new Finder();
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindSmallestInt(input));
        }

        [Test]
        public void IfArrayLengthIsOneReturnInt()
        {
            var finder = new Finder();
            var input = new int[1] { 1 };
            var output = finder.FindSmallestInt(input);
            bool returnValueIsInt = (output.GetType() == typeof(int));
            Assert.IsTrue(returnValueIsInt);
        }

        [Test]
        public void IfArrayLengthIsTwoReturnLowestInt()
        {
            var finder = new Finder();
            var input = new int[2] { 1, 2 };
            var output = finder.FindSmallestInt(input);

            var expected = 1;
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void IfArrayLengthIsThreeReturnLowestInt()
        {
            var finder = new Finder();
            var input = new int[3] { 3, 1, 2 };
            var output = finder.FindSmallestInt(input);

            var expected = 1;
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void IfArrayLengthIsGreaterThanZeroReturnSmallestInt()
        {
            var finder = new Finder();
            var input = new int[6] { 6, 4, 5, 3, 1, 2 };
            var output = finder.FindSmallestInt(input);

            var expected = 1;
            Assert.AreEqual(expected, output);
        }
    }
}