// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        programm_d();
    }

    static void programm_a()
    {
        // task 01
        int length, width, area, perimeter;
        Console.Write("Length (int):");
        length = Convert.ToInt16(Console.ReadLine());

        Console.Write("Width (int):");
        width = Convert.ToInt16(Console.ReadLine());

        area = length * width;
        perimeter = 2 * (length + width);


        Console.WriteLine($"Area = {length} x {width} = {area}");
        Console.WriteLine($"Perimeter = 2 x ({length} + {width}) = {perimeter}");
    }

    static void programm_b()
    {
        // task 02
        int a, b;
        Console.Write("A (int):");
        a = Convert.ToInt16(Console.ReadLine());

        Console.Write("B (int):");
        b = Convert.ToInt16(Console.ReadLine());
        int res = ((a * a) + (2 * a * b) + (b * b));

        string expanded = String.Format("({0} + {1})^2 = {0}^2 + 2({0})({1}) + {1}^2 = {2}", a, b, res);

        Console.WriteLine(expanded);
    }


    static void programm_c()
    {
        // task 03
        int a, b, c;
        int min, med, max;
        Console.Write("A (int):");
        a = Convert.ToInt16(Console.ReadLine());

        Console.Write("B (int):");
        b = Convert.ToInt16(Console.ReadLine());

        Console.Write("C (int):");
        c = Convert.ToInt16(Console.ReadLine());

        max = Math.Max(a, Math.Max(b, c));
        med = Math.Max(a, Math.Min(b, c));
        min = Math.Min(a, Math.Min(b, c));

        //Console.WriteLine("{0} {1} {2}", max, med, min);
        // Console.WriteLine("{0} {1} {2}", max ^ 2, med ^ 2, min ^ 2);

        if ((max * max) == ((min * min) + (med * med)))
        {
            Console.Write("Is right triangle.\n");
        }
        else
        {
            Console.Write("Is NOT right triangle.\n");
        }
    }


    static void programm_d()
    {
        // task 04
        double rate, distance, consumed;
        Console.Write("Petrol usage (l/km):");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Distance (km):");
        distance = Convert.ToDouble(Console.ReadLine());

        consumed = rate * distance;

        Console.Write($"Petron consumed (l): {consumed:0.00}\n");
    }

    static void programm_e()
    {
        // task 05
        int kids, apples, each, leftover;
        Console.Write("Kids (int):");
        kids = Convert.ToInt16(Console.ReadLine());

        Console.Write("Apples (int):");
        apples = Convert.ToInt16(Console.ReadLine());

        each = apples / kids;
        leftover = apples % kids;

        Console.Write($"Each kid gets {each} with {leftover} leftover\n");
    }

    static void programm_f()
    {
        // task 06
        int a, b, smaller;
        Console.Write("A (int):");
        a = Convert.ToInt16(Console.ReadLine());

        Console.Write("B (int):");
        b = Convert.ToInt16(Console.ReadLine());

        smaller = a > b ? b : a;

        Console.Write($"The smaller value is: {smaller}\n");
    }


    static void programm_g()
    {
        // task 07
        int n;
        Console.Write("N (int):");
        n = Convert.ToInt16(Console.ReadLine());

        if (n > 99 && n < 999)
        {
            Console.Write("{0} has three digits \n", n);
        }
        else
        {
            Console.Write("{0} does not have three digits \n", n);
        }
    }

    static void programm_h()
    {
        // task 08
        int a, b;
        string? buffer;
        string[] splitted_buffer;
        Console.Write("Enter two integers separated by a space:");

        buffer = Console.ReadLine();
        if (buffer == null)
        {
            buffer = "";
        }
        splitted_buffer = buffer.Split(" ");

        a = Convert.ToInt16(splitted_buffer[0]);
        b = Convert.ToInt16(splitted_buffer[1]);

        if (a % 2 == 1 || b % 2 == 1)
        {
            Console.Write("There is an od number\n");
        }
        else
        {
            Console.Write("There is NOT an odd number\n");
        }
    }

    static void programm_i()
    {
        // task 09
        int longest_word_index, longest_word_length;
        string? buffer;
        string[] words;

        buffer = Console.ReadLine();
        if (buffer == null)
        {
            buffer = "";
        }

        words = buffer.Split(" ");

        longest_word_index = 0;
        longest_word_length = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longest_word_length)
            {
                longest_word_index = i;
                longest_word_length = words[i].Length;
            }
        }

        Console.Write($"{words[longest_word_index]}\n");
    }

    static void programm_j()
    {
        // task 10
        double a, b, c, discriminant;

        Console.Write("A (double):");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("B (double):");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("C (double):");
        c = Convert.ToDouble(Console.ReadLine());

        discriminant = (b * b) - (4 * a * c);
        if (discriminant < 0)
        {
            Console.Write("No solution\n");
            return;
        }

        if (discriminant == 0)
        {
            Console.Write($"{(b * (-1)) / (2 * a)}\n");
            return;
        }

        Console.Write("{0}, {1}\n",
            ((b * (-1)) - discriminant) / (2 * a),
            ((b * (-1)) + discriminant) / (2 * a)
        );

    }


}
