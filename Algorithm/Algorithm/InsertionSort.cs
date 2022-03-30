using System;

namespace Algorithm
{
    internal class InsertionSort
    {
        public void InsertSort(IComparable[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {
                IComparable value = array[i];
                int j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
    }
}