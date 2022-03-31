using System;

namespace Algorithm
{
    internal class AnagramDetection
    {
        public void CheckAnagram(string firstWord, string secondWord)
        {
            char[] firstArray = firstWord.ToLower().ToCharArray();
            char[] secondArray = firstWord.ToLower().ToCharArray();
            Array.Sort(firstArray);
            Array.Sort(secondArray);
            string firstString = new string(firstArray);
            string secondString = new string(secondArray);
            if (firstString.Equals(secondString))
                Console.WriteLine("The strings are Anagrams");
            else
                Console.WriteLine("The strings are not Anagram");
        }
    }
}