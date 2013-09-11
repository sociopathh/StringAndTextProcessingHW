﻿//Task 25: Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
/*Example: <html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skillful .NET software engineers.</p></body>
</html> */



using System;
using System.Text.RegularExpressions;

class HTMLExtracting
{
    static void Main()
    {
        string str = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body></html>";

        foreach (Match text in Regex.Matches(str, "(?<=>).*?(?=<)"))
            if (!String.IsNullOrWhiteSpace(text.Value)) Console.WriteLine(text);
    }
}