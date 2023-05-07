// See https://aka.ms/new-console-template for more information

class Program
{
    static void monthNameToNumber()
    {
        // task 01:
        // Write a program that gives the number of the month 
        // if the name of the month is given.

        string[] monthNames = {
            "January ",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December",
        };

        string target = Console.ReadLine().ToLower();

        for (int i = 0; i < monthNames.Length; i++)
        {
            if (monthNames[i] == target)
            {
                Console.Write($"The number of the month is = {i + 1}\n");
                return;
            }
        }
    }

    static void computeOrdinalDay()
    {
        // Task 02:
        // We have the number of a month and a day in that month. 
        // Give me the ordinal number of that day in the year.

        int[] offset = {
            0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30
        };

        string? buffer;
        string[] splitted_buffer;
        int month, day, ordinal = 0;

        Console.Write("Enter month and day separated by a space [Int Int]: ");
        buffer = Console.ReadLine();
        splitted_buffer = buffer.Split(" ");

        month = Convert.ToInt32(splitted_buffer[0]);
        day = Convert.ToInt32(splitted_buffer[1]);

        for (int i = 0; i < month; i++)
        {
            ordinal = ordinal + offset[i];
        }

        ordinal = ordinal + day;

        Console.Write($"The ordinal day is = {ordinal}\n");
    }

    static void processString()
    {
        // Task 03:
        // A string is given.
        //  a) Print the string backward.
        //  b) Print every second character of the string.
        //  c) Print it without syllables (a, e, i, o , u).

        string buffer;
        string reversed = "", second = "", vowels = "";
        Console.Write("Enter a string:");

        buffer = Console.ReadLine();


        for (int i = 0; i < buffer.Length; i++)
        {
            reversed = $"{buffer[i]}{reversed}";

            if (i % 2 == 1)
            {
                second = $"{second}{buffer[i]}";
            }

            string lowered = buffer[i].ToString().ToLower();

            if (lowered == "a" ||
            lowered == "e" ||
            lowered == "i" ||
            lowered == "o" ||
            lowered == "u")
            {
                vowels = $"{vowels}{buffer[i]}";
            }
        }
        Console.Write($"Reversed = {reversed}\n");
        Console.Write($"Second character = {second}\n");
        Console.Write($"Vowels = {vowels}\n");
    }

    static void monogram()
    {
        // Task 04:
        // We have a name. 
        // Give the monogram of the name
        // (the family and last name both start with capitals).

        string buffer;
        string[] splitted_buffer;
        string first_name, last_name;
        Console.Write("Enter first and last name separated by a space [String String]:");
        buffer = Console.ReadLine();
        splitted_buffer = buffer.Split(" ");

        first_name = splitted_buffer[0];
        last_name = splitted_buffer[1];

        Console.Write($"Monogram = {first_name[0]}{last_name[0]}\n");
    }

    static void countEven()
    {
        // Task 05:
        // NOTE: Skipped
        // There is an array of N length (1<=N<=100). 
        // How many even numbers are there in the array?

        // string buffer;
        // int n, count = 0;
        // Console.Write("Enter a number N [Int]:");
        // buffer = Console.ReadLine();

        // n = Convert.ToInt32(buffer);

        // for (int i = 0; i < )
    }

    static void sumArray()
    {
        // Task: 06
        // NOTE: Skipped
        // There is an array of N length (1<=N<=100). 
        // What is the sum of all the elements?
    }

    static void hasEven()
    {
        // Task: 07
        // NOTE: Skipped
        // There is an array of N length (1<=N<=100). 
        // Is there an even number in the array?
    }


    static void Main()
    {
        // computeOrdinalDay();
        // processString();

        monogram();
        return;
    }
}