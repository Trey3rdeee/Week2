using System;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a noun.");
            string noun1 = Console.ReadLine();
            Console.WriteLine("One more noun please!");
            string noun2 = Console.ReadLine();
            Console.WriteLine("Now time for a proper noun.");
            string properNoun = Console.ReadLine();
            Console.WriteLine("We need an adjective now.");
            string adjective1 = Console.ReadLine();
            Console.WriteLine("Let's have another for good measure");
            string adjective2 = Console.ReadLine();
            Console.WriteLine("Let's get a verb in here.");
            string verb1 = Console.ReadLine();
            Console.WriteLine("Okay one more verb before we begin!");
            string verb2 = Console.ReadLine();

            Console.WriteLine("The {3} {1} was named {2}.They would sometimes {6}, but would always {5}. " +
                "One day, he saw a {4} {0}, which made them very happy", noun1, noun2, properNoun, adjective1, adjective2, verb1, verb2);

        }
    }
}
