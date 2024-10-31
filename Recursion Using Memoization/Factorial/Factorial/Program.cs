using System;

namespace Factorial
{
    public class Program
    {
        // ginamitan ko ng memoization para hindi malakas sa memory, at para ma-speedup naden yung program
        private Dictionary<long, int> memo = new Dictionary<long, int>();

        public int Fact(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            memo[n] = n * Fact(n - 1);

            return memo[n];
        }

        static void Main(string[] args)
        {
            Program memoizedFactorial = new Program();
            Console.WriteLine($"{memoizedFactorial.Fact(5)}");

            // 5 x 4 x 3 x 2 x 1 = 120
        }
    }
}
