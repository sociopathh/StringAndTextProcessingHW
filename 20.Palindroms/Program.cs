﻿//Task 20: Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Palindromes
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
        string[] splitted = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);


        foreach (string word in splitted)
        {
            bool isPalindrome = true;
            for (int j = 0; j < (word.Length / 2); j++)
            {
                if (word[j] != word[word.Length - 1 - j])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome && word.Length > 1)
            {
                Console.WriteLine(word);
            }
        }
    }
}