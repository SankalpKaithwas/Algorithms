using System;
using System.Collections.Generic;

namespace Algorithm
{
    internal class BubbleSort
    {
        internal void BubbleSortNumber(List<int> number)
        {
            for (int i = 0; i < number.Count; i++)
            {
                for (var j = i + 1; j < number.Count; j++)
                {
                    if (number[j] < number[i])
                    {
                        int temp = number[j];
                        number[j] = number[i];
                        number[i] = temp;
                    }
                }
            }
        }
    }
}