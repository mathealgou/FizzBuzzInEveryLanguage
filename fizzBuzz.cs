//write fizzbuzz in csharp

using System;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)

        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}