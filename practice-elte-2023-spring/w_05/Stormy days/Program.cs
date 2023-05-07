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
