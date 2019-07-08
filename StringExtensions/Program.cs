using System;

namespace StringExtensions
{
    class Program
    {
        static void Main(string[] args)
        {


            string testString = "Test string.";
            
            Console.WriteLine(testString.Reverse());

            Console.WriteLine(StringExtensions.Repeat(testString, 3));
            Console.WriteLine(testString.Repeat(3));

        }
    }
}
