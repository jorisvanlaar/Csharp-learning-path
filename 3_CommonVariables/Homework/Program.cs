

Console.Write("What is the person's name: ");
string? name = Console.ReadLine();

Console.Write("What is the person's age (number): ");
string? ageText = Console.ReadLine();
int age;
bool isInt = int.TryParse(ageText, out age);

Console.Write("Is the person alive (Y/N): ");
string? isAliveText = Console.ReadLine();
bool? isAlive = null;
if (isAliveText == "Y" || isAliveText == "y")
{
    isAlive = true;
}
else if (isAliveText == "N" || isAliveText == "n")
{
    isAlive = false;
}

Console.Write("What is the person's phone number: ");
string? phoneNumber = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Alive: {isAlive}");
Console.WriteLine($"Phone number: {phoneNumber}");

Console.ReadLine();