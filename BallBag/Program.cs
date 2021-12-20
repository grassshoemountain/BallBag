using System;
using System.Collections.Generic;
using System.Linq;

namespace BallBag
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> test = new List<List<int>> { new List<int> { } };
            Console.WriteLine(test.Count);
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("test ends");
            //Static
            int NumberOfBalls = 10;
            int NumberOfBags = 3;

            // setup a Ball
            int[] balls = new int[NumberOfBalls];
            for (int i = 0; i < NumberOfBalls; i++)
            {
                balls[i] = i + 1;
            }
            // setup a Bag representation Bags
            int[][] bags = new int[NumberOfBags][];
            for (int i = 0; i < NumberOfBags; i++)
            {
                bags[i] = new int[NumberOfBags];
                bags[i][i] = 1;
            }

            // setup a throw configuration: list of list
            List<List<int>> throws = new List<List<int>> { new List<int> { } };

            // calculate all possibilities
            for (int i = 0; i < NumberOfBalls; i++)
            {
                throws = ThrowBall(throws, bags, NumberOfBags, balls[i]);
            }

            int c = 1;
            foreach (List<int> t in throws)
            {
                Console.WriteLine($"Configuration {c}:");
                t.ForEach(Console.Write);
                Console.Write("\n");
                c++;
            }

            Console.ReadKey();
        }

        public static List<List<int>> ThrowBall(List<List<int>> currentThrows, int[][] bags, int NumberOfBags, int BallWeight)
        {
            List<List<int>> newThrows = new List<List<int>>();

            foreach (var oneThrow in currentThrows)
            {
                for (int b = 0; b < NumberOfBags; b++)
                {
                    List<int> q = new List<int>();

                    // clone latest configuration
                    q.AddRange(oneThrow);

                    // add new possible bagging configuration
                    q.AddRange(bags[b].Select(x => x * BallWeight));

                    newThrows.Add(q);
                }
            }
            return newThrows;
        }

    }
}
