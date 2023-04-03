// 5
// 5 0
// 3 4
// 0 4
// 2 0
// 0 2
struct Data
{
    public int start { get; }
    public int end { get; }

    public Data(int s, int e)
    {
        start = s;
        end = e;
    }

}

class Program
{
    static void Main()
    {
        int N, s, e, max_passengers = 0, current_passengers = 0;
        string buffer;
        string[] splitted_buffer = new string[2];

        buffer = Console.ReadLine();
        N = Convert.ToInt32(buffer);

        Data[] l_data = new Data[N];

        for (int i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();

            splitted_buffer = buffer.Split(" ");
            s = Convert.ToInt32(splitted_buffer[0]);
            e = Convert.ToInt32(splitted_buffer[1]);

            l_data[i] = new Data(s, e);
        }

        for (int i = 0; i < N; i++)
        {
            current_passengers += l_data[i].start - l_data[i].end;

            if (current_passengers > max_passengers)
            {
                max_passengers = current_passengers;
            }

        }

        Console.Write($"{max_passengers}\n");

    }
}