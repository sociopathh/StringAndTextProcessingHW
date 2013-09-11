//Task 23: Write a program that reads a string from the console and replaces all series of consecutive identical letters 
//with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".


using System;
using System.Text.RegularExpressions;

class RepeatingLetters
{
    static void Main()
    {
        Console.WriteLine("Enter text here:");
        string str = Console.ReadLine();

        Console.WriteLine(Regex.Replace(str, @"(\w)\1+", "$1"));
    }
}