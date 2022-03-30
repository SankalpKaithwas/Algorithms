using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chhose 1: for String permutations");
            int options = int.Parse(Console.ReadLine());

            switch (options)
            {
                case 1:
                    Console.WriteLine("Enter a string");
                    string word = Console.ReadLine();
                    Console.WriteLine("Recursive ->");
                    StringPermutation.RecursivePermutation(word, 0, word.Length - 1);
                    Console.WriteLine("Iterarive ->");
                    StringPermutation.IterativeFindPermutation("", word);
                    break;
                default:
                    Console.WriteLine("Choose valid");
                    break;
            }
        }
    }
}
