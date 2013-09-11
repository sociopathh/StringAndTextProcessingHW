//Task 10: Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

using System;

class ConvertingUnicode
{
    static void Main()
    {
        Console.WriteLine("Enter some text:");
        string str = Console.ReadLine();

        foreach (var symbol in str)
        {
            Console.Write("\\u{0:X4}", (int)symbol);
        }
        Console.WriteLine();
    }
}