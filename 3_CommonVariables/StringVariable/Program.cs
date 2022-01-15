

string firstName = string.Empty;
string lastName = string.Empty;
string escapeCharacter = string.Empty;
string filePath = string.Empty;
string filePathStringLiteral = string.Empty;

firstName = "Joris";
lastName = "van Laar";

escapeCharacter = "This is a \nnew line escape character";
filePath = "C:\\Temp\\Demo";
filePathStringLiteral = @"C:\Temp\Demo";

string stringInterpolationLiteralCombi = $@"The file for {firstName} is at C:\Temp\Demo";

Console.WriteLine(firstName + " " + lastName);
Console.WriteLine($"{firstName} {lastName}");

Console.WriteLine(escapeCharacter);
Console.WriteLine(filePath);
Console.WriteLine(filePathStringLiteral);

Console.WriteLine(stringInterpolationLiteralCombi);

Console.ReadLine();