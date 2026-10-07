//////Daclare the Size of ArrayList
int numberForParse;
bool isparsable = false;
do
{
    Console.Write("Input The size Of Your ArrayList : ");
    isparsable = int.TryParse(Console.ReadLine(), out numberForParse);
    if (isparsable == false)
        Console.WriteLine("Incorrect Input!");
    if (isparsable == true && numberForParse <= 0)
    {
        isparsable = false;
        Console.WriteLine("Incorrect Input!");
    }

}
while (!isparsable);


///////Declare Array List
int[] numbers = new int[numberForParse];

for (var i = 0; i < numbers.Length; i++)
{
    int numberIndex;
    bool isparsableIndex = false;
    do
    {
        Console.Write($"Input The Value of {i} Index: ");
        isparsableIndex = int.TryParse(Console.ReadLine(), out numberIndex);
        if (isparsableIndex == false)
            Console.WriteLine("Incorrect Input!");
        else
            numbers[i] = numberIndex;
    }
    while (!isparsableIndex);
}

Console.WriteLine();
Console.WriteLine("1.Sum");
Console.WriteLine("2.Avverage");
Console.WriteLine("3.Max");
Console.WriteLine("4.Min");
Console.WriteLine("5.Count");
Console.WriteLine("6.OddCounter");
Console.WriteLine("7.EvenCounter");
Console.WriteLine();
Console.Write("Input The Number of Operation that you want : ");

////////Select Operators
bool IsAcceptedOperator = false;
string InputMethod = "";
do
{
    InputMethod = Console.ReadLine();
    IsAcceptedOperator = IsAcceptable(InputMethod);
    if (IsAcceptedOperator == false)
        Console.Write("Incorrect Operation Please select Operators Bethween 1 - 7 : ");
}
while (!IsAcceptedOperator);


//////result Show
var Massage = "";
Console.WriteLine();
double result = MathMethod(numbers, int.Parse(InputMethod));
Console.WriteLine($"The {Massage} of your {numberForParse} number is : {result}");


bool IsAcceptable(string OperatorNumber)
{
    if (OperatorNumber == "1" || OperatorNumber == "2" || OperatorNumber == "3"
        || OperatorNumber == "4" || OperatorNumber == "5" || OperatorNumber == "6"
        || OperatorNumber == "7")
        return true;
    else
        return false;
}
;



double MathMethod(int[] ArrayName, int Operation)
{

    double outputResult = 0;
    double sumArray = 0;
    switch (Operation)
    {
        case 1:
            Massage = "Sum";
            foreach (int number in ArrayName)
            {
                sumArray = sumArray + number;
            }
            outputResult = sumArray;
            break;
        case 2:
            Massage = "Avrage";
            foreach (int number in ArrayName)
            {
                sumArray = sumArray + number;
            }
            outputResult = sumArray / ArrayName.Length;
            break;
        case 3:
            Massage = "Max";
            double max = ArrayName[0];
            foreach (int number in ArrayName)
            {
                if (max < number)
                {
                    max = number;
                }
            }
            outputResult = max;
            break;
        case 4:
            Massage = "Min";
            outputResult = ArrayName.Min();
            break;
        case 5:
            Massage = "Count";
            outputResult = ArrayName.Length;
            break;
        case 6:
            Massage = "OddCounter";
            foreach (int numbers in ArrayName)
            {
                if (numbers % 2 != 0)
                {
                    outputResult++;
                }
            }
            break;
        case 7:
            Massage = "EvenCounter";
            foreach (int numbers in ArrayName)
            {
                if (numbers % 2 == 0)
                {
                    outputResult++;
                }
            }
            break;
        default:
            break;
    }
    return outputResult;

}
;
Console.ReadKey();
