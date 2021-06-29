using System;

namespace ArrayCounter
{
    public static class ArraySum
    {
        public static void Main()
        {
            var numbers = new[] {Console.ReadLine()};
                Console.WriteLine(SumNumbers(numbers));
        }

        public static int SumNumbers(string[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                foreach (var symbol in number)
                {
                    if (char.IsDigit(symbol)) sum += int.Parse(symbol.ToString());
                }
            }

            return sum;
        }
    }
}