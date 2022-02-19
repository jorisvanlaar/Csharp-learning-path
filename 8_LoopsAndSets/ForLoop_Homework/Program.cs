

Console.Write("Please enter a comma-separated list of first names: ");
string? names = Console.ReadLine();
string[] firstNames = names.Split(',');

for (int i = 0; i < firstNames.Length; i++)
{
    Console.WriteLine($"Hello {firstNames[i]}");
}
