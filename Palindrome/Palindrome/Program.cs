using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();

        bool isPalindrome = Palindrome(input);
        Console.WriteLine(isPalindrome);
    }

    static bool Palindrome(string input)
    {
        string normalized = Regex.Replace(input, "[^a-zA-Z0-9]", "").ToLower();
        return normalized.SequenceEqual(normalized.Reverse());
    }
}

