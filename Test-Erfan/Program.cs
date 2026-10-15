
var user = new User()
{
    FullName = "Erfan Navab",
    Age = 28
};

Console.WriteLine($"FullName: {user.FullName}");
Console.WriteLine($"Age: {user.Age}");

Console.ReadKey();

class User
{
    public string FullName { get; set; }
    public int Age { get; set; }
}