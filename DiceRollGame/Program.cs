using DiceRollGame.Game;

var random = new Random();
var dice = new Dice(random);
var newGame = new DiceGame(dice);

GameResult gameResult = newGame.Play();
DiceGame.PrintResult(gameResult);

Console.ReadKey();


//First Implementation
/*var rand = new Random();
var newDice = new Dice(rand.Next(1, 7));
var mainGame = new MainGame(newDice);
mainGame.PlayGame();
Console.ReadKey();

public class Dice
{
    public int Value { get; private set; }

    public Dice(int value)
    {
        Value = value;
    }
}


public class MainGame
{
    private Dice _dice;
    private int numOfTries = 0;

    public MainGame(Dice dice)
    {
        _dice = dice;
    }

    public void PlayGame()
    {
        Console.WriteLine("Dice rolled. Guess what number it is in 3 tries.");
        var userGuess = "";
        while(numOfTries < 3)
        {
            Console.WriteLine("Enter number: ");
            userGuess = Console.ReadLine();

            if(int.TryParse(userGuess, out int value))
            {
                if(value == _dice.Value)
                {
                    Console.WriteLine("You win");
                    return;
                }
                Console.WriteLine("Wrong number");
                numOfTries++;
                continue;
            }
            Console.WriteLine("Incorrect input.");
        }
        Console.WriteLine("You lose");
    }
}*/