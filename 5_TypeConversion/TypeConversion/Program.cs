

Console.Write("What is your age: ");
string? ageText = Console.ReadLine();

// Conversion with Parse
int age = int.Parse(ageText);
Console.WriteLine($"Your age in 10 years: {age + 10}");

// Conversion with TryParse
int age2;                                                    
bool isValidAge = int.TryParse(ageText, out age2);           

if (isValidAge)
{
    Console.WriteLine($"Your age in 10 years: {age2 + 10}");
}
else
{
    Console.WriteLine("That's an invalid number");
}

bool isValidAge3 = int.TryParse(ageText, out int age3);                                                                 
Console.WriteLine($"age3: {age3}");                         

// Implicit conversion
int numberInt = 50;                 
double numberDouble = numberInt;    
                                    
// Casting
decimal numberDecimal = (decimal)numberDouble;
