class Program
{
    static void Main()
    {
        bool exists = false;
        int N, departure;
        string buffer, town;
        string[] splitted_buffer = new string[4];

        buffer = Console.ReadLine();
        N = Convert.ToInt32(buffer);

        for (int i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            splitted_buffer = buffer.Split(" ");

            town = splitted_buffer[0];
            departure = Convert.ToInt32(splitted_buffer[1]);

            if (town == "Szekszard" && departure == -1)
            {
                exists = true;

            }
        }
        if (exists)
        {
            Console.Write($"YES\n");
        }
        else
        {
            Console.Write($"NO\n");
        }
    }
}