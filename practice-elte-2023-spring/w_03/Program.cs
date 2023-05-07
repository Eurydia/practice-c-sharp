using System;
using System.Linq;
class Programm
{
    static void compute_factorial()
    {
        // task 01
        // Let's calculate N! 
        // (N! = N factorial = the product of numbers from 1 to N)
        Console.Write("Enter one number (int): ");
        int n = Convert.ToInt32(Console.ReadLine());
        int res = 1;
        for (int i = 1; i <= n; i++)
        {
            res = res * i;
        }

        Console.Write($"{n}! = {res}\n");
    }

    static void compute_divisor_sum()
    {
        // task 02
        // Compute the sum of the divisors of an N natural number.
        // note: slightly optimized

        Console.Write("Enter one number (int): ");
        int n = Convert.ToInt32(Console.ReadLine());
        int res = 1 + n;
        for (int i = 2; i <= (n / 2); i++)
        {
            if (n % i == 0)
            {
                res = res + i;
            }
        }

        Console.Write($"Sum of divisors of {n} = {res}\n");
    }

    static void compute_odd_divisor_sum()
    {
        // task 03
        // Compute the sum of the odd divisors of an N natural number.
        // note: slight optimization by skipping all even numbers 
        Console.Write("Enter one number (int): ");
        int n = Convert.ToInt32(Console.ReadLine());
        int res = 1;
        for (int i = 3; i <= (n / 2); i = i + 2)
        {
            if (n % i == 0)
            {
                res = res + i;
            }
        }

        if (n % 2 == 1)
        {
            res = res + n;
        }
        Console.Write($"Sum of odd divisors of {n} = {res}\n");
    }

