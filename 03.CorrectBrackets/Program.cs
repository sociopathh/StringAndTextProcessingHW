//Task 3: Write a program to check if in a given expression the brackets are put correctly. 
//Example of correct expression: ((a+b)/5-d). 
//Example of incorrect expression: )(a+b)).


using System;

class CorrectBrackets
{
    private static bool CheckBrackets(string input)
    {
        int count = 0;
        foreach (var bracket in input)
        {
            if ( bracket == '(')
            {
                count++;
            }
            else if (bracket == ')')
            {
                count--;
            }
            if (count < 0)
            {
                return false;
            }
        }
        if (count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        Console.Write("Enter the expression: ");
        string input = Console.ReadLine();
        bool result = CheckBrackets(input);
        if (result)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }
    }
}