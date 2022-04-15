using Homework;


double x = RequestData.GetADouble("Enter your first number: ");
double y = RequestData.GetADouble("Enter your second number: ");

double addResult = CalculateData.Add(x, y);
Console.WriteLine($"{x} + {y} = {addResult}");

double subtractResult = CalculateData.Subtract(x, y);
Console.WriteLine($"{x} - {y} = {subtractResult}");

double multiplyResult = CalculateData.Multiply(x, y);
Console.WriteLine($"{x} * {y} = {multiplyResult}");

try
{
    double divideResult = CalculateData.Divide(x, y);
    Console.WriteLine($"{x} / {y} = {divideResult}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
