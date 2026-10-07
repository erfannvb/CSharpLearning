Console.Write("How many numbers do you want to add: ");
string userInput = Console.ReadLine();
bool isParsable = int.TryParse(userInput, out int userCount);

var arrayNumber = new ArrayNumber(userCount);

if (isParsable)
{
    for (var i = 0; i < userCount; i++)
    {
        var index = i + 1;
        Console.Write($"Enter #{index}: ");
        string eachNumber = Console.ReadLine();
        arrayNumber.NumArray[i] = int.Parse(eachNumber);
    }

    arrayNumber.ShowNumbers();
    var sum = arrayNumber.CalculateSum();
    Console.WriteLine("Sum: " + sum);


} else
{
    Console.WriteLine("Invalid input!");
}

Console.ReadKey();

class ArrayNumber
{
    public int[] NumArray { get; private set; }

    public ArrayNumber(int size)
    {
        this.NumArray = new int[size];
    }

    public void ShowNumbers()
    {
        foreach(var num in NumArray)
        {
            Console.WriteLine(num);
        }
    }

    public int CalculateSum()
    {
        return NumArray.Sum();
    }
}