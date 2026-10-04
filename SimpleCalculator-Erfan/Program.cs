
int firstNumber;
string? firstInput;
bool firstIsValid;

do
{
    Console.Write("Enter the first number: ");
    firstInput = Console.ReadLine();

    firstIsValid = int.TryParse(firstInput, out firstNumber);
    if (!firstIsValid)
    {
        Console.WriteLine("Invalid input!");
    }

} while (!firstIsValid);

int secondNumber;
string? secondInput;
bool secondIsValid;

do
{
    Console.Write("Enter the second number: ");
    secondInput = Console.ReadLine();

    secondIsValid = int.TryParse(secondInput, out secondNumber);
    if (!secondIsValid)
    {
        Console.WriteLine("Invalid input!");
    }
} while (!secondIsValid);

Console.WriteLine();

Console.Write("Choose an operator (+ * - /): ");
string op = Console.ReadLine() ?? "";

var result = 0;
switch (op)
{
    case "+":
        result = firstNumber + secondNumber;
        Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
        break;
    case "*":
        result = firstNumber * secondNumber;
        Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
        break;
    case "-":
        result = firstNumber - secondNumber;
        Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
        break;
    case "/":
        result = firstNumber / secondNumber;
        Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
        break;
    default:
        Console.WriteLine("Invalid operator!");
        break;
}
Console.WriteLine("Shit message from mehrzad !");

Console.ReadKey();