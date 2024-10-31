namespace FizzBuzz
{
    public class Program
    {
        static IList<string> FizzBuzzGenerator(int n)
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
            int n = 100;
            IList<string> value = FizzBuzzGenerator(n);

            foreach (var items in value)
            {
                Console.WriteLine($"{items} ");
            }
        }
    }
}
