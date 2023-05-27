using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int i;

        string buffer;
        string[] bufferSplitted;

        int N, M, K;

        buffer = Console.ReadLine();
        bufferSplitted = buffer.Split(" ");

        N = Convert.ToInt32(bufferSplitted[0]);
        M = Convert.ToInt32(bufferSplitted[1]);
        K = Convert.ToInt32(bufferSplitted[2]);

        int[,] data = new int[N, 3];

        for (i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            bufferSplitted = buffer.Split(" ");

            data[i, 0] = Convert.ToInt32(bufferSplitted[0]);
            data[i, 1] = Convert.ToInt32(bufferSplitted[1]);
            data[i, 2] = Convert.ToInt32(bufferSplitted[2]);
        }

        // TASK A)
        int cheapestFactoryId = data[0, 0];
        int cheapestCandyId = data[0, 1];
        int cheapestCandyPrice = data[0, 2];
        for (i = 1; i < N; i++)
        {
            if (data[i, 2] < cheapestCandyPrice)
            {
                cheapestFactoryId = data[i, 0];
                cheapestCandyId = data[i, 1];
                cheapestCandyPrice = data[i, 2];
            }
        }
        Console.Write($"{cheapestFactoryId} {cheapestCandyId}\n");


        // TASK B)
        int[] candyProductCounter = new int[M];
        for (i = 0; i < N; i++)
        {
            candyProductCounter[data[i, 0] - 1] += 1;
        }
        int mostCandyFactoryId = 0;
        for (i = 1; i < M; i++)
        {
            if (candyProductCounter[i] > candyProductCounter[mostCandyFactoryId])
            {
                mostCandyFactoryId = i;
            }
        }
        Console.Write($"{mostCandyFactoryId + 1}\n");

        // TASK C)
        int uniqueFactories = 0;
        int[] uniqueFactorySeen = new int[M];
        for (i = 0; i < N; i++)
        {
            if (uniqueFactorySeen[data[i, 0] - 1] == 0)
            {
                uniqueFactories++;
                uniqueFactorySeen[data[i, 0] - 1] = data[i, 2];
            }
        }
        for (i = 0; i < N; i++)
        {
            if (data[i, 2] > uniqueFactorySeen[data[i, 0] - 1])
            {
                uniqueFactorySeen[data[i, 0] - 1] = data[i, 2];
            }
        }
        Console.Write($"{uniqueFactories}");
        for (i = 0; i < M; i++)
        {
            if (uniqueFactorySeen[i] == 0)
            {
                continue;
            }
            Console.Write($" {i + 1}");
            Console.Write($" {uniqueFactorySeen[i]}");
        }
        Console.Write("\n");


        // TASK D)
        int uniqueCandies = 0;
        int[] uniqueCandySeen = new int[K];
        for (i = 0; i < N; i++)
        {
            if (uniqueCandySeen[data[i, 1] - 1] == 0)
            {
                uniqueCandySeen[data[i, 1] - 1] = 1;
                uniqueCandies++;
            }
        }
        Console.Write($"{uniqueCandies}\n");

        // TASK E)
        int[] candyProducedBy = new int[K];
        for (i = 0; i < N; i++)
        {
            candyProducedBy[data[i, 1] - 1]++;
        }
        int exclusiveCandies = 0;
        for (i = 0; i < K; i++)
        {
            if (candyProducedBy[i] == 1)
            {
                exclusiveCandies++;
            }
        }
        Console.Write($"{exclusiveCandies}");
        for (i = 0; i < K; i++)
        {
            if (candyProducedBy[i] == 1)
            {
                Console.Write($" {i + 1}");
            }
        }

    }
}
