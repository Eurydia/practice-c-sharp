using System;
using System.Linq;

struct Data
{
    public string name;
    public int mon;
    public int day;

    public Data(string n, int m, int d)
    {
        day = d;
        mon = m;
        name = n;
    }

}
class Program
{
    static void Main(string[] args)
    {
        int i;
        string buffer, temp_name;
        string[] splitted_buffer;


        string task_a_name;

        int N;

        buffer = Console.ReadLine();
        task_a_name = buffer;

        buffer = Console.ReadLine();
        N = Convert.ToInt32(buffer);


        Data[] data = new Data[N];

        for (i = 0; i < N; i++)
        {
            buffer = Console.ReadLine();
            temp_name = buffer;

            buffer = Console.ReadLine();
            splitted_buffer = buffer.Split(" ");

            data[i] = new Data(
                temp_name,
                Convert.ToInt32(splitted_buffer[0]),
                Convert.ToInt32(splitted_buffer[1])
            );

        }

        // task a)
        int a_counter = 0;
        Data[] a_res = new Data[N];
        for (i = 0; i < N; i++)
        {
            if (data[i].name == task_a_name)
            {
                a_res[a_counter] = data[i];
                a_counter++;
            }
        }
        Console.Write($"{a_counter}");
        for (i = 0; i < a_counter; i++)
        {
            Console.Write($" {a_res[i].mon} {a_res[i].day}");
        }
        Console.Write("\n");

        // Task b)
        int b_counter = 0;
        string[] b_res = new string[N];
        for (i = 0; i < N; i++)
        {
            if (b_res.Contains(data[i].name))
            {
                continue;
            }
            b_res[b_counter] = data[i].name;
            b_counter++;
        }
        Console.Write($"{b_counter} ");
        Console.Write($"{string.Join(',', b_res)}\n");

        // task c)
        int[] c_res = new int[12];
        for (i = 0; i < N; i++)
        {
            c_res[(data[i].mon) - 1] += 1;
        }
        Console.Write($"{string.Join(' ', c_res)}\n");

        // task d)
        int d_max = c_res.Max();
        for (i = 0; i < 12; i++)
        {
            if (c_res[i] == d_max)
            {
                Console.Write($"{i + 1} {c_res[i]}\n");
                break;
            }
        }
    }
}
