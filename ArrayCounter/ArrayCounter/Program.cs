using System;
using System.Collections.Generic;

namespace ArrayCounter
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()?.
                Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(SumNumbers(numbers));
        }

        public static int SumNumbers(string[] numbers)
        {
            var sum = 0;
            foreach (var num in numbers)
            {
               sum += Convert.ToInt32(num);
            }

            return sum;
        }
    }
}