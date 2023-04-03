class Program
{
    static void Main()
    {
        int N, curr, spring = 0, summer = 0, autumn = 0, winter = 0;
        string buffer;
        buffer = Console.ReadLine();
        N = Convert.ToInt32(buffer);

        int[] birth_months = new int[N];
        for (int i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            birth_months[i] = Convert.ToInt32(buffer.Split(" ")[1]);
        }

        for (int i = 0; i < N; i++)
        {
            curr = birth_months[i];
            if (2 <= curr && curr <= 4)
            {
                spring += 1;
            }
            else if (5 <= curr && curr <= 7)
            {
                summer += 1;
            }
            else if (8 <= curr && curr <= 10)
            {
                autumn += 1;
            }
            else
            {
                winter += 1;
            }
        }

        Console.Write($"{spring} {summer} {autumn} {winter}\n");
    }
}
