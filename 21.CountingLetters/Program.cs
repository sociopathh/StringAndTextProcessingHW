//Task 21: Write a program that reads a string from the console and prints all different letters in the string 
//along with information how many times each letter is found.

using System;

class CountingLetters
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string str = Console.ReadLine();

        int[] chars = new int['z' - 'a' + 1];

        foreach (char c in str.ToLower())
            if ('a' <= c && c <= 'z') chars[c - 'a']++;

        for (int i = 0; i < chars.Length; i++)
            if (chars[i] != 0) Console.WriteLine("{0}: {1}", (char)(i + 'a'), chars[i]);
    }
}