using System;
using System.Text.RegularExpressions;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter a String");
           var String = Console.ReadLine();
           Console.WriteLine("Enter a word to search");
           var search = Console.ReadLine();
           var count = Regex.Matches(String, search).Count;
           Console.WriteLine($"Word found { count } times in the string");        }
    }
}