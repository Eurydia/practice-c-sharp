class Program
{
    static bool isMirror(string s)
    {
        for (int i = 0; i < 3; i++)
        {
            if (s[i] != s[s.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {

        int N;
        string buffer, curr_number;

        buffer = Console.ReadLine();
        N = Convert.ToInt32(buffer);

        string[] numbers = new string[N];

        for (int i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            numbers[i] = buffer;
        }

        for (int i = 0; i < N; i++)
        {
            curr_number = numbers[i];

            if (isMirror(curr_number))
            {
                Console.Write($"{curr_number}\n");
            }

            if (isMirror(curr_number.Substring(2)))
            {
                Console.Write($"{curr_number}\n");
            }
        }
    }
}