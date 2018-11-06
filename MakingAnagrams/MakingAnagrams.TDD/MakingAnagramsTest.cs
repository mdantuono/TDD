using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAnagrams.TDD
{
    [TestFixture]
    public class MakingAnagramsTest
    {
        [Test]
        public void MustReturnAnInteger()
        {
            var input1 = "a";
            var input2 = "a";

            var makingAnagrams = new MakingAnagrams();
            var output = makingAnagrams.CheckAnagram(input1, input2);

            bool shouldBeInteger = true;
            bool ourOutputIsInteger = (output.GetType() == typeof(int));

            Assert.AreEqual(shouldBeInteger, ourOutputIsInteger);
        }

        [Test]
        public void CheckIfSameStringReturnZero()
        {
            var input1 = "abc";
            var input2 = "abc";

            var expectedOutput = 0;
            var makingAnagrams = new MakingAnagrams();

            var output = makingAnagrams.CheckAnagram(input1, input2);

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void CheckIfStringsAreAnagramsShouldReturnZero()
        {
            var input1 = "abc";
            var input2 = "cba";

            var expectedOutput = 0;
            var makingAnagrams = new MakingAnagrams();

            var output = makingAnagrams.CheckAnagram(input1, input2);

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void IfStringOneIsLongerCountExtraLetters()
        {
            var input1 = "abcd";
            var input2 = "abc";

            var expectedOutput = 1;
            var makingAnagrams = new MakingAnagrams();

            var output = makingAnagrams.CheckAnagram(input1, input2);

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void IfStringTwoIsLongerCountExtraLetters()
        {
            var input1 = "abc";
            var input2 = "abcd";

            var expectedOutput = 1;
            var makingAnagrams = new MakingAnagrams();

            var output = makingAnagrams.CheckAnagram(input1, input2);

            Assert.AreEqual(expectedOutput, output);
        }
    }
}
