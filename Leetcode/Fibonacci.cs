/* Write a recursive function to find the n-th number in the Fibonacci sequence. Optimize the solution by using memoization */

using System;

public class Program
{
	private static Dictionary<long, int> memo = new Dictionary<long, int>();

	static int Fib(int n)
	{
		if (n <= 1)
		{
			return n;
		}
		
		if (memo.ContainsKey(n))
		{
			return memo[n];
		}
		
		memo[n] = Fib(n - 1) + Fib(n - 2);
		
		return memo[n];
	}
	
	static void Main(string[] args)
	{
		int Fibonacci = Fib(8);
		/*
			f1=1,f2=1,f3=2,f4=3,f5=5,f6=8,f7=13,f8=21
		*/
	}
}