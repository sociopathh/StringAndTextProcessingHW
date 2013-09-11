//Task 19: Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.


using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;


class ExtractingDate
{
    static void Main()
    {
        var text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";

        var dates = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < dates.Length; i++)
        {
            if (Regex.IsMatch(dates[i], @"\b\d{1,2}\.\d{1,2}.\d{4}"))
            {
                if (Regex.IsMatch(dates[i], @"..$"))
                {
                    dates[i] = dates[i].Remove(dates[i].Length - 1);
                }

                DateTime date = DateTime.ParseExact(dates[i], "d.M.yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(date.ToString(new CultureInfo("en-Ca")));
            }
        }

    }
}