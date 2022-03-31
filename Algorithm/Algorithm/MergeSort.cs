namespace Algorithm
{
    internal class MergeSorts
    {
        static void Merge(int[] a, int beg, int mid, int end)
        {
            int i, j, k;
            int n1 = mid - beg + 1;
            int n2 = end - mid;
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];
            for (i = 0; i < n1; i++)
                leftArray[i] = a[beg + i];
            for (j = 0; j < n2; j++)
                rightArray[j] = a[mid + 1 + j];

            i = 0;
            j = 0;
            k = beg;

            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    a[k] = leftArray[i];
                    i++;
                }
                else
                {
                    a[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                a[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                a[k] = rightArray[j];
                j++;
                k++;
            }
        }
        public void MergeSort(int[] a, int beg, int end)
        {
            if (beg < end)
            {
                int mid = (beg + end) / 2;
                MergeSort(a, beg, mid);
                MergeSort(a, mid + 1, end);
                Merge(a, beg, mid, end);
            }
        }
    }
}