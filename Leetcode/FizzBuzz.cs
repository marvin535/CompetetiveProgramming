using System;

public class Solution
{
	static IList<string> FizzBuzzFunction(int n)
	{
		IList<string> result = new List<string>();
		
		for (int i = 1; i <= n; i++)
		{
			if (i % 3 == 0 && i % 5 == 0)
			{
				result.Add("FizzBuzz");
			}
			else if (i % 3 == 0)
			{
				result.Add("Fizz");
			}
			else if (i % 5 == 0)
			{
				result.Add("Buzz");
			}
			else
			{
				result.Add(i.ToString());
			}
		}
		
		return result;
	}
	
	static void Main(string[] args)
	{
		int number = 100;
		IList<string> FizzBuzz = FizzBuzzFunction(number);
		
		foreach (var items in FizzBuzz)
		{
			Console.WriteLine(items);
		}
	}
}