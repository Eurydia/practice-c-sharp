// 7
// 11 10 1 12345
// 11 50 -2 10000
// 12 10 -1 12345
// 23 10 1 24680
// 23 11 -2 5000
// 23 15 1 13579
// 23 20 1 98765

class Program
{
    static void Main()
    {
        int N, mode, amount, total_dispensed = 0;
        string buffer;
        string[] splitted_buffer = new string[4];

        buffer = Console.ReadLine();
        N = Convert.ToInt32(buffer);


        for (int i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            splitted_buffer = buffer.Split(" ");

            mode = Convert.ToInt32(splitted_buffer[2]);
            amount = Convert.ToInt32(splitted_buffer[3]);


            if (mode == -2)
            {
                total_dispensed += amount;
            }
            else if (mode == 2)
            {
                total_dispensed -= amount;
            }

        }

        Console.Write($"{total_dispensed}\n");
    }
}