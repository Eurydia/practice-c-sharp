class Program
{
    static void Main()
    {
        int N, no_fish = -1;

        string buffer;

        buffer = Console.ReadLine();
        N = Convert.ToInt32(Console.ReadLine());

        int[] days = new int[N];

        for (int i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            days[i] = Convert.ToInt32(buffer);
        }

        for (int i = 0; i < N; i++)
        {
            if (days[i] == 0)
            {
                no_fish = i + 1;
            }
        }

        Console.Write($"{no_fish}\n");
    }
}