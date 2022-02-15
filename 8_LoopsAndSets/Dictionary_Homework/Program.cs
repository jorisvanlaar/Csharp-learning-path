

Dictionary<int, string> employees = new Dictionary<int, string>();
employees.Add(1, "Joris van Laar");
employees.Add(2, "Bas Roding");
employees.Add(3, "Stefan Mensen");
employees.Add(4, "Stefan Wijnker");
employees.Add(5, "Mark Bouwman");
employees.Add(6, "Eamon Woortman");

Console.Write("What is your employee ID: ");
string? idText = Console.ReadLine();

bool isValidId = int.TryParse(idText, out int id);

if (isValidId && (id > 0 && id < 7))
{
    Console.WriteLine($"Hello {employees[id]}");
}
