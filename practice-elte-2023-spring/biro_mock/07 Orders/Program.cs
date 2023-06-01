using System;
using System.Linq;

struct Offer
{
    public int companyId;
    public int productId;
    public int productPrice;
}


class Program
{

    static void SolveTaskA(int offerCount, Offer[] offers)
    {
        int i;
        int currPrice, currId;

        int mostExpensiveId = offers[0].productId;
        int mostExpensivePrice = offers[0].productPrice;

        for (i = 1; i < offerCount; i++)
        {
            currId = offers[i].productId;
            currPrice = offers[i].productPrice;

            if (currPrice < mostExpensivePrice)
            {
                continue;
            }
            else if (currPrice == mostExpensivePrice)
            {
                if (currId < mostExpensiveId)
                {
                    mostExpensiveId = currId;
                }
            }
            else
            {
                mostExpensiveId = currId;
                mostExpensivePrice = currPrice;
            }
        }
        Console.WriteLine("#");
        Console.WriteLine($"{mostExpensiveId}");
    }

    static void SolveTaskB(int companyCount, int offerCount, Offer[] offers)
    {
        int i, currId;

        int[] productProducers = new int[companyCount];
        for (i = 0; i < offerCount; i++)
        {
            currId = offers[i].companyId - 1;
            productProducers[currId]++;
        }
        int mostProductId = 1;
        int mostProduct = productProducers[0];
        for (i = 1; i < companyCount; i++)
        {
            if (productProducers[i] > mostProduct)
            {
                mostProductId = i + 1;
                mostProduct = productProducers[i];
            }
        }
        Console.WriteLine("#");
        Console.WriteLine($"{mostProductId}");
    }

    static void SolveTaskC(int productCount, int offerCount, Offer[] offers)
    {
        int i, currId;

        int[] producedBy = new int[productCount];
        for (i = 0; i < offerCount; i++)
        {
            currId = offers[i].productId - 1;
            producedBy[currId]++;
        }

        int uniqueProductCount = 0;
        int[] uniqueProductIds = new int[productCount];
        for (i = 0; i < productCount; i++)
        {
            if (producedBy[i] == 1)
            {
                uniqueProductIds[uniqueProductCount] = i + 1;
                uniqueProductCount++;
            }
        }

        Console.WriteLine("#");
        Console.WriteLine($"{uniqueProductCount}");
        Array.Sort(uniqueProductIds);
        for (i = (productCount - uniqueProductCount); i < productCount; i++)
        {
            Console.Write($"{uniqueProductIds[i]} ");
        }
        Console.Write("\n");
    }

    static void SolveTaskD(int productCount, int companyCount, int offerCount, Offer[] offers)
    {
        int i, j;
        int[][] productTable = new int[companyCount][];
        for (i = 0; i < companyCount; i++)
        {
            productTable[i] = new int[productCount];
        }

        int row, col;
        for (i = 0; i < offerCount; i++)
        {
            row = offers[i].companyId - 1;
            col = offers[i].productId - 1;
            productTable[row][col] = 1;
        }

        Console.Write("#\n");
        for (i = 0; i < companyCount; i++)
        {
            for (j = i + 1; j < companyCount; j++)
            {
                if (productTable[i].SequenceEqual(productTable[j]))
                {
                    Console.Write($"{i + 1} {j + 1}\n");
                    return;
                }
            }
        }
        Console.Write("-1\n");
    }

    static void Main(string[] args)
    {
        int i;
        string buffer;
        string[] bufferSplitted;

        int N, M, O;
        buffer = Console.ReadLine()!;
        bufferSplitted = buffer.Split(" ");
        N = Convert.ToInt32(bufferSplitted[0]);
        M = Convert.ToInt32(bufferSplitted[1]);
        O = Convert.ToInt32(bufferSplitted[2]);


        Offer[] offers = new Offer[O];
        for (i = 0; i < O; i++)
        {
            buffer = Console.ReadLine()!;
            bufferSplitted = buffer.Split(" ");


            offers[i].companyId = Convert.ToInt32(bufferSplitted[0]);
            offers[i].productId = Convert.ToInt32(bufferSplitted[1]);
            offers[i].productPrice = Convert.ToInt32(bufferSplitted[2]);
        }

        Program.SolveTaskA(O, offers);
        Program.SolveTaskB(N, O, offers);
        Program.SolveTaskC(N, O, offers);
        Program.SolveTaskD(N, M, O, offers);
    }
}
