

string? exit;

do
{   
    Console.Write("What is your first name: ");
    string? firstName = Console.ReadLine();

    if (firstName.ToLower() == "tim")
    {
        Console.WriteLine($"Welcome Professor {firstName}");
    }
    else
    {
        Console.WriteLine($"Welcome {firstName}");
    }

    Console.Write("Type 'exit' if you want to stop: ");
    exit = Console.ReadLine();

} while (exit.ToLower() != "exit");