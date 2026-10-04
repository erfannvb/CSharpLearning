
var todoList = new List<string>();

while (true)
{
    Console.WriteLine("\n******************");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");
    Console.WriteLine("******************");

    Console.Write("\nChoose: ");
    var userInput = Console.ReadLine();
    switch (userInput)
    {
        case "s":
        case "S":
            SeeTodos();
            break;

        case "a":
        case "A":
            AddTodo();
            break;

        case "r":
        case "R":
            RemoveTodo();
            break;

        case "e":
        case "E":
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("\nInvalid choice!");
            break;
    }

}

void SeeTodos()
{
    if (todoList.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }

    for (var i = 0; i < todoList.Count; i++)
    {
        var index = i + 1;
        Console.WriteLine($"{index}. {todoList[i]}");
    }
}

void AddTodo()
{
    string? description;
    do
    {

        Console.Write("\nEnter the Todo description: ");
        description = Console.ReadLine();
        if (description == null)
            return;

    } while (!IsDescriptionValid(description));

    todoList.Add(description);
    Console.WriteLine($"Todo successfully added: {description}");
}

void RemoveTodo()
{
    if (todoList.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }

    string? userInput;
    bool isValid;

    do
    {
        Console.WriteLine("\nSelect the index of the todo you want to remove: ");
        for (var i = 0; i < todoList.Count; i++)
        {
            var index = i + 1;
            Console.WriteLine($"{index}. {todoList[i]}");
        }

        userInput = Console.ReadLine();
        if (userInput == null)
            return;

        if (userInput.Length == 0)
        {
            Console.WriteLine("\nSelected index cannot be empty!");
            isValid = false;
            continue;
        }

        bool parsedInput = int.TryParse(userInput, out int num);
        if (num <= 0 || num > todoList.Count)
        {
            Console.WriteLine("\nThe given index is not valid!");
            isValid = false;
            continue;
        }

        todoList.RemoveAt(num - 1);
        isValid = true;

    } while (!isValid);

}

bool IsDescriptionValid(string description)
{
    if (description == "")
    {
        Console.WriteLine("The description cannot be empty.");
        return false;
    }

    if (todoList.Contains(description))
    {
        Console.WriteLine("The description must be unique.");
        return false;
    }

    return true;
}

void ShowNoTodosMessage() => Console.WriteLine("The todo list is empty!");