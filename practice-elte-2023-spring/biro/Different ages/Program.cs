using System;
using System.Linq;

class Program
{
    static int readEmployeeCount()
    {
        string buffer;
        bool isValidInput, isParsable;
        int N;
        do
        {
            Console.Write("Please enter # of employees(Integer 1-100)\n");
            buffer = Console.ReadLine();

            isParsable = int.TryParse(buffer, out N);
            if (!isParsable)
            {
                Console.Write("Unable to parse input.");
                isValidInput = false;
                continue;
            }
            if (N < 1)
            {
                Console.Write("Input too small.");
                isValidInput = false;
                continue;
            }
            if (N > 100)
            {
                Console.Write("Input too large.");
                isValidInput = false;
                continue;
            }
            isValidInput = true;
        } while (!isValidInput);
        return N;
    }

    static int[] readEmployeeAges(int employeeCount)
    {
        int i, tempAge;
        bool isParsable, isValidInput;
        string buffer;
        string[] bufferSplitted;


        int[] ages = new int[employeeCount];

        for (i = 0; i < employeeCount; i++)
        {
            do
            {
                Console.Write($"Please enter age of employees #{i + 1}(Integer 1-100)\n");
                buffer = Console.ReadLine();
                bufferSplitted = buffer.Split(" ");
                isParsable = int.TryParse(bufferSplitted[0], out tempAge);
                if (!isParsable)
                {
                    Console.Write("Unable to parse input.");
                    isValidInput = false;
                    continue;
                }
                if (tempAge < 1)
                {
                    Console.Write("Input too small.");
                    isValidInput = false;
                    continue;
                }
                if (tempAge > 100)
                {
                    Console.Write("Input too large.");
                    isValidInput = false;
                    continue;
                }
                isValidInput = true;
            } while (!isValidInput);
            ages[i] = tempAge;
        }
        return ages;
    }

    static bool arrayHas(int ele, int arrSize, int[] arr)
    {
        int i;
        for (i = 0; i < arrSize; i++)
        {
            if (arr[i] == ele)
            {
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        int i;

        int N = readEmployeeCount();
        int[] ages = readEmployeeAges(N);

        int[] uniqueAges = new int[N];
        int count = 0;

        for (i = 0; i < N; i++)
        {
            if (arrayHas(ages[i], N, ages))
            {
                uniqueAges[count] = ages[i];
                count++;
            }
        }

        Console.Write($"{count}\n");
    }
}
