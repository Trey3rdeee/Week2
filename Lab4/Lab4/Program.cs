using System;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            byte puddle = 100; 
            short pond = 29456; 
            int lake = 100000; //one hundred thousand 
            long ocean = 5;

            //lossless
            long lakeToOcean = lake;
            Console.WriteLine(lakeToOcean);

            //lossy
            byte pondToPuddle = (byte)pond;
            Console.WriteLine(pondToPuddle);

            //lossless
            long pondToOcean = pond;
            Console.WriteLine(pondToOcean);

            //lossless
            int oceanToLake = lake;
            Console.WriteLine(oceanToLake);

        }
    }
}


/*1. Cast the value of lake into ocean and display it 
2. Cast the value of pond into puddle and display it 
3. Cast the value of pond into ocean and display it 
4. Cast the value of ocean into lake and display it */