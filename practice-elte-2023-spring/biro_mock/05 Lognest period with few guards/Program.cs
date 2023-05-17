namespace _05_Lognest_period_with_few_guards;
class Program
{

    static void algo(int[] data, int size)
    {
        int i;

        int maxStart = 0;
        int maxLength = 0;

        int currStart = 0;
        int currLength = 0;

        for (i = 0; i < size; i++)
        {
            if (data[i] < 2)
            {
                currLength++;

                if (currLength == 1)
                {
                    currStart = i;
                }
                if (currLength > maxLength)
                {
                    maxStart = currStart;
                    maxLength = currLength;
                }
            }
            else
            {
                currLength = 0;
            }
        }

        if (maxLength == 0)
        {
            Console.Write("0\n");
        }
        else
        {
            Console.Write($"{maxStart + 1} {maxStart + maxLength}\n");
        }
    }

    static void Main(string[] args)
    {
        int i, j, tempStart, tempEnd;
        string buffer;
        string[] bufferSplitted;

        int N, M;

        buffer = Console.ReadLine();
        bufferSplitted = buffer.Split(" ");

        M = Convert.ToInt32(bufferSplitted[0]);
        N = Convert.ToInt32(bufferSplitted[1]);

        int[] data = new int[M];

        for (i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            bufferSplitted = buffer.Split(" ");

            tempStart = Convert.ToInt32(bufferSplitted[0]);
            tempEnd = Convert.ToInt32(bufferSplitted[1]);

            for (j = (tempStart - 1); j < tempEnd; j++)
            {
                data[j]++;
            }
        }

        algo(data, M);

    }
}