    static void compute_n_squares()
    {
        //  task 04
        // Print the first N square numbers.
        Console.Write("Enter one number (int): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write($"The first {n} square numbers are:\n");

        for (int i = 1; i < n; i++)
        {
            Console.Write($"{i * i}");
        }
    }

    static void compute_squares_less_than_n()
    {
        // task 05
        // Print the square numbers that are less than N.
        Console.Write("Enter one number (int): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write($"The square numbers less than {n} are:\n");
        int i = 0;
        while ((i * i) < n)
        {
            Console.Write($"{i * i}");
            i++;
        }
        Console.Write("\n");
    }

    static void compute_triagle_number()
    {
        // task 06
        // Print the first N triangle numbers. (The K'th triangle number is 1+2+...+K)
        Console.Write("Enter one number (int): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write($"The first {n} triangle numbers are:\n");

        int res = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"{res} ");
            res = res + i;
        }
        Console.Write("\n");
    }

    static void compute_power_of_two_less_than_k()
    {
        // task 07
        // Given a K number, determine the smallest power of 2 which is bigger than K.

        Console.Write("Enter one number (int): ");
        int k = Convert.ToInt32(Console.ReadLine());


        int power = 0;
        while (Math.Pow(2, power) < k)
        {
            power++;
        }
        Console.Write($"The smallest power of two greater than {k} is {power}.\n");

    }

    static void compute_stars()
    {
        // task 08
        // Read an integer and print a line with that number of stars (asterisks).

        Console.Write("Enter # stars number (int): ");
        int k = Convert.ToInt32(Console.ReadLine());

        string stars = "";
        for (int i = 0; i < k; i++)
        {
            stars = $"{stars}*";
        }
        Console.Write($"{stars}\n");
    }

    static void draw_rectangle()
    {
        // task 09
        // Draw a rectangle of w width and l length with '*' characters.
        Console.Write("Enter width and lenfth separated by a space (int int): ");
        int[] splitted_buffer = new int[2];

        string? buffer = Console.ReadLine();
        if (string.IsNullOrEmpty(buffer))
        {
            buffer = "";
        }
        splitted_buffer = buffer.Split(" ").Select(b => Convert.ToInt32(b)).ToArray();


        int w, l;
        w = splitted_buffer[0];
        l = splitted_buffer[1];

        string rectagle = "";
        for (int j = 0; j < l; j++)
        {
            for (int i = 0; i < w; i++)
            {
                rectagle = $"{rectagle}*";
            }
            rectagle = $"{rectagle}\n";
        }

        Console.Write(rectagle);
    }

    static void draw_triangle()
    {
        // task 10
        // Give the height and width of a triangle, and print it out like the examples below. 
        Console.Write("Enter height and width separated by a space (int int): ");
        int[] splitted_buffer = new int[2];

        string? buffer = Console.ReadLine();
        if (string.IsNullOrEmpty(buffer))
        {
            buffer = "";
        }
        splitted_buffer = buffer.Split(" ").Select(b => Convert.ToInt32(b)).ToArray();

        int h, w;
        h = splitted_buffer[0];
        w = splitted_buffer[1];


        // left aligned trinagle
        for (int row = 1; row < h + 1; row++)
        {
            for (int col = 0; col < row; col++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }

        // right aligned trinagle
        for (int row = 1; row < h + 1; row++)
        {
            string r = "";
            for (int col = 0; col < row; col++)
            {
                r = $"{r}*";
            }
            Console.Write($"{r.PadLeft(w)}\n");
        }

        // center aligned trinagle
        for (int row = 1; row < h + 1; row++)
        {
            string r = "";
            for (int col = 0; col < row; col++)
            {
                r = $"{r}* ";
            }
            Console.Write($"{r.PadLeft(w + row)}\n");
        }
    }

    static void run_subprogramm()
    {
        // task 11
        // Write a computer program that has a menu, and the user can choose which of the tasks the program is going to do.

        // a: adds two numbers
        // m: multiplies two numbers
        // s: swaps two numbers
        // e: exit
        // The program should stop when the user chooses 'e', otherwise it should ask the user again what they would like to do.

        while (true)
        {
            string? buffer;
            int[] splitted_buffer = new int[2];
            int a, b;

            char action = 'a';
            Console.Write("Select task:\n" +
            "\"a\": adds two numbers\n" +
            "\"m\": multiplies two numbers\n" +
            "\"s\": swaps two numbers\n" +
            "\"e\": exit\n" +
            ">");

            buffer = Console.ReadLine();
            if (string.IsNullOrEmpty(buffer))
            {
                buffer = "u";
            }

            action = Convert.ToChar(buffer);

            if (action != 'a' && action != 'm' && action != 's' && action != 'e')
            {
                Console.Write($"Unknown task \"{action}\".\n");
                continue;
            }

            Console.Write("Enter A B separated by a space (int int): ");
            buffer = Console.ReadLine();
            if (string.IsNullOrEmpty(buffer))
            {
                buffer = "0 0";
            }
            splitted_buffer = buffer.Split(" ").Select((b) => Convert.ToInt32(b)).ToArray();
            a = splitted_buffer[0];
            b = splitted_buffer[1];


            switch (action)
            {
                case 'a':
                    Console.Write($"Sum = {a + b}\n");
                    break;
                case 'm':
                    Console.Write($"Prod = {a * b}\n");
                    break;
                case 's':
                    Console.Write($"A = {b}; B = {a}\n");
                    break;
                case 'e':
                    return;
            }
        }
    }

    static void compute_ulam_sequence()
    {
        // task 12
        // Generate the Ulam sequence!
        Console.Write("Enter one number (int): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Ulam sequence of {n} is\n");
        int current = n;
        while (current != 1)
        {
            Console.Write($"{current} -> ");
            if (current % 2 == 1)
            {
                current = (current * 3) + 1;
            }
            else
            {
                current = current / 2;
            }
        }
        Console.Write(1);
    }

    static void replace_zero_digit_with_five()
    {
        // task 13
        // Replace all 0's with 5's  in a number!
        Console.Write("Enter one number (int): ");
        int n = Convert.ToInt32(Console.ReadLine());

        string digits = n.ToString().Replace('0', '5');
        Console.Write($"Replaced = {digits}\n");
    }

    static void reverse_digits()
    {
        // task 14
        // Reverse the order of digits in an integer 
        Console.Write("Enter one number (int): ");
        int n = Convert.ToInt32(Console.ReadLine());

        char[] digits = n.ToString().ToCharArray();
        Array.Reverse(digits);

        string reversed_digits = new string(digits);

        Console.Write($"Reversed = {reversed_digits}\n");
    }

    static void is_armstrong_number()
    {
        // task 15
        // Check whether the entered number is an Armstrong number or not.
        Console.Write("Enter one number (int): ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] digits = n.ToString().ToArray().Select((d) => Convert.ToInt32(d) - 48).ToArray();
        int sum_cube_digits = 0;
        foreach (char digit in digits)
        {
            sum_cube_digits = sum_cube_digits + (digit * digit * digit);
        }

        Console.Write($"{n} is an Armstrong number: {sum_cube_digits == n}\n");
    }

    static void Main()
    {
        // compute_power_of_two_less_than_k();
        // draw_rectangle();
        // draw_triangle();
        // run_subprogramm();
        // compute_ulam_sequence();
        // replace_zero_digit_with_five();
        // reverse_digits();
        is_armstrong_number();
    }
}