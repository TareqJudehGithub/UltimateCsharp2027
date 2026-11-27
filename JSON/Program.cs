using System.Text.Json;
using JSON;

Console.WriteLine("Hello, World!");

var johnSmith = new Person
{
  FirstName = "John",
  LastName = "Smith",
  YearOfBirth = 1975
};
System.Console.WriteLine(johnSmith.FirstName);

// Serialize
var johnSmithJson = JsonSerializer.Serialize(johnSmith);
System.Console.WriteLine(johnSmithJson);
// Deserialize
var sarahAdams = "{\"FirstName\":\"Sarah\", \"LastName\": \"Adams\", \"YearOfBirth\": 1972}";
var sarahAdamsJson = JsonSerializer.Deserialize<Person>(sarahAdams);
var sarahAdamSerialized = JsonSerializer.Serialize(sarahAdamsJson);
System.Console.WriteLine(sarahAdamSerialized);

Console.ReadKey();
