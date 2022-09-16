using System;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite season?");
            string favSeason = Console.ReadLine();
            Console.WriteLine("Awesome! Now what's your favorite car?");
            string favCar = Console.ReadLine();
            Console.WriteLine("I like that one too! What's your favorite TV show?");
            string favShow = Console.ReadLine();
            Console.WriteLine("I haven't seen that yet. How much did you spend on streaming services last year?");
            string moneySpent = Console.ReadLine();
            int dollarAmount = int.Parse(moneySpent);
            Console.WriteLine("So your favorite season is {0}, your favorite car is {1}, and your favorite show is {2}, " +
                "but you only paid {3:C0} for streaming last year?!", favSeason, favCar, favShow, dollarAmount );

            {

            }

        }
    }
}
