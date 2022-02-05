

bool isComplete = false;

if (isComplete)
{
    Console.WriteLine("The statement was true");
}
else
{
    Console.WriteLine("The statement was false");
}

Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

if (firstName.ToLower() == "joris")           
{
    Console.WriteLine("Hi Joris!");
} 
else
{
    Console.WriteLine($"Hi {firstName}");
}

Console.WriteLine("End of program");
