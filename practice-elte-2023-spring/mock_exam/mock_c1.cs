struct Travel
{
    public int distance;
    public int clues;
    public string city;
}

class Program
{

    static int checkNumber(int minInclusive, int maxInclusive, string errorMessage)
    {
        bool isValidInput, isValidRange;
        int tempResult;

        do
        {
            isValidInput = int.TryParse(Console.ReadLine(), out tempResult);
            // scanf("%d", &length);
            // "1" -> true
            // "." -> false

            if (isValidInput)
            {
                if (tempResult < minInclusive || tempResult > maxInclusive)
                {
                    Console.Write(errorMessage);
                    isValidRange = false;
                }
                else
                {
                    isValidRange = true;
                }
            }
            else
            {
                Console.Write("Invalid input; unable to parse.");
            }
        } while (!isValidInput || !isValidRange);

        return tempResult;
    }

    static string checkString(int minLength, int maxLength, string errorMessage)
    {
        bool isValidLength;
        string tempResult;

        do
        {
            tempResult = Console.ReadLine();

            if (tempResult.Length < minLength || tempResult.Length > maxLength)
            {
                Console.Write(errorMessage);
                isValidLength = false;
            }
            else
            {
                isValidLength = true;
            }
        } while (!isValidLength);

        return tempResult;
    }

    static void main()
    {
        bool isValidRange = false, isValidInput = false;
        int i, tempDistance, tempClues;
        string tempCity, buffer;
        string[] bufferSplitted;


        int length, distance, clues;
        string city;

        Console.Write("Enter # of cities(int): ");
        length = checkNumber(1, 100, "# of cities must be between 1 and 100.");


        Travel[] travel = new Travel[length];


        for (i = 0; i < length; i++)
        {
            Console.Write($"Enter the name of #{i + 1} city: ");
            tempCity = checkString(1, 50, "City name must be between 1 and 50 characters.");

            Console.Write($"Enter the distance of #{i + 1} city: ");
            tempDistance = checkNumber(0, 1000, "Distance must be between 0 and 1000.");

            Console.Write($"Enter the clues of #{i + 1} city: ");
            tempClues = checkNumber(0, 1000, "Clues must be between 0 and 20.");

            travel[i].city = tempCity;
            travel[i].distance = tempDistance;
            travel[i].clues = tempClues;
        }

        // PART A:
        float avgDist = 0.0;
        for (i = 0; i <= (length - 1); i++)
        {
            avgDist = avgDist + travel[i].distance;
        }
        avgDist = avgDist / length;
        Console.Write("#1\n");
        Console.Write($"{avgDist}\n");

        // PART B:
        int cnt = 0;
        string cities = "";
        for (i = 0; i <= (length - 1); i++)
        {
            if (travel[i].clues == 0)
            {
                cnt = cnt + 1;
                cities = cities + travel[i].city + " ";
            }
        }
        Console.Write("#2\n");
        Console.Write($"{cnt} {cities}\n");

        // ""
        // "" + "London" + " " -> "London "
        // "London " + "Budapest" + " " -> "London Budapest "

    }
}