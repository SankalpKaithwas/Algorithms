using System;
namespace Algorithm
{
    internal class StringPermutation
    {
        public static void IterativeFindPermutation(string word, string remaining)
        {
            if (remaining == null)
            {
                return;
            }
            else if (remaining.Length == 0)
            {
                Console.WriteLine(word);
            }
            else
            {
                for (int i = 0; i < remaining.Length; i++)
                {
                    string newCandidate = word + remaining[i];
                    string newRemaining = remaining.Substring(0, i) + remaining.Substring(i + 1);
                    IterativeFindPermutation(newCandidate, newRemaining);
                }
            }
        }
        public static void RecursivePermutation(string str, int l, int r)
        {
            if (l == r)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    RecursivePermutation(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }
        public static string swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}