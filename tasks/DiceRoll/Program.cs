// Main entry point (class)
using DiceRoll;

Console.WriteLine("Rolls dice!");

var attemptsLeft = RollTheDice.Attempts;
var rollTheDice = RollTheDice.RollDice();
do
{
  Console.Write("Guess the dice: ");
  var isInt = int.TryParse(Console.ReadLine(), out int userGuess);
  if (isInt)
  {
    if (userGuess == rollTheDice)
    {
      System.Console.WriteLine("You win!");
      break;
    }
    else if (userGuess != rollTheDice)
    {
      System.Console.WriteLine("Wrong number");
      attemptsLeft--;
    }
    if (attemptsLeft == 0)
    {
      System.Console.WriteLine("You lose");
      break;
    }
  }
  else
  {
    System.Console.WriteLine("Invalid entry.");
  }

} while (attemptsLeft != 0);

//var newRoll = new RollTheDice();

// var rollDice = RollTheDice.RollDice();
// System.Console.WriteLine(rollDice);
// System.Console.WriteLine($"You have {attemptsLeft} attempts left.");
// var result = RollTheDice.UserGuess(5);
// System.Console.WriteLine(result);