using System;

namespace DiceRoll;

public class RollTheDice
{
  private const int DiceSides = 6;
  public static int Attempts { get; private set; } = 3;

  // Methods
  public static int RollDice()
  {
    return Random.Shared.Next(1, DiceSides + 1);
  }
}
