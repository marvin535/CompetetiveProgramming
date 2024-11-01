using System;
using System.Text.RegularExpressions;

public class Program
{
	static bool IsPalindrome(string word)
	{
		string cleanedInput = Regex.Replace(word, "[^a-zA-Z0-9]", "").ToLower();
		
		char[] arrayOfCharacters = cleanedInput.ToCharArray();
		
		Array.Reverse(arrayOfCharacters);
		
		string reversed = new string(arrayOfCharacters);
		
		return cleanedInput == reversed;
	}
	
	static void Main(string[] args)
	{
		Console.Write("Enter a word to check if the given string is a palindrome or not: ");
		string? word = Console.ReadLine();
		
		if (IsPalindrome(word))
		{
			Console.WriteLine("{word} is a palindrome word!");
		}
		else
		{
			Console.WriteLine($"{word} is not a palindrome word!");
		}
	}
}