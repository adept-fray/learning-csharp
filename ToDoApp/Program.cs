using System.ComponentModel;

Console.WriteLine("=== ToDo App ===");

void Menu()
{
    Console.WriteLine("Write 'q' to exit.");
    Console.WriteLine("You can add, list, and remove tasks.");

    Console.WriteLine("you can write the commands without the numbers:");
    Console.WriteLine("1. add");
    Console.WriteLine("2. list");
    Console.WriteLine("3. remove");
    Console.WriteLine("4. q");
}

var  list = new List<string>();
bool exitLoop = false;
while (!exitLoop)
{
    Menu();

    string command = Console.ReadLine();


    switch (command)
    {
        case "add":
            Console.WriteLine("Write your task then hit enter to save it.");
            string add = Console.ReadLine();
            if (string.IsNullOrEmpty(add))
            {
                Console.WriteLine("Can not add empty or space only text.");
                break;
            }
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
            foreach (var item in list)
            {
                Console.WriteLine($"{list.IndexOf(item)}. {item}");
            }
            Console.WriteLine("enter the number of the task you want to remove from the list.");
            try
            {
                int remove = int.Parse(Console.ReadLine());
                list.RemoveAt(remove);
                Console.WriteLine($"task with index number of {remove} was removed from the list.");
            }
            catch(IndexOutOfRangeException index)
            {
                Console.WriteLine("The number you entered does not exist in the list.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Could not remove try again.");
            }
            break;
        case "q":
            exitLoop = true;
            break;
        default:
            Console.WriteLine($"{command} is not a correct command.");
            break;
    }
}

//Console.ReadKey();