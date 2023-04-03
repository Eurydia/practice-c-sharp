// 8
// 11811886
// 13977931
// 64719635
// 88922988
// 68874786
// 33842127
// 37895247
// 56362263

class Program
{

    static bool isMirror(string s)
    {
        for (int i = 0; i < (s.Length / 2); i++)
        {
            if (s[i] != s[s.Length])
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

            if (curr_number[0] == '1' && isMirror(curr_number.Substring(1)))
            {
                Console.Write($"{curr_number}\n");
            }
            else if (isMirror(curr_number.Substring(2)))
            {
                Console.Write($"{curr_number}\n");
            }
        }
    }
}