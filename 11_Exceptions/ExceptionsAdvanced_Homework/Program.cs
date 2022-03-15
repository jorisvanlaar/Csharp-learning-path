

Console.Write("What is your name: ");
string? name = Console.ReadLine();

try
{
    ExceptionMethod();
}
catch (NotImplementedException ex)
{
    Console.WriteLine("The dev has forgotten to complete his code!");
    Console.WriteLine(ex.Message);
}
catch (Exception) when (name.ToLower() == "joris")
{
    Console.WriteLine("Something went wrong, but your name is Joris");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("Our apologies");
}

void ExceptionMethod()
{
    throw new NotImplementedException();
}
