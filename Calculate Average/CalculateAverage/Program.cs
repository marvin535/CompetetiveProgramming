using System;

namespace CalculateAverage
{
    public class Program
    {
        static void Main(string[] args)
        {
            IList<int> listOfAverage = [75, 85, 95, 65, 75, 85, 95, 75];
            double average = listOfAverage.Average();
            Console.WriteLine(average);
        }
    }
}
