using System;

namespace ExtensionMethods;

public static class StringExtensions
{
  public static int CountLines(this string text)
  {
    return text.Split(Environment.NewLine).Length;
  }
}
public static class IntegerExtensions
{
  public static bool IsEven(this int number)
  {
    return number % 2 == 0;
  }
}
