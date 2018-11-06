using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLeftRotation.Test
{
    class ArraysLeftRotation
    {
        internal static object LeftRotate(int[] intArray, int rotations)
        {
            List<int> arrayList = intArray.ToList();
            for (var i = 0; i < rotations; i++)
            {
                arrayList.Add(arrayList[0]);
                arrayList.Remove(arrayList[0]);
            }
            return arrayList.ToArray();
        }
    }
}
