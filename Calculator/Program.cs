// Console.WriteLine("");
// Console.Write("Input the first number: ");
// var firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the second number: ");
// var secondNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("What do you want to do with those numbers?");
// Console.WriteLine("[A]dd");
// Console.WriteLine("[S]ubtract");
// Console.WriteLine("[M]ultiply");
// var userChoice = Console.ReadLine();

// if (userChoice == "")
// {
//   Console.WriteLine("Invalid option");
// }
// if (userChoice != null)
// {
//   Console.WriteLine(Calculator(firstNumber, secondNumber, userChoice));
// }

// int Calculator(int inputA, int inputB, string userChoice)
// {
//   int result = 0;
//   if (userChoice.ToLower() == "a")
//   {
//     result = inputA + inputB;
//   }
//   else if (userChoice.ToLower() == "s")
//   {
//     result = inputA - inputB;
//   }
//   else if (userChoice.ToLower() == "m")
//   {
//     result = inputA * inputB;
//   }
//   return result;
// }

// Console.WriteLine("");


// while loop
using System.Runtime.InteropServices;

var number = 0;
while (number < 10)
{
  Console.WriteLine(number);
  number++;
}

Console.WriteLine($"number now is {number}\n");


// do-while loop
char a = 'a';
string result = "";
do
{
  result += a;
  Console.WriteLine(result);
}
while (result.Length < 4);

Console.WriteLine(result);

// for loop
for (int i = 0; i < 10; ++i)
{
  Console.WriteLine(i);
}

int Factorial(int number)
{
  //your code goes here
  number = Math.Abs(number);

  int result = 1;

  if (number == 0)
  {
    result = 1;
  }
  for (int i = 1; i <= number; i++)
  {
    result *= i;
  }
  return result;
}
Console.WriteLine(Factorial(4));


// Arrays
System.Console.WriteLine("\nArrays");
string[] countries = new[] { "Jordan-0", "USA-1" };

int[] scores = new[] { 75, 82, 68, 87, 90 };

int CalculateSum(int[] scores)
{
  int sum = 0;
  for (int i = 0; i < scores.Length; i++)
  {
    sum += scores[i];
  }
  return sum;
}

int scoresLength = scores.Length;
System.Console.WriteLine(CalculateSum(scores));
System.Console.WriteLine(scoresLength);
System.Console.WriteLine(scores.Count() == 5);


// Lists
List<string> cart = new List<string>();
cart = ["Milk", "Sugar", "Orange Juice"];

List<string> newCart = ["Milk", "Sugar", "Orange Juice"];



// TryParse  - out

Console.Write("TryParse - Enter a number: ");
string myInput = Console.ReadLine();
bool isInt = int.TryParse(myInput, out int integerNumber);

if (isInt)
{
  System.Console.WriteLine(integerNumber);
}
else
{
  System.Console.WriteLine("Bad int entry");
}



