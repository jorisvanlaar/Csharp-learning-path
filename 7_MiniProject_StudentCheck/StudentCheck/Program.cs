/*
 * Build a console application that asks a user for their name and age.
 * If their name is Bob or Sue, address them as Professor.
 * If the person is under 21, recommend they wait X years to start this class.
 */

Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

Console.Write("What is your age: ");
string? ageText = Console.ReadLine();
bool isValidAge = int.TryParse(ageText, out int age);

string formattedName;

if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    formattedName = $"Professor {firstName}";
}
else
{
    formattedName = firstName;
}

if (isValidAge)
{                                           
    if (age < 21)
    {
        Console.WriteLine($"You have to wait {21 - age} years before you can start this class, {formattedName}");
    }
    else
    {
        Console.WriteLine($"Welcome to the class {formattedName}");
    }
}
else
{
    Console.WriteLine("You did not provide a valid age");
}
