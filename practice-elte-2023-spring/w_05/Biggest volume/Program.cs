class Program
{
    static void Main()
    {
        int N, total = 0;

        N = Convert.ToInt32(Console.ReadLine());

        int[] cubes = new int[N];

        for (int i = 0; i < N; i++)
        {
            cubes[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (int cube in cubes)
        {
            total = total + (cube * cube * cube);
        }

        Console.Write($"{total}\n");
    }
}