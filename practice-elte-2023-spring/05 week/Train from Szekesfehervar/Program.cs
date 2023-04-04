class Program
{
    static void Main()
    {
        int N, arrival, departure, min_departure = -1;

        string buffer, town;
        string[] splitted_buffer = new string[3];

        buffer = Console.ReadLine();
        N = Convert.ToInt32(buffer);

        for (int i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            splitted_buffer = buffer.Split(" ");

            town = splitted_buffer[0];
            arrival = Convert.ToInt32(splitted_buffer[1]);
            departure = Convert.ToInt32(splitted_buffer[2]);

            if (town == "Szekesfehervar" && arrival == -1)
            {
                min_departure = departure;
            }
        }

        Console.Write($"{min_departure}\n");
    }
}