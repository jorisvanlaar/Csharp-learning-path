

List<string> firstNames = new List<string>();
string? firstName;

do
{
    Console.Write("Enter a first name (type 'exit' to quit): ");
    firstName = Console.ReadLine();

    if (firstName != "" && firstName.ToLower() != "exit")
    {
        firstNames.Add(firstName);
    }
} while (firstName.ToLower() != "exit");

foreach (string name in firstNames)
{
    Console.WriteLine($"Hello {name}");
}