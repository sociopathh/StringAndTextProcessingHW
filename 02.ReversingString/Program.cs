//Task 2:Write a program that reads a string, reverses it and prints the result at the console. Example: "sample"  "elpmas".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class ReversingString
{
    static void Main()
    {
        Console.Write("Enter string = ");
        string text = Console.ReadLine();
        string reversed = ReverseText(text);
        Console.WriteLine(reversed);
    }

    static string ReverseText(string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = text.Length - 1; i >= 0; i--)
            sb.Append(text[i]);
        return sb.ToString();
    }
}
