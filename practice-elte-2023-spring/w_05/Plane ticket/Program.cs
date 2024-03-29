﻿public struct Ticket
{
    public int distance;
    public int price;
    public Ticket(int d, int p)
    {
        this.distance = d;
        this.price = p;
    }
}

class Program
{
    static void Main()
    {
        int N, p, d;
        string buffer;
        string[] splitted_buffer = new string[2];

        N = Convert.ToInt32(Console.ReadLine());

        Ticket[] tickets = new Ticket[N];
        Ticket result;
        for (int i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            splitted_buffer = buffer.Split(" ");

            d = Convert.ToInt32(splitted_buffer[0]);
            p = Convert.ToInt32(splitted_buffer[1]);

            tickets[i] = new Ticket(d, p);
        }

        result = tickets[0];

        for (int i = 1; i < N; i++)
        {
            if (tickets[i].distance > result.distance)
            {
                result = tickets[i];
            }

            if (tickets[i].distance == result.distance && tickets[i].price < result.price)
            {
                result = tickets[i];
            }
        }

        Console.Write($"{result.price}\n");
    }
}