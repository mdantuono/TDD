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
    }
}
