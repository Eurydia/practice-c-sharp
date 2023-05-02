using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string buffer;
        string[] splitted_buffer;
        int N, i;

        buffer = Console.ReadLine();
        N = Convert.ToInt32(buffer);

        string[] predators = new string[N];
        string[] prey = new string[N];

        for (i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            splitted_buffer = buffer.Split(" ");

            predators[i] = splitted_buffer[0];
            prey[i] = splitted_buffer[1];
        }
        int carnivoreCounter = 0;
        string[] carnivores = new string[N];

        for (i = 0; i < N; i++)
        {
            if (predators.Contains(prey[i])
            && !(carnivores.Contains(predators[i])))
            {
                carnivores[carnivoreCounter] = predators[i];
                carnivoreCounter++;
            }
        }

        Console.Write($"{carnivoreCounter}\n");
        if (carnivoreCounter > 0)
        {
            for (i = 0; i < carnivoreCounter; i++)
            {
                Console.Write($"{carnivores[i]}\n");
            }
        }
    }
}
