using System;
using System.Linq;

class Programm
{

    static void Main()
    {
        int days, result = 0;
        int prev_morning = 0, prev_evening = 0, curr_morning = 0, curr_evening = 0;
        string[] temp;

        days = Convert.ToInt32(Console.ReadLine());



        for (int d = 0; d < days; d++)
        {

            temp = Console.ReadLine().Split(" ");
            curr_morning = Convert.ToInt32(temp[0]);
            curr_evening = Convert.ToInt32(temp[1]);

            if (prev_morning == 0 && prev_evening == 0)
            {
                prev_morning = curr_morning;
                prev_evening = curr_evening;
                continue;
            }

            if (
                curr_morning > prev_morning &&
                curr_evening > prev_evening
            )
            {
                result = result + 1;
            }

            prev_morning = curr_morning;
            prev_evening = curr_evening;

        }

        Console.Write($"{result}\n");

    }
}
