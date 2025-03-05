using System.Runtime.CompilerServices;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new();
            fizzBuzz.function();
        }
    }
    public class FizzBuzz
    {
        int limit = 0;
        public FizzBuzz()
        {
            limit = int.Parse(Console.ReadLine());
        }

        public void function()
        {
            for (int i = 1; i <= limit; i++)
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

        }
    }
}