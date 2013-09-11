//Task 06: Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.


using System;

class TwentyCharacterString
{
    static void Main()
    {
        Console.WriteLine("Enter a string smaller than 20 characters:");
        string text = Console.ReadLine();
        if (text.Length < 20)
        {
            int length = 20 - text.Length;
            string add = new string('*', length);
            text = text + add;
        }
        Console.WriteLine("New string: {0}", text);

    }
}