//Task 12: Write a program that parses an URL address given in the format:
//and extracts from it the [protocol], [server] and [resource] elements. For example from the URL
//http://www.devbg.org/forum/index.php the following information should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"


using System;
using System.Text.RegularExpressions;

class ParsingUrlProtocol
{
    static void Main()
    {
        Console.WriteLine("Enter internet page here:");  
        string urlProtocol = Console.ReadLine();

        var urlParts = Regex.Match(urlProtocol, "(.*)://(.*?)(/.*)").Groups;

        Console.WriteLine(urlParts[1]);
        Console.WriteLine(urlParts[2]);
        Console.WriteLine(urlParts[3]);
    }
}