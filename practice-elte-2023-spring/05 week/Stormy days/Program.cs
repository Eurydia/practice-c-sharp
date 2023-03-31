// Stormy days

// The organizers of a sailing competition measured the speed of wind for N days at Balaton-
// füred. A sailing competition should not be held in smooth winds, nor in stormy winds. In
// a storm, the speed of wind is more than 100 km/h. There is only one round each day of the
// competition, and there are K rounds.
// Write a program that counts how many days the wind was stormy.

// 10 3
// 50
// 40
// 0
// 5
// 0
// 80
// 70
// 90
// 100
// 120

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int N, counter = 0;
        string buffer;
        buffer = Console.ReadLine();
        N = Convert.ToInt32(buffer.Split(" ")[0]);

        int[] wind_speeds = new int[N];
        for (int i = 0; i < N; i++)
        {
            wind_speeds[i] = Convert.ToInt32(Console.ReadLine());
        }


        for (int i = 0; i < N; i++)
        {
            if (wind_speeds[i] > 100)
            {
                counter += 1;
            }
        }

        Console.Write($"{counter}\n");
    }
}
