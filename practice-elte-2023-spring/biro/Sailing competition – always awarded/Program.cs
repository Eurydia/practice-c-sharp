using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int i, j;
        string buffer;
        string[] splitted_buffer;

        int N, K, L, M;

        buffer = Console.ReadLine();
        splitted_buffer = buffer.Split(" ");

        N = Convert.ToInt32(splitted_buffer[0]);
        K = Convert.ToInt32(splitted_buffer[1]);
        L = Convert.ToInt32(splitted_buffer[2]);
        M = Convert.ToInt32(splitted_buffer[3]);

        int[,] rounds = new int[N, K];

        for (i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            splitted_buffer = buffer.Split(" ");
            for (j = 0; j < K; j++)
            {
                rounds[i, j] = Convert.ToInt32(splitted_buffer[j]);
            }
        }

        int[] participation = new int[M];
        int[] scores = new int[M];

        for (i = 0; i < N; i++)
        {
            for (j = 0; j < K; j++)
            {
                participation[rounds[i, j] - 1] += 1;
                if (j < L)
                {
                    scores[rounds[i, j] - 1] += K - j;
                }
            }
        }

        int[] valid_scores = new int[M];
        int valid_score_counter = 0;
        for (i = 0; i < M; i++)
        {
            if (participation[i] < N)
            {
                continue;
            }
            valid_scores[valid_score_counter] = scores[i];
            valid_score_counter++;
        }

        int[] sorted_valid_score = valid_scores;
        sorted_valid_score.Order();
        int target = sorted_valid_score[K - 1];


        int[] result = new int[M];
        int result_counter = 0;
        for (i = 0; i < valid_score_counter; i++)
        {
            if (valid_scores[i] < target)
            {
                result[result_counter] = i;
                result_counter++;
            }
        }

        Console.Write($"{result_counter}");
        for (i = 0; i < result_counter; i++)
        {
            Console.Write($" {result[i] + 1}");
        }
        Console.Write("\n");


    }
}
