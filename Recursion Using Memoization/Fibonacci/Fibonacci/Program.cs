namespace Fibonacci
{
    public class Program
    {
        // ginamitan ko ng memoization para hindi malakas sa memory, at para ma-speedup naden yung program

        private Dictionary<long, int> memo = new Dictionary<long, int>();

        public int Fib(int n)
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
            Program memoizedFibonacci = new Program();
            Console.WriteLine($"{memoizedFibonacci.Fib(8)}");

            /*
             Fn=Fn−1+Fn−2
             F8=F7+F6
             F8 = 13 + 8

             F8 = 21
             */
        }
    }
}
