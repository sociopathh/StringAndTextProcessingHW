//Task 13: Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".


using System;
using System.Text;

class WordOrderReverse
{
    static void Main(string[] args)
    {
        string Text = Console.ReadLine();
        char[] symbols = { '.', ' '};
        string[] NewText = Text.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
       
        for (int i = NewText.Length - 1; i >= 0; i--)
        {
            if (i != 0)
                Console.Write(NewText[i] + " ");
            else Console.WriteLine(NewText[i]);
        }
    }
}