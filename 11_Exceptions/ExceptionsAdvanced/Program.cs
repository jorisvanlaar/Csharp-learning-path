

string? name = "";

try
{
    SimpleMethod();                     
    DifferentMethod();                  
                                        
    Console.Write("What is your name: ");
    name = Console.ReadLine();
    ComplexMethod(name);                                                                 
}
catch (InvalidOperationException ex)    
{                                       
    Console.WriteLine("Handling an InvalidOperationsException");
    Console.WriteLine(ex.Message);
}
catch (NotImplementedException ex)       
{
    Console.WriteLine("Handling a NotImplementedException");
    Console.WriteLine(ex.Message);
}
catch (Exception) when (name.ToLower() == "joris")              
{                                                                                                                       
    Console.WriteLine("You used Joris' name, didn't you?");
}
catch (Exception ex)                    
{                                       
    Console.WriteLine(ex.Message);      
}
finally                                         
{                                                                                     
    Console.WriteLine("I always run");    
}


static void SimpleMethod()
{
    throw new InvalidOperationException("You should not be calling the SimpleMethod");
}

static void DifferentMethod()
{
    throw new NotImplementedException("You should not be calling the DifferentMethod");
}

static void ComplexMethod(string name)
{
    if (name.ToLower() == "joris")
    {
        throw new InsufficientMemoryException("Joris is too big for this method");
    }
    else
    {
        throw new ArgumentException("This person isn't Joris");
    }
}