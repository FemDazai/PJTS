using Project.Test_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project.Test.Tests
{
   public  class ArraysTests
    {
        [TestCase(new int[] { 7,6,3,88,6}, 3)] //positivTestArrays1
        [TestCase(new int[] { 0, 0, 0}, 0)]
        [TestCase(new int[] { 7 }, 7)]
        public void FindMinValue(int[] array, int expected)
        {
            int  actual =Arrays.FindMinValue(array);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { })] //negativTestArrays1
        public void FindMinValus_WhenArraysLeigthIsZero_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Arrays.FindMinValue(array));
        }

      
        [TestCase(new int[] { 65, -67, 5, 8, 23 }, 65)] //positivTestArrays2
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { 9 }, 9)]
        public void FindMaxValue(int[] array, int expected)
        {
            int actual = Arrays.FindMaxValue(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })] //negativTestArrays2
        public void FindMaxValue_WhenArraysLeigthIsZero_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Arrays.FindMaxValue(array));
        }

        [TestCase(new int[] { 77, 9, 48, -8, 0 }, 3)] //positivTestArrays3
        [TestCase(new int[] { 0, 8, 0 }, 0)]
        [TestCase(new int[] { 1 }, 0)]
        public void FindIndexMinValueInArray(int[] array, int expected)
        {
            int actual = Arrays.FindIndexMinValueInArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })] //negativTestArrays3
        public void FindIndexMinValueInArray_WhenArraysLeigthIsZero_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Arrays.FindIndexMinValueInArray(array));
        }

        [TestCase(new int[] { 36, 49, -88, 36, 9 }, 1)] //positivTestArrays4
        [TestCase(new int[] { 0, 8, 0,9 }, 3)]
        [TestCase(new int[] { 6 }, 0)]
        public void FindIndexMaxValueInArray(int[] array, int expected)
        {
            int actual = Arrays.FindIndexMaxValueInArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })] //negativTestArrays4
        public void FindIndexMaxValueInArray_WhenArraysLeigthIsZero_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Arrays.FindIndexMaxValueInArray(array));
        }

        [TestCase(new int[] { 6,7,4,3 }, 10)]//positivTestArrays5
        [TestCase(new int[] { 0,6,0,5}, 11)]
        [TestCase(new int[] { 2,-9,0,5,4,-11}, -15)]
        public void CountSumOfArrayElementsWithOddIndices(int[] array, int expected)
        {
            int actual = Arrays.CountSumOfArrayElementsWithOddIndices(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })] //negativTestArrays5
        public void CountSumOfArrayElementsWithOddIndices_WhenArraysLeigthIsZero_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Arrays.CountSumOfArrayElementsWithOddIndices(array));
        }

        [TestCase(new int[] { -1, 8, 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1, 8, -1 })]//positivTestArrays6
        [TestCase(new int[] { -2, 0, 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1, 0, -2 })]
        [TestCase(new int[] { 1, 1, 1, 1}, new int[] { 1, 1, 1, 1 })]
        public void OutputArrayInReverseOrder(int[] array, int[] expected)
        {
            int[] actual = Arrays.OutputArrayInReverseOrder(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })] //negativTestArrays6
        public void OutputArrayInReverseOrder_WhenArraysLeigthIsZero_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Arrays.OutputArrayInReverseOrder(array));
        }

        [TestCase(new int[] { 2, 7, 5, 4, 11 }, 3)]//positivTestArrays7
        [TestCase(new int[] { 9, 7, -5, 3, 12 }, 4)]
        [TestCase(new int[] { 0,0, 0, 0}, 0)]
        [TestCase(new int[] { -9, 2, 4, 6, 12 }, 1)]

        public void FindTheCountOfAllOddArrayElements(int[] array,int expected)
        {
        int actual = Arrays.FindTheCountOfAllOddArrayElements(array);
        Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })] //negativTestArrays7
        public void FindTheCountOfAllOddArrayElements_WhenArraysLeigthIsZero_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Arrays.FindTheCountOfAllOddArrayElements(array));
        }


        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })] //positivTestArray8
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1, 2 })]
        public void SwapTwoHalvesOfAnArray(int[] array, int[] expected)
        {
            int[] actual = Arrays.SwapTwoHalvesOfAnArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })] //negativTestArrays8
        public void SwapTwoHalvesOfAnArray_WhenArraysLeigthIsZero_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Arrays.SwapTwoHalvesOfAnArray(array));
        }


        [TestCase(new int[] { 0, 38, 5 ,-9,1}, new int[] { -9, 0, 1,5,38 })]//positivTestArray9
        [TestCase(new int[] { 0, 0, 0,0 }, new int[] { 0, 0, 0,0 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        public void SelectIncreaseSort(int[] array, int[] expected)
        {
            int[] actual = Arrays.SelectIncreaseSort(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })] //negativTestArrays9
        public void SelectIncreaseSort_WhenArraysLeigthIsZero_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Arrays.SelectIncreaseSort(array));
        }


        [TestCase(new int[] { 6, 29, 0, 51, 4 }, new int[] { 51, 29, 6, 4, 0 })] //positivTestArray10
        public void SortTheArrayInDescendingOrder(int[] array, int[] expected)
        {
            int[] actual = Arrays.SortTheArrayInDescendingOrder(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })] //negativTestArrays10
        public void SortTheArrayInDescendingOrder_WhenArraysLeigthIsZero_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Arrays.SortTheArrayInDescendingOrder(array));
        }
    }
}
