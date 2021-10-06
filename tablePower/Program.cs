using System;

namespace tablePower
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Range("Welcome to the Table of Powers\n\nEnter a number from 1 to 129: ");
        }

        public static void Range(string prompt)
        {
            bool checking = true;
            int number = 0;

            Console.WriteLine(prompt);
            while (checking == true)

            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                }

                if (number >= 1 && number <= 129)
                {
                    checking = false;
                }
                else
                {
                    checking = true;
                    Console.WriteLine("\nLets try this again only enter numbers between 1 to 129.");
                }
            }

            int x = 1;

            Console.WriteLine($"\nHere are your results for {number}\n ");
            Console.WriteLine("Number\tSqaure\tCube");
            Console.WriteLine("======\t======\t======");

            for (x = 1; x <= number; x++)
                Console.WriteLine(string.Format($"{x,6}\t{x * x,6}\t{x * x * x,6}"));

            Console.WriteLine("\nDo you want check another number? Yes or No");
            string answer = Console.ReadLine().ToLower();
            bool new1 = true;

            while (new1 == true)
            {
                if (answer == "yes")
                {
                    new1 = false;
                    Range("\nEnter another number: ");
                }
                else if (answer == "no")
                {
                    new1 = false;
                    Console.WriteLine("\nHave a great day!");
                }
                else
                {
                    new1 = true;
                    Console.WriteLine("Please enter only yes or no: ");
                    answer = Console.ReadLine();
                }
            }
        }
    }
}