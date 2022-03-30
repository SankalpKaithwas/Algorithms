﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose 1: For String Permutations");
            Console.WriteLine("Choose 2: For Binary Search");
            Console.WriteLine("Choose 3: For Insertion Sort");
            Console.WriteLine("Choose 4: For Bubble Sort");
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
                case 2:
                    string sentence = "hello,coding,is,fun";
                    Console.WriteLine($"The sentence is - {sentence}");
                    string[] array = sentence.Split(",");
                    BinarySearch<string> search = new BinarySearch<string>(array[0]);
                    for (int i = 1; i < array.Length; i++)
                    {
                        search.Insert(array[i]);
                    }
                    Console.WriteLine("Enter word to display");
                    string input = Console.ReadLine();
                    bool found = search.Search(input, search);
                    Console.WriteLine($"{input} found - " + found);
                    break;
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    Console.WriteLine("Enter some Words: ");
                    string words = Console.ReadLine();
                    string[] wordsArray = words.Split(" ");
                    insertionSort.InsertSort(wordsArray);
                    foreach (var item in wordsArray)
                    {
                        Console.Write(item + " ");
                    }
                    break;
                case 4:
                    BubbleSort bubbleSort = new BubbleSort();
                    List<int> numbers = new List<int>();
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Enter {i + 1} Number: ");
                        int num = int.Parse(Console.ReadLine());
                        numbers.Add(num);
                    }
                    bubbleSort.BubbleSortNumber(numbers);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        Console.WriteLine(numbers[i]);
                    }
                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
        }
    }
}
