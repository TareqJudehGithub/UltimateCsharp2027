using System.Runtime.ConstrainedExecution;
using Animals;

Console.WriteLine("Animal Exercise!");

var animals = new Exercise();

var totalNumberOfLegs = animals.CalculateTotalLegs();
System.Console.WriteLine(totalNumberOfLegs);

var greet = "Hello World!";
var number = 3;
bool isString = greet is string;
bool isInt = number is int;

if (isString)
{
  System.Console.WriteLine($"{nameof(greet)} is of type {greet.GetType().Name}");
}
if (isInt)
{
  System.Console.WriteLine($"{nameof(number)} is of type {number.GetType().Name}");
}
else
{
  System.Console.WriteLine($"Different type.");
}



object value = null;

// is: checks the type and, if it matches, gives you a typed variable
if (value is string text)
{
  Console.WriteLine(text.ToUpper());
}
string? converted = value as string;

if (converted is not null)
{
  System.Console.WriteLine(converted.ToLower());
}
else
{
  System.Console.WriteLine(converted);
}
System.Console.WriteLine($"{nameof(converted)} is null");
