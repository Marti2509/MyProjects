bool playing = false;
do
{
    Console.WriteLine("There are 4 different types of difficulties:");
    Console.WriteLine("easy -> 1 - 10");
    Console.WriteLine("medium -> 1 - 100");
    Console.WriteLine("hard -> 1 - 1000");
    Console.WriteLine("expert -> 1 - 10000");

    Console.Write("Please enter the difficulty: ");
    string? difficulty = Console.ReadLine()?.Trim().ToLower();
    Console.Clear();

    int number = 0;

    int maxNumber = 0;
    int minNumber = 1;

    Random random = new Random();
    if (difficulty == "easy")
    {
        number = random.Next(1, 11);
        maxNumber = 10;
    }
    else if (difficulty == "medium")
    {
        number = random.Next(1, 101);
        maxNumber = 100;
    }
    else if (difficulty == "hard")
    {
        number = random.Next(1, 1001);
        maxNumber = 1000;
    }
    else if (difficulty == "expert")
    {
        number = random.Next(1, 10001);
        maxNumber = 10000;
    }
    else
    {
        Console.WriteLine("Wrong difficulty!");

        Console.Write("Do you want to try again? (Yes/No) ");
        string? again = Console.ReadLine()?.Trim().ToLower();

        if (again == "yes")
            playing = true;
        else
            playing = false;
        Console.Clear();

        continue;
    }

    Console.WriteLine($"{minNumber} - {maxNumber}");
    while (true)
    {
        Console.Write("Make your guess: ");
        bool parsed = int.TryParse(Console.ReadLine()?.Trim(), out int guess);
        if (!parsed)
        {
            Console.WriteLine("Invalid number.");
            continue;
        }

        if (guess < minNumber || guess > maxNumber)
        {
            Console.WriteLine($"Your guess must be in this range: {minNumber} - {maxNumber}.");
            continue;
        }

        if (guess == number)
        {
            Console.Clear();
            Console.WriteLine("Congratulations! You guessed the number!");
            break;
        }
        else if (guess > number)
            Console.WriteLine("Incorrect. Too High.");
        else
            Console.WriteLine("Incorrect. Too Low.");
    }

    Console.Write("Do you want to continue playing? (Yes/No) ");
    string? answer = Console.ReadLine()?.Trim().ToLower();

    if (answer == "yes")
        playing = true;
    else
        playing = false;

    Console.Clear();
} while (playing);

Console.WriteLine("Thanks for playing!");