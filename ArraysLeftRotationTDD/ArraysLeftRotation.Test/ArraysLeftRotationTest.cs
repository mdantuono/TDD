using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLeftRotation.Test
{
    [TestFixture]
    public class ArraysLeftRotationTest
    {
        [Test]
        public void MustReturnArrayOfIntegers()
        {
            const int arrSize = 2;
            int rotations = 0;

            int[] intArray = new int[arrSize] { 1, 2 };

            var leftRotate = new ArraysLeftRotation();
            var output = ArraysLeftRotation.LeftRotate(intArray, rotations);

            bool returnedIntArray = (output.GetType() == typeof(int[]));
            bool shouldBeIntArray = true;

            Assert.AreEqual(shouldBeIntArray, returnedIntArray);
        }

        [Test]
        public void ZeroRotations()
        {
            const int arrSize = 4;
            int rotations = 0;

            int[] intArray = new int[arrSize] { 1, 2, 3, 4 };

            var leftRotate = new ArraysLeftRotation();
            var output = ArraysLeftRotation.LeftRotate(intArray, rotations);

            int[] expected = { 1, 2, 3, 4 };

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void OneRotation()
        {
            const int arrSize = 4;
            int rotations = 1;

            int[] intArray = new int[arrSize] { 1, 2, 3, 4 };

            var leftRotate = new ArraysLeftRotation();
            var output = ArraysLeftRotation.LeftRotate(intArray, rotations);

            int[] expected = { 2, 3, 4, 1 };

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TwoRotationsWithSizeOfSix()
        {
            const int arrSize = 6;
            int rotations = 2;

            int[] intArray = new int[arrSize] { 1, 2, 3, 4 , 5, 6};

            var leftRotate = new ArraysLeftRotation();
            var output = ArraysLeftRotation.LeftRotate(intArray, rotations);

            int[] expected = { 3, 4, 5, 6, 1, 2 };

            Assert.AreEqual(expected, output);
        }
    }
}
