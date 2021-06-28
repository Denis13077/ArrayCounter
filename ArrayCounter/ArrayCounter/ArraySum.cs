using System;

namespace ArrayCounter
{
    public static class ArraySum
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()?.
                Split((char) StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(SumNumbers(numbers));
        }

        public static int SumNumbers(string[] numbers)
        {
            var sum = 0;
            foreach (var num in numbers)
            {
                var succes = int.TryParse(num, out var number);
                if (succes) sum += number;
            }

            return sum;
        }
    }
}