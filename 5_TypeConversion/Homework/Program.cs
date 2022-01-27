

Console.Write("What is your age: ");
string? ageText = Console.ReadLine();

bool isValidAge = int.TryParse(ageText, out int age);

if (isValidAge)
{
    Console.WriteLine($"You were {age - 25} 25 years ago.");
    Console.WriteLine($"You will be {age + 25} in 25 years.");
}
else
{
    Console.WriteLine("That is not a valid age.");
}
