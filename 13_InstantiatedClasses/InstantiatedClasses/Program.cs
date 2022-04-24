using InstantiatedClasses;  


List<PersonModel> people = new();
string firstName = "";

do
{
    Console.Write("What is your first name (or type exit to stop): ");
    firstName = Console.ReadLine();

    if (firstName.ToLower() != "exit")
    {
        Console.Write("What is your last name: ");
        string lastName = Console.ReadLine();

        Console.Write("What is your email: ");
        string emailAddress = Console.ReadLine();
        Console.WriteLine();

        PersonModel person = new();
        person.FirstName = firstName;
        person.LastName = lastName;
        person.EmailAddress = emailAddress;
        people.Add(person);
    }
} while (firstName.ToLower() != "exit");

foreach (PersonModel p in people)
{
    ProcessPerson.GreetPerson(p);   
}
