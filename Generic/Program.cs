using System.Text.Json;
using Generic;

Console.WriteLine("Generic Types!");

var contacts = new List<Person>()
{
  new() {
    FirstName = "John",
    LastName = "Smith",
    Email =  "john.smith@gmail.com",
    Age = 51,
    Phone = [065852014, 0796969605]
  },
new()
  {
    FirstName = "Sarah",
    LastName = "Adams",
    Email =  "sarah.adams@gmail.com",
    Age = 38,
Phone = [065852090, 0795530932]
},
  new()
{
    FirstName = "William",
    LastName = "Stones",
    Email = "will.stones@gmail.com",
    Age = 46,
Phone = [065852081, 0795569264]
  }
};

contacts.Add(new()
{
  FirstName = "Omar",
  LastName = "Salem",
  Email = "omar.salem@gmail.com",
  Age = 29,
  Phone = [0796969903]
});

foreach (var contact in contacts)
{
  var person = JsonSerializer.Serialize(contact);
  System.Console.WriteLine(person);
}
