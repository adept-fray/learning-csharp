Console.WriteLine("=== ToDo App ===");

Console.WriteLine("You can add, list, and remove tasks.");

Console.WriteLine("you can write the commands without the numbers:");
Console.WriteLine("1. add");
Console.WriteLine("2. list");
Console.WriteLine("3. remove");

var  list = new List<string>();

string command = Console.ReadLine();
string add = "";
int remove = 0;

switch (command)
{
    case "add":
        Console.WriteLine("Write your task then hit enter to save it.");
        string add = Console.ReadLine();
        list.Add(add);
        Console.WriteLine("Task added to the list.");
        break;
    case "list":
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        break;
    case "remove":
        Console.WriteLine("enter the number of the task you want to remove from the list.");
        int remove = Convert.ToInt32(Console.ReadLine());
        list.RemoveAt(remove);
        Console.WriteLine($"task with index number of {remove} was removed from the list.");
        break;
    default:
        Console.WriteLine($"{command} is not a correct command.");
        break;
}

Console.ReadKey();