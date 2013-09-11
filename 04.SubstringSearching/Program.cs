//Task 4: Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//Example: The target substring is "in". The text is as follows: 
//"We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."
//The result is 9.


using System;

class SubstringSearching
{
    public static int CountSubstring(string text, string subtr)
    {
        int count = 0;
        text = text.ToLower();
        while (text.IndexOf(subtr) != -1)
        {
            int pos = text.LastIndexOf(subtr);
            if (text.Substring(pos, subtr.Length) != "")
            {
                count++;
                text = text.Remove(pos);
            }
        }
        return count;
    }

    static void Main()
    {
        Console.WriteLine("Enter text below: \n");
        string text = Console.ReadLine();
        Console.WriteLine("Enter substring: \n");
        string substring = Console.ReadLine();
        Console.WriteLine(CountSubstring(text, substring));
    }
}