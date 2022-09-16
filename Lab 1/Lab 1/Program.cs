using System;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello";
            int num = 1;
            float precise = 1.1F;
            bool maybe = false;
            char letter = 'A';
            string word2 = "World";
            int num2 = 15;
            float extraprecise = 1.15F;
            bool forsure = true;
            char secondletter = 'C';

            Console.WriteLine("{0} {1}!", word, word2);
            Console.WriteLine("These are ints {0}, {1} ", num, num2);
            Console.WriteLine("maybe is {0} but forsure is {1}", maybe, forsure);
            Console.WriteLine("Now these numbers have some precision {0}, {1}", precise, extraprecise);
            Console.WriteLine("Hey look, it's a letter! {0}. And now we get a second bonus letter, oh boy! {1}", letter, secondletter);

        }
    }
}
