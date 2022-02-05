

Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

Console.Write("What is your last name: ");
string? lastName = Console.ReadLine();

if (firstName.ToLower() == "joris" && lastName.ToLower() == "van laar")
{
    Console.WriteLine("Hello Mr. van Laar");
}
else if (firstName.ToLower() == "joris")
{
    Console.WriteLine("You have a cool first name.");
}
else if (lastName.ToLower() == "van laar")
{
    Console.WriteLine("You have a great last name.");
}
else
{
    Console.WriteLine("Not the name we're looking for unfortunately");
}


if (firstName.ToLower() == "joris")
{
    Console.WriteLine("Nice first name");
}
if (lastName.ToLower() == "van laar")
{
    Console.WriteLine("Nice last name");
}
else
{
    Console.WriteLine("Not so nice name");
}


int age = 45;

if (age >= 100)
{
    Console.WriteLine("You are up there in years");
} 
else if (age < 100)
{
    Console.WriteLine("You still have a ways to go");
}
else
{
    Console.WriteLine("Input error");
}

if (age >= 40 && age < 50)
{
    Console.WriteLine("You are in your 40's");
}
if (age == 50 || age == 100)
{
    Console.WriteLine("You are either 50 or a 100 years old");
}
if (age != 43)
{
    Console.WriteLine("You aren't 43 years old");
}
if ((age >= 40 && age < 50) || (age >= 70 && age < 80))
{
    Console.WriteLine("You are in your 40's or 70's");
}
