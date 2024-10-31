using System;
using System.Text.RegularExpressions;

namespace PalindromeChecker
{
    public class Program
    {
        static bool IsPalindrome(string word)
        {
            string cleanedInput = Regex.Replace(word, "[^a-zA-Z0-9]", "").ToLower();
            char[] arrayOfChars = cleanedInput.ToCharArray();
            Array.Reverse(arrayOfChars);
            string reversed = new string(arrayOfChars);

            return cleanedInput == reversed;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to see if the given word is a palindrome: ");
            string? word = Console.ReadLine();

            if (IsPalindrome(word ?? "Unknown??"))
            {
                Console.WriteLine($"{word} is a palindrome word!");
            }
            else
            {
                Console.WriteLine($"{word} is not a palindrome word!");
            }
        }
    }
}
