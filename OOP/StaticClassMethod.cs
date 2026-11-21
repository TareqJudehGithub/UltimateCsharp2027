using System;

namespace OOP;

// A static class works as a container for methods and cannot be instantiated
public static class StaticClassMethod
{
  public const int Number = 4;
  public static int Add(int a, int b) => a + b;
  public static int Subtract(int a, int b) => a - b;
  public static int Multiply(int a, int b) => a * b;
  public static int Divide(int a, int b) => a / b;


}

class SomeClass
{
  private int _number;

  // This will return an error - static method can only contain static fields.
  // public static string AsString() => "Value of field is" + _number;
}