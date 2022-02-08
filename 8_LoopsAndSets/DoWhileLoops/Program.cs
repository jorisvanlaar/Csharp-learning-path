

bool isValidAge;
int age;

// Do While Loop
do
{
    Console.Write("What is your age: ");
    string? ageText = Console.ReadLine();
    isValidAge = int.TryParse(ageText, out age);

    if (isValidAge == false)
    {
        Console.WriteLine("That was an invalid age");
    }
} while (isValidAge == false);

Console.WriteLine($"Your age is {age}");



Console.Write("What is your age: ");
string? ageText2 = Console.ReadLine();
bool isValidAge2 = int.TryParse(ageText2, out int age2);

// While Loop
while (isValidAge2 == false)
{
    Console.Write("What is your age: ");
    string? ageText = Console.ReadLine();
    isValidAge2 = int.TryParse(ageText, out age2);
}

Console.WriteLine($"Your age is {age2}");