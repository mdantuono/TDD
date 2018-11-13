using System;
using System.Linq;

namespace SmallestService
{
    public class Finder
    {
        public int FindSmallestInt(int[] inputArray)
        {
            if (inputArray.Length < 1)
                throw new System.ArgumentException();
            Array.Sort(inputArray);
            return inputArray[0];
        }

        public int FindClosestIntToZero(int[] input)
        {
            if (input.Length > 1)
            {
                Array.Sort(input);
                var i = 0;
                if (Math.Abs(input[i]) > Math.Abs(input[i + 1])) i++;
                return input[i];
            }
            else if (input.Length == 1) return input[0];
            throw new System.ArgumentException();
        }
    }
}
