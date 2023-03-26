using System;
using System.Linq;

class Programm
{
    static void Main()
    {
        int days,
            curr_morning, curr_evening,
            prev_morning, prev_evening;
        int result = 0;

        days = Convert.ToInt32(Console.ReadLine());

        int[,] aq = new int[days, 2];
        string[] temp;

        for (int d = 0; d < days; d++)
        {
            temp = Console.ReadLine().Split(" ");
            aq[d, 0] = Convert.ToInt32(temp[0]);
            aq[d, 1] = Convert.ToInt32(temp[1]);
        }

        for (int i = 1; i < days; i++)
        {
            prev_morning = aq[i - 1, 0];
            prev_evening = aq[i - 1, 1];
            curr_morning = aq[i, 0];
            curr_evening = aq[i, 1];
            if (
                curr_morning > prev_morning &&
                curr_evening > prev_evening
            )
            {
                result = result + 1;
            }
        }

        Console.Write($"{result}\n");
    }
}
