using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FizzBuzz
{
    // write an iterator block that returns an IEnumerable of strings and accepts an int count of how many items tu return
    // the iterator block should return "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for multiples of both
    // the iterator block should return the numbers for all other values

    public class FizzBuzzGenerator
    {
        public static IEnumerable<string> Generate()
        {
            var i = 0;
            while (true) 
            
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    yield return "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    yield return "Fizz";
                }
                else if (i % 5 == 0)
                {
                    yield return "Buzz";
                }
                else
                {
                    yield return i.ToString();
                }
                i++;
            }
        }
        public static IEnumerable<string> Skip(IEnumerable<string> source, int count)
        {
            var i = 0;
            foreach (var item in source)
            {
                if (i >= count)
                {
                    yield return item;
                }
                i++;
            }
        }
        public static IEnumerable<string> Take(IEnumerable<string> source, int count)
        {
            var i = 0;
            foreach (var item in source)
            {
                if (i++ >= count)
                {
                    break;
                }
                else yield return item;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test the FizzBuzz generator
            var numbers = FizzBuzzGenerator.Take(FizzBuzzGenerator.Skip(FizzBuzzGenerator.Generate(), 5), 5);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
