using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Project.Test_
{
    public static class Arrays
    {
        public static int FindMinValue(int[] array)//Array1
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array length is zero");
            }
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int FindMaxValue(int[] array)//Array2
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array length is zero");
            }
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int FindIndexMinValueInArray(int[] array)//Array3
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array length is zero");
            }
            int min = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }

        public static int FindIndexMaxValueInArray(int[] array)//Array4
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array length is zero");
            }
            int max = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    index = i;
                }
            }
            return index;
        }

        public static int CountSumOfArrayElementsWithOddIndices(int[] array)//Array5
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array length is zero");
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                    sum += array[i];
            }
            return sum;
        }

        public static int[] OutputArrayInReverseOrder(int[] array)//Array6
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array length is zero");
            }
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] += array[array.Length - 1 - i];
            }
            return arr;
        }

        public static int FindTheCountOfAllOddArrayElements(int[] array)//Array7
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array length is zero");
            }
            int quantity = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    quantity++;
            }
            return quantity;
        }

        public static int[] SwapTwoHalvesOfAnArray(int[] array)//Array8
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array length is zero");
            }
            int f = array.Length / 2;
            if (array.Length % 2 != 0)
            {
                f = array.Length / 2 + 1;
            }
            else f = array.Length / 2;
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[f];
                array[f] = temp;
                f++;
            }
            return array;
        }

        public static int[] SelectIncreaseSort(int[] array)//Array9
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array length is zero");
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                int IndexOfMin = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[IndexOfMin])
                    {
                        IndexOfMin = j;
                    }
                }
                int tmp = array[IndexOfMin];
                array[IndexOfMin] = array[i];
                array[i] = tmp;
            }
            return array;
        }

        public static int[] SortTheArrayInDescendingOrder(int[] array)//Array10
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array length is zero");
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
