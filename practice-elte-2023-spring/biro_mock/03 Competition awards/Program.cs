using System;
using System.Linq;




class Program
{
    static void print(int[] indexes, string[] names, int size)
    {
        int i;
        Console.Write($"{size};");
        for (i = 0; i < size; i++)
        {
            Console.Write($"{names[indexes[i]]};");
        }
        Console.Write("\n");
    }


    static void Main(string[] args)
    {
        int i;
        double rating;
        string buffer;
        string[] splitted_buffer;

        int N, scoreMax;

        buffer = Console.ReadLine();
        splitted_buffer = buffer.Split(" ");

        N = Convert.ToInt32(splitted_buffer[0]);
        scoreMax = Convert.ToInt32(splitted_buffer[1]);

        int[] scores = new int[N];
        string[] names = new string[N];

        int g_counter = 0, s_counter = 0, b_counter = 0, n_counter = 0;
        int[] golds = new int[N];
        int[] silvers = new int[N];
        int[] bronzes = new int[N];
        int[] no_award = new int[N];

        for (i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            splitted_buffer = buffer.Split(";");
            names[i] = splitted_buffer[0];
            scores[i] = Convert.ToInt32(splitted_buffer[1]);
        }


        for (i = 0; i < N; i++)
        {
            rating = (double)scores[i] / scoreMax;
            if ((rating) >= 0.9)
            {
                golds[g_counter] = i;
                g_counter++;
            }
            else if (rating >= 0.8)
            {
                silvers[s_counter] = i;
                s_counter++;
            }
            else if (rating >= 0.7)
            {
                bronzes[b_counter] = i;
                b_counter++;
            }
            else
            {
                no_award[n_counter] = i;
                n_counter++;
            }
        }

        print(golds, names, g_counter);
        print(silvers, names, s_counter);
        print(bronzes, names, b_counter);
        print(no_award, names, n_counter);
    }
}
