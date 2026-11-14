string? userChoice;
List<string> TODO = ["First Item"];
do
{
  System.Console.Clear();
  Console.WriteLine("================= TODO List! =================\n");
  Console.WriteLine("[S]ee all TODOs");
  Console.WriteLine("[A]dd a TODO");
  Console.WriteLine("[R]emove a TODO");
  Console.WriteLine("[E]xit\n");

  Console.Write("What do you want to do? ");
  userChoice = Console.ReadLine();
  ToDoAction(userChoice, TODO);



}
while (userChoice != "e");



// Exit Console
Console.WriteLine("\nPress any key to exit Console");
Console.ReadKey();
Console.Clear();

// TODO list
//List<string> TODO = [];

// Methods
void ToDoAction(string userInput, List<string> todoList)
{
  switch (userInput.ToLower())
  {
    case "a":
      // Add TODO
      AddTodo(todoList);
      break;
    case "s":
      ShowAllTODOs(todoList);
      break;
    case "r":
      RemoveTodo(todoList);
      break;
    case "e":
      Console.WriteLine("Exiting program.\nGood bye!");
      break;
    default:
      Console.WriteLine("Invalid input");
      break;
  }

  // Add a TODO
  void AddTodo(List<string> todoList)
  {
    string? userInput;
    do
    {
      Console.Clear();
      Console.WriteLine("================= TODO List! =================\n");
      Console.WriteLine("Add a TODO option is selected.");
      Console.Write("Enter TODO description: ");
      userInput = Console.ReadLine();
      if (userInput == "")
      {
        Console.Clear();
        Console.WriteLine("================= TODO List! =================\n");
        System.Console.WriteLine("Invalid entry. Enter some text.");
        System.Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();
        continue;
      }

      todoList.Add(userInput);

    }
    while (userInput == "");
    System.Console.WriteLine($"New TODO added successfully!");
    System.Console.WriteLine("\nPress any key to continue");
    Console.ReadKey();
    Console.Clear();
  }
}

// Remove a TODO
void RemoveTodo(List<string> todoList)
{
  Console.Clear();
  Console.WriteLine("Selected option: Remove a TODO.");
  bool isInt;
  do
  {
    Console.WriteLine("================= TODO List! =================\n");
    for (int i = 0; i < todoList.Count(); i++)
    {
      System.Console.WriteLine($"{i + 1} - {todoList[i]}");
    }
    Console.Write($"which TODO you wish to remove? (1 - {todoList.Count()}): ");
    string userChoice = Console.ReadLine();

    isInt = int.TryParse(userChoice, out int todoIndex);

    if (isInt && todoIndex <= todoList.Count())
    {
      todoList.RemoveAt(todoIndex - 1);
      System.Console.WriteLine("Todo item removed successfully!");
      System.Console.WriteLine("\nPress any key to continue");
      Console.ReadKey();
      Console.Clear();
    }
    else
    {
      System.Console.WriteLine("Invalid entry");
      System.Console.WriteLine("\nPress any key to continue");
      Console.ReadKey();
      Console.Clear();
      continue;
    }

  }
  while (!isInt);

}


// Show all TODOs
void ShowAllTODOs(List<string> todoList)
{
  Console.Clear();
  Console.WriteLine("================= TODO List! =================\n");
  if (todoList.Count > 0)

    foreach (string item in todoList)
    {
      System.Console.WriteLine(item);
    }
  else
  {
    System.Console.WriteLine("TODO list is empty.");
  }
  System.Console.WriteLine("\nPress any key to return to main menu.");
  Console.ReadKey();
}

