// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Number Analyzer. What is your name?");
string name = Console.ReadLine().ToUpper();

bool cont = true;

while (cont)
{
    Console.WriteLine($"{name}, enter an integer between 1 and 100");
    int number = int.Parse(Console.ReadLine());
    if (number >= 1 && number <= 100)
        {

        if (number % 2 != 0 && number < 60)
            Console.WriteLine($"{number}: Odd and less than 60.");
        else if (number % 2 == 0 && number >= 2 && number <= 24)
            Console.WriteLine($"Even and less than 25");
        else if (number % 2 == 0 && number >= 26 && number <= 60)
            Console.WriteLine("Even and between 26 and 60 inclusive.");
        else if (number % 2 == 0 && number > 60)
            Console.WriteLine($"{number}: Even and greater than 60");
        else if (number % 2 != 0 && number > 60)
            Console.WriteLine($"{number}: Odd and greater than 60");
        Console.WriteLine();
        Console.WriteLine("Do you want to go again? y/n");
    }
    else
    {
        Console.WriteLine($"{number} is not a valid entry! Try again.");
        Console.WriteLine();
        continue;
    }
    string answer = Console.ReadLine().ToLower();
    if (answer == "n")
    {
        Console.WriteLine($"Bye {name}!");
        cont = false;
    }
}


