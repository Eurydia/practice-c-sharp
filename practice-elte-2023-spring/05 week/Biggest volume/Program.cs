// See https://aka.ms/new-console-template for more information
// Patterns of Algorithms – summation

// Biggest volume

// We have N cubes in a building game.
// Write a program that gives the volume of the biggest object that can be built from the
// cubes.

// Input:
// The frst line of the standard input contains the count of cubes (1≤N≤100). The
// next N lines contain each the length of the side of a cube (1≤L≤100).

// Output:
// The frst line of the standard output should contain the biggest possible volume.

using System;
using System.Linq;

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