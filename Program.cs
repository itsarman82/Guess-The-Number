//This Cli app runs on dotnet core version 6

Console.WriteLine("Welcome to guess the number game");

Random random = new Random();
bool playAgain = true;
int guesses;
int guess;
string response;

while (playAgain)
{

    guess = 0;
    guesses = 0;
    response = "";
    var number = random.Next(1, 100);

    while (guess != number)
    {
        Console.WriteLine("Guess a number between 1 to 100");
        guess = Convert.ToInt32(Console.ReadLine());

        if (number > guess)
        {
            Console.WriteLine("You guessed too low, guess higher");
        }
        else if (number < guess)
        {
            Console.WriteLine("You guessed too high, guess lower");
        }
        guesses++;
    }

    Console.WriteLine("You guessed the right number!");
    Console.WriteLine("number: " + number);
    Console.WriteLine("guesses: " + guesses);
    playAgain = false;

    Console.WriteLine("would you like to play again? (Y/N)");
    response = Console.ReadLine();
    response = response.ToUpper();

    if (response == "Y")
    {
        playAgain = true;
    }
    else if (response == "N")
    {
        playAgain = false;
    }

}
Console.WriteLine("Thank You For Playing");
Console.ReadKey();
