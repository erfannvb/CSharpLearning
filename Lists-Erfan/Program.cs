
var contact = new Contact();

var john = new Person();
john.FirstName = "John";
john.LastName = "Doe";
john.PhoneNumber = 487963;

contact.AddPerson(john);

contact.ShowContactList();

Console.ReadKey();

class Contact
{
    private List<Person> _personList;

    public Contact()
    {
        this._personList = new List<Person>();
    }

    public void AddPerson(Person person)
    {
        if (_personList.Contains(person))
            Console.WriteLine("Person already exists!");
        else
            _personList.Add(person);
    }

    public void ShowContactList()
    {
        foreach (var person in _personList)
        {
            Console.WriteLine("*****************");
            Console.WriteLine($"FirstName: {person.FirstName}");
            Console.WriteLine($"LastName: {person.LastName}");
            Console.WriteLine($"PhoneNumber: {person.PhoneNumber}");
            Console.WriteLine("*****************");
        }
    }
}

class Person
{
    public string FirstName
    {
        get;
        set;
    }

    public string LastName
    {
        get;
        set;
    }

    public Int32 PhoneNumber { get; set; }

    public Person()
    {

    }

    public Person(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}