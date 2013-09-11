//Task 16: Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 

using System;
using System.Globalization;

class DaysBetweenDates
{
    static DateTime ParseDate(string dateAsString)
    {
        DateTime date = DateTime.ParseExact(dateAsString, "d.M.yyyy", CultureInfo.InvariantCulture);
        return date;
    }

    static void Main()
    {
        Console.WriteLine("Format for the dates is day.month.year (e.g. 01.01.2013)");

        try
        {
            Console.Write("Enter the first date: ");
            string input = Console.ReadLine();
            DateTime startDate = ParseDate(input);

            Console.Write("Enter the second date: ");
            input = Console.ReadLine();
            DateTime endDate = ParseDate(input);

            double resultDistance = (endDate - startDate).TotalDays;

            Console.WriteLine("Days between dates: {0} day/s/", resultDistance);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter the dates in the correct format 31.12.2012! Make sure that such a date exists!"); ;
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Please provide a date. The date cannot be null!");
        }
    }
}