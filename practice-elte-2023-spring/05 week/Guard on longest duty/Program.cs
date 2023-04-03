struct Guard
{
    public int start { get; }
    public int end { get; }

    public Guard(int s, int e)
    {
        start = s;
        end = e;
    }

}

class Program
{
    static void Main()
    {
        int N, s, e, result;
        string buffer;
        string[] splitted_buffer = new string[2];

        buffer = Console.ReadLine();

        splitted_buffer = buffer.Split(" ");
        N = Convert.ToInt32(splitted_buffer[1]);

        Guard[] guards = new Guard[N];

        for (int i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();

            splitted_buffer = buffer.Split(" ");
            s = Convert.ToInt32(splitted_buffer[0]);
            e = Convert.ToInt32(splitted_buffer[1]);

            guards[i] = new Guard(s, e);
        }

        result = guards[0].end - guards[0].start + 1;

        for (int i = 1; i < N; i++)
        {
            if (result < (guards[i].end - guards[i].start + 1))
            {
                result = guards[i].end - guards[i].start + 1;
            }
        }

        Console.Write($"{result}\n");

    }
}