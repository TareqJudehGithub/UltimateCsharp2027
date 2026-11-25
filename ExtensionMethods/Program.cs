using ExtensionMethods;

Console.WriteLine("Hello, World!");
var multiLineText = @"aaa
bbb
ccc
ddd";

var number = 231;

// Find out how many lines in a given string 


int CountLines(string text) => text.Split(Environment.NewLine).Length;

System.Console.WriteLine(CountLines(multiLineText));

// Regular method calling
//var countLinesInText = StringExtensions.CountLines(multiLineText);
// Extension Method calling
var countLinesInTextExtMthd = multiLineText.CountLines();
System.Console.WriteLine($"Lines total = {countLinesInTextExtMthd}");

var isNumEven = number.IsEven();

if (isNumEven)
{
  System.Console.WriteLine($"{number} is an even number");
}
else
{
  System.Console.WriteLine($"{number} is an odd number");
}

var summer = Season.Summer;
System.Console.WriteLine(summer);

var nextSeasonAfterSummer = Season.Winter.Next();
var prevSeasonBeforeSummer = Season.Winter.Previous();
System.Console.WriteLine($"Next season will be: {nextSeasonAfterSummer}");
System.Console.WriteLine($"Previous season was: {prevSeasonBeforeSummer}");

System.Console.WriteLine("Press any key to exit and return to Terminal.");
System.Console.ReadKey();