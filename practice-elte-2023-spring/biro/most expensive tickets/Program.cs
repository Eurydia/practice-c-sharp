using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int N, i, counter = 0;
        string buffer;
        string[] splitted_buffer;

        buffer = Console.ReadLine();
        N = Convert.ToInt32(buffer);

        int[] distances = new int[N];
        int[] prices = new int[N];
        int[] result = new int[N];

        for (i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            splitted_buffer = buffer.Split(" ");

            distances[i] = Convert.ToInt32(splitted_buffer[0]);
            prices[i] = Convert.ToInt32(splitted_buffer[1]);
        }

        for (i = 0; i < N; i++)
        {
            if ((float)prices[i] / (float)distances[i] > 100.0)
            {
                result[counter] = i + 1;
                counter++;
            }
        }

        Console.Write($"{counter}");
        for (i = 0; i < counter; i++)
        {
            Console.Write($" {result[i]}");
        }
        Console.Write($"\n");
    }
}
