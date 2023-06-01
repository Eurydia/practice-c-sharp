using System;
using System.Linq;

class Program
{

    static void SolveTaskA(int weekCount, int[,] rainAmount)
    {
        int i, j, rainSum;
        string result = "";

        for (i = 0; i < weekCount; i++)
        {
            rainSum = 0;
            for (j = 0; j < 7; j++)
            {
                rainSum += rainAmount[i, j];
            }
            result = $"{result}{rainSum} ";
        }
        Console.Write($"{result}\n");
    }

    static void SolveTaskB(int weekCount, int[,] rainAmount)
    {
        int i, j;

        int[] rainSums = new int[weekCount];
        for (i = 0; i < weekCount; i++)
        {
            for (j = 0; j < 7; j++)
            {
                rainSums[i] = rainAmount[i, j];
            }
        }
        int mostRain = rainSums[0];
        int mostRainIndex = 1;
        for (i = 1; i < weekCount; i++)
        {
            if (rainSums[i] > mostRain)
            {
                mostRainIndex = i + 1;
                mostRain = rainSums[i];
            }
        }
        Console.Write($"{mostRainIndex}\n");
    }

    static void SolveTaskC(int weekCount, int[,] rainAmount)
    {
        int i, j;

        int increaseRainCount = 0;
        int[] increaseRainWeeks = new int[weekCount];

        for (i = 0; i < weekCount; i++)
        {
            for (j = 0; j < 6; j++)
            {
                if (rainAmount[i, j] > rainAmount[i, j + 1])
                {
                    break;
                }
            }
            if (j == 6)
            {
                increaseRainWeeks[increaseRainCount] = i + 1;
                increaseRainCount++;
            }
        }
        Console.Write($"{increaseRainCount}");
        for (i = 0; i < increaseRainCount; i++)
        {
            Console.Write($" {increaseRainWeeks[i]}");
        }
        Console.Write("\n");
    }

    static void SolveTaskD(int weekCount, int[,] rainAmount)
    {
        int i, j;

        int[] rainSums = new int[weekCount];
        for (i = 0; i < weekCount; i++)
        {
            for (j = 0; j < 7; j++)
            {
                rainSums[i] = rainAmount[i, j];
            }
        }
        int leastRain = rainSums[0];
        int leastRainIndex = 1;
        for (i = 1; i < weekCount / 2; i++)
        {
            if (rainSums[i] < leastRain)
            {
                leastRainIndex = i + 1;
                leastRain = rainSums[i];
            }
        }
        Console.Write($"{leastRainIndex}\n");
    }

    static void SolveTaskE(int weekCount, int[,] rainAmount)
    {
        int i, j;

        int[] rainSums = new int[weekCount];
        for (i = 0; i < weekCount; i++)
        {
            for (j = 0; j < 7; j++)
            {
                rainSums[i] = rainAmount[i, j];
            }
        }

        int periodLength = 0;

        int periodStartLongest = 0;
        int periodLengthLongest = 0;

        for (i = 0; i < weekCount; i++)
        {
            if (rainSums[i] > 10)
            {
                continue;
            }
            periodLength = 0;
            for (j = i; j < weekCount; j++)
            {
                periodLength++;
                if (periodLength > periodLengthLongest)
                {
                    periodLengthLongest = periodLength;
                    periodStartLongest = i + 1;
                }
            }
        }

        if (periodStartLongest == 0)
        {
            Console.Write("0\n");
        }
        else
        {
            Console.WriteLine($"{periodStartLongest} {periodStartLongest + periodLengthLongest - 1}\n");
        }
    }


    static void Main(string[] args)
    {
        int i, j;
        string buffer;
        string[] bufferSplitted;

        int N;

        buffer = Console.ReadLine();
        N = Convert.ToInt32(buffer);

        int[,] rainAmounts = new int[N, 7];
        for (i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            bufferSplitted = buffer.Split(" ");
            for (j = 0; j < 7; j++)
            {
                rainAmounts[i, j] = Convert.ToInt32(bufferSplitted[j]);
            }
        }

        SolveTaskA(N, rainAmounts);
        SolveTaskB(N, rainAmounts);
        SolveTaskC(N, rainAmounts);
        SolveTaskD(N, rainAmounts);
        SolveTaskE(N, rainAmounts);

    }
}
