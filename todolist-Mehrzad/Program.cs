using System.Collections;

var todoList = new List<string> { };

Console.WriteLine("Hello!");
bool IsAcceptedString = false;
string InputMethod = "";
do
{
    MenuOrdering();
    InputMethod = Console.ReadLine();
    IsAcceptedString = IsAcceptable(InputMethod);
    if (IsAcceptedString == false)
    {
        Console.WriteLine("Invalid choice.");
    }
    switch (InputMethod)
    {
        case "A":
        case "a":
            bool isValid = false;
            do
            {
                Console.Write("Enter the todo description: ");
                var description = Console.ReadLine();

                if (description.Length == 0)
                {
                    Console.WriteLine("Description cannot be empty");
                    continue;
                }
                if (todoList.Count > 0)
                {
                    bool uniqe = false;
                    for (var i = 0; i < todoList.Count; i++)
                    {
                        if (todoList[i] == description)
                        {
                            uniqe = true;
                            Console.WriteLine("the description must be uniqe");
                            continue;
                        }
                    }
                    if (uniqe == true)
                    {
                        continue;
                    }
                }

                isValid = true;
                todoList.Add(description);
                Console.WriteLine($"Todo successfully added: {description}");
                IsAcceptedString = false;

            } while (!isValid);
            break;

        case "S":
        case "s":

            if (todoList.Count == 0)
            {
                Console.WriteLine("Nothing inthe list.");
                IsAcceptedString = false;
                continue;
            }
            int orernum = 0;
            foreach (string dolist in todoList)
            {
                orernum++;
                Console.WriteLine($"{orernum}.{dolist}");
            }
            IsAcceptedString = false;
            break;

        case "R":
        case "r":

            if (todoList.Count == 0)
            {
                Console.WriteLine("Nothing to remove from the list.");
                IsAcceptedString = false;
                continue;
            }
            Console.WriteLine("Select the index of the TODO you want to remove");
            int orernum2 = 0;
            foreach (string dolist in todoList)
            {
                orernum2++;
                Console.WriteLine($"{orernum2}.{dolist}");
            }
            bool isparsable = false;
            int numberForParse = 0;
            do
            {
                isparsable = int.TryParse(Console.ReadLine(), out numberForParse);
                if (numberForParse > orernum2 && orernum2 < 0)
                {
                    ShowOutofRangeMassege();
                    Console.WriteLine("Select the index of the TODO you want to remove");
                    isparsable = false;
                }
            }
            while (!isparsable);
            var RemoveString = todoList[numberForParse - 1];
            todoList.Remove(RemoveString);
            ///todoList.RemoveAt(numberForParse - 1);
            Console.WriteLine($"TODO removed: {RemoveString}");
            IsAcceptedString = false;
            break;
        default:
            break;
    }
}
while (!IsAcceptedString);

bool IsAcceptable(string EntryString)
{
    if (EntryString == "s" || EntryString == "S" || EntryString == "A"
        || EntryString == "a" || EntryString == "R" || EntryString == "r"
        || EntryString == "E" || EntryString == "e")
        return true;
    else
        return false;
}
;
void MenuOrdering()
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do ?");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");
    Console.WriteLine();
}
;

void ShowOutofRangeMassege()
{
    Console.WriteLine("Your Index is out of the range.");
}