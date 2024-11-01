/* You are tasked to create a Factorial calculator, make it recursive and also optimize it using Memoization */
using System;

public class Program
{
	private static Dictionary<long, int> memo = new Dictionary<long, int>();
	
	static int Fact(int n)
	{
		if (n <= 1)
		{
			return 1;
		}
		
		if (memo.ContainsKey(n))
		{
			return memo[n];
		}
		
		memo[n] = n * Factorial(n - 1);
		
		return memo[n];
	}
	
	static void Main(string[] args)
	{
		int Factorial = Fact(5);
		// 5 x 4 x 3 x 2 x 1 = 120
	}
}
