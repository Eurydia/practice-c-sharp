using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        string buffer;
        string[] splitted_buffer;

        int N, i, notes, tempID, tempGen, counter = 0;

        buffer = Console.ReadLine();
        N = Convert.ToInt32(buffer);

        string[] companies = new string[N], candidates = new string[N];


        for (i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            companies[i] = buffer;
        }

        buffer = Console.ReadLine();
        notes = Convert.ToInt32(buffer);
        for (i = 0; i < notes; i++)
        {
            buffer = Console.ReadLine();
            splitted_buffer = buffer.Split(" ");

            tempID = Convert.ToInt32(splitted_buffer[0]);
            tempGen = Convert.ToInt32(splitted_buffer[1]);

            if (tempGen == 7)
            {
                candidates[counter] = companies[tempID - 1];
                counter++;
            }
        }
        buffer = Console.ReadLine();

        if (counter > 0)
        {
            Console.Write($"{counter}");
            for (i = 0; i < counter; i++)
            {
                Console.Write($" {candidates[i]}");
            }
            Console.Write("\n");
        }
        else
        {
            Console.Write("NONE\n");
        }
    }
}
