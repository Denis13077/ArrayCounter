using System;

namespace ArrayCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()?.
                Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(SumNumbers(numbers));
        }

        private static string SumNumbers(string[] numbers)
        {
            var sum = 0;
            foreach (var num in numbers)
            {
               sum += Convert.ToInt32(num);
            }

            return sum.ToString();
        }
    }
}