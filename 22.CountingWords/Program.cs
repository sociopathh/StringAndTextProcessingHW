﻿//Task 22: Write a program that reads a string from the console and lists all different words
//in the string along with information how many times each word is found.


using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class CountingWords
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string str = Console.ReadLine();

        var dict = new Dictionary<string, int>();

        foreach (Match word in Regex.Matches(str, @"\w+"))
            dict[word.Value] = dict.ContainsKey(word.Value) ? dict[word.Value] + 1 : 1;

        foreach (var pair in dict)
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
    }
}