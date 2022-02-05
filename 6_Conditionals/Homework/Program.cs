

Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

if (firstName.ToLower() == "tim" || firstName.ToLower() == "timothy")
{
    Console.WriteLine("Hello professor");
}
else
{
    Console.WriteLine("Hello student");
}

