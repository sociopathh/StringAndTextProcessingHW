//Task 24: Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.


using System;

class SortingWords
{
    static void Main()
    {
        Console.WriteLine("Enter text here:");
        string str = Console.ReadLine();

        string[] words = str.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}