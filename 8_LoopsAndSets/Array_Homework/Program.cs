

string[] firstNames = new string[] { "Bas", "Stefan", "Joris" };

bool isValidNumber;
int number;

do
{
    Console.Write("Please choose a number between 0 and 2: ");
    string? numberText = Console.ReadLine();

    isValidNumber = int.TryParse(numberText, out number);

} while (isValidNumber == false || (number < 0 || number > 2));

Console.WriteLine(firstNames[number]);