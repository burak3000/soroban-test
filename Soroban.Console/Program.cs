namespace Soroban.Console
{
    using Soroban.Core;
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Soroban trainer!");
            Console.WriteLine("Enter digit number");
            int digitCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number count to be generated");
            int numberCountToBeGenerated = Convert.ToInt32(Console.ReadLine());

            NumberGenerator numberGenerator = new NumberGenerator();


            while (true)
            {
                var generatedNumbers = numberGenerator
                    .GenerateNDigitRandomNumbers(digitCount, numberCountToBeGenerated);
                int actualSum = 0;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("What is the sum of following numbers");
                generatedNumbers.ForEach(number =>
                {
                    Console.WriteLine(number);
                    actualSum += number;
                });
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter result");
                int userExpects = Convert.ToInt32(Console.ReadLine());
                if (actualSum == userExpects)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("True");
                    Console.WriteLine("-------------------------");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong! It should be {actualSum}");
                }
            }


        }
    }
}