using NUnit.Framework;
using String.Calculator;

namespace StringCalculator.Tests
{
    [TestFixture]
    public class StringCalculator_CalculatorShould
    {
        [Test]
        public void ShouldReturnInt()
        {
            var inputString = "";
            bool shouldBeInt = true;

            StringCalculatorService stringCalculatorService = new StringCalculatorService();
            var output = stringCalculatorService.StringCalculator(inputString);

            bool outputIsInt = (output.GetType() == typeof(int));

            Assert.AreEqual(shouldBeInt, outputIsInt);
        }

        [Test]
        public void ShouldReturnZeroOnEmptyString()
        {
            var inputString = "";
            var expectedOutput = 0;

            StringCalculatorService stringCalculatorService = new StringCalculatorService();
            var output = stringCalculatorService.StringCalculator(inputString);

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void ShouldReturnStringValueIfOnlyOneValue()
        {
            var inputString = "1";
            var expectedOutput = 1;

            StringCalculatorService stringCalculatorService = new StringCalculatorService();
            var output = stringCalculatorService.StringCalculator(inputString);

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void ShouldReturnAddedValuesIfTwoValues()
        {
            var inputString = "1,2";
            var expectedOutput = 3;

            StringCalculatorService stringCalculatorService = new StringCalculatorService();
            var output = stringCalculatorService.StringCalculator(inputString);

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void ShouldReturnAddedValuesWhenThreeValues()
        {
            var inputString = "1,2,3";
            var expectedOutput = 6;

            StringCalculatorService stringCalculatorService = new StringCalculatorService();
            var output = stringCalculatorService.StringCalculator(inputString);

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void ShouldReturnValuesWhenSeparatedByEitherNewLineOrComma()
        {
            var inputString = "1\n2,3";
            var expectedOutput = 6;

            StringCalculatorService stringCalculatorService = new StringCalculatorService();
            var output = stringCalculatorService.StringCalculator(inputString);

            Assert.AreEqual(expectedOutput, output);
        }

        //[Test]
        //public void SupportDifferentDelimiters()
        //{
        //    var inputString = "//;\n1;2";
        //    var expectedOutput = 3;

        //    StringCalculatorService stringCalculatorService = new StringCalculatorService();
        //    var output = stringCalculatorService.StringCalculator(inputString);

        //    Assert.AreEqual(expectedOutput, output);
        //}
    }
}