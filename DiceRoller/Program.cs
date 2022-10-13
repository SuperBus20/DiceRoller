int diceSides = 0;
int dice1Result = 0;
int dice2Result = 0;
bool keepPlaying = true;


while (keepPlaying == true)
{
    PlayGame();
    Console.WriteLine("Would you like to keep playing (y/n)?");
    string input = Console.ReadLine();
    if (input.ToLower() != "y")
    {
        keepPlaying = false;
    }
}

Console.WriteLine("GoodBye");


void PlayGame()
{
    Console.WriteLine("Please enter the number of sides of dice that you would like");

    while (!int.TryParse(Console.ReadLine(), out diceSides))
    {
        Console.WriteLine("Please enter a valid number of sides for your dice");
    }

    GenerateDice1(diceSides);
    GenerateDice2(diceSides);

    Console.WriteLine("Press any key to roll your dice");
    Console.ReadKey();

    if (diceSides == 6)
    {
        SixSidedDice();
    }
    else
    {
        Console.WriteLine($"You Rolled a {dice1Result} & {dice2Result}");
    }
}
int GenerateDice1(int diceSides)
{
    Random random = new Random();
    dice1Result = random.Next(1, diceSides);
    return dice1Result;

}

int GenerateDice2(int diceSides)
{
    Random random = new Random();
    dice2Result = random.Next(1, diceSides);
    return dice2Result;

}

void SixSidedDice()
{
    if (dice1Result == dice2Result && dice1Result == 1)
    {
        Console.WriteLine($"You rolled snake eyes ({dice1Result} & {dice2Result})");
    }
    else if (dice1Result == 1 || dice1Result == 2 && dice2Result == 1 || dice2Result == 2 && dice1Result != dice2Result)
    {
        Console.WriteLine($"You rolled an Ace Deuce ({dice1Result} & {dice2Result})");
    }
    else if (dice1Result == dice2Result && dice1Result == 6)
    {
        Console.WriteLine($"You rolled Box Cars ({dice1Result} & {dice2Result})");
    }
    else if (dice1Result + dice2Result == 7 || dice1Result + dice2Result == 11)
    {
        Console.WriteLine($"You rolled a Win ({dice1Result} & {dice2Result} for a total of {dice1Result + dice2Result})");
    }
    else
    {
        Console.WriteLine($"You rolled a {dice1Result} & a {dice2Result}");
    }
}