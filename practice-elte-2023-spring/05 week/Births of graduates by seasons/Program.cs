// A university stores information of its graduates: the birth date (year, month, day), the start
// year of the university studies and the year of graduation.
// Write a program that gives the count of students who were born in each season.

// Input
// The frst line of the standard input contains the count of graduates (1≤N≤100). The
// next N lines contain the data about a graduate each, in the form of 5 integers separated by
// spaces. The frst three numbers are the parts of birth date: year(1950≤Y≤2000), month
// (1≤M≤12) and day(1≤D≤30). The fourth number is the start year (2000≤S<2020), and
// the last number is the year of the graduation (S≤G<2020).

// Output
// The frst line of the standard output should contain the count of graduates born in
// spring, summer, autumn and winter (in this order).

// 6
// 1980 1 1 2007 2012
// 1970 6 2 2007 2012
// 1999 12 1 2007 2012
// 1982 10 1 2000 2005
// 1982 9 9 2000 2012
// 1982 1 1 2000 200

using System;
using System.Linq;

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
