using System;

// 15 9
// 6
// 3
// 12
// 11
// 4
// 5
// 8
// 15
// 14

class Programm
{
    static void Main()
    {
        int N, M, post, next_zero, counter = 0, index = 0;
        string buffer;
        string[] buffer_splitted;
        buffer = Console.ReadLine();
        buffer_splitted = buffer.Split(" ");

        N = Convert.ToInt32(buffer_splitted[0]);
        M = Convert.ToInt32(buffer_splitted[1]);

        int[] posts = new int[N + 2];

        Array.Fill(posts, 0);

        for (int i = 1; i <= M; i++)
        {
            buffer = Console.ReadLine();
            post = Convert.ToInt32(buffer);
            posts[post] = 1;
        }

        while (index < N)
        {
            next_zero = Array.IndexOf(posts, 0, index + 1);

            if (next_zero - index > 2)
            {
                counter++;
            }

            index = next_zero;
        }

        Console.Write($"{counter}\n");
    }
}
