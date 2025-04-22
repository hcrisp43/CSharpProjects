using System;


List<string> ToDoList = new List<string>();
var userChoice = "";
bool userExit = false;

do
{
    printOptions();
    
    userChoice = Console.ReadLine();

    switch(userChoice)
    {
        case "S": case "s":
            printToDoList();
            break;

        case "A": case "a":
            AddToList();
            break;

        case "R": case "r":
            RemoveFromList();
            break;

        case "E": case "e":
            userExit = true;
            break;

        default:
            Console.WriteLine("Invalid Input");
            break;
    }

} while (!userExit);

Console.WriteLine("\nPress any key to close");
Console.ReadKey();


void printOptions()
{
    Console.WriteLine(
        "\nToDo Options:"
      + "\n[S]ee list of ToDos"
      + "\n[A]dd a ToDo"
      + "\n[R]emove a ToDo"
      + "\n[E]xit\n");
}

void printToDoList()
{
    if(ToDoList.Count == 0)
    {
        Console.WriteLine("ToDo List is empty.");
        return;
        
    }
    for (int i = 0; i < ToDoList.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {ToDoList[i]}");
    }
}

void AddToList()
{
    string description;
    do
    {
        Console.WriteLine("\nEnter the ToDo Description:\n");
        description = Console.ReadLine();
        
    } while (!IsDescriptionValid(description));

    ToDoList.Add(description);
}

bool IsDescriptionValid(string description)
{
    if(description == "")
    {
        Console.WriteLine("The description cannot be empty.");
        return false;
    }
    if(ToDoList.Contains(description))
    {
        Console.WriteLine("The description must be unique.");
        return false;
    }

    return true;
}

void RemoveFromList()
{
    
    if(ToDoList.Count == 0)
    {
        Console.WriteLine("No ToDos have been added yet.");
        return;
    }

    int index;
    do
    {
        Console.WriteLine("Select the index of the ToDo you want to remove:\n");
        printToDoList();

    } while (!TryReadIndex(out index));

    RemoveToDoAtIndex(index - 1);
}

void RemoveToDoAtIndex(int index)
{
    var todoRemove = ToDoList[index];
    ToDoList.RemoveAt(index);
    Console.WriteLine("ToDo removed: " + todoRemove);
}

bool TryReadIndex(out int index)
{
    var removeAt = Console.ReadLine();
    if (removeAt == "")
    {
        index = 0;
        Console.WriteLine("Selected index cannot be empty.");
        return false;
    }
    if (int.TryParse(removeAt, out index) && index >= 1 && index <= ToDoList.Count)
    {
        return true;
    }
    Console.WriteLine("The given index is not valid.");
    return false;
}