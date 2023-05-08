using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int i;
        string buffer;
        string[] splitted_buffer;

        int N, tempA;

        buffer = Console.ReadLine();
        N = Convert.ToInt32(buffer);

        int[] employees = new int[N];


        for (i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            splitted_buffer = buffer.Split(" ");

            tempA = Convert.ToInt32(splitted_buffer[0]);

            employees[i] = tempA;
        }

        int[] result = new int[N];
        int resultCounter = 0;


        for (i = 0; i < N; i++)
        {
            if (!result.Contains(employees[i]))
            {
                result[resultCounter] = employees[i];
                resultCounter++;
            }
        }

        Console.Write($"{resultCounter}\n");
    }
}
