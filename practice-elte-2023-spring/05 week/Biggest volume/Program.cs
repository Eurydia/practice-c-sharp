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
        int N, curr, total = 0;

        N = Convert.ToInt32(Console.ReadLine());

        for (int l = 0; l < N; l++)
        {
            curr = Convert.ToInt32(Console.ReadLine());
            total = total + (curr * curr * curr);
        }

        Console.Write($"{total}\n");
    }
}