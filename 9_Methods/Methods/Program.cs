using Methods;  


ConsoleMessages.SayHi("Joris");         
ConsoleMessages.SayGoodbye("Bas");      
                                                
string name = ConsoleMessages.GetUserName();
ConsoleMessages.SayHi(name);

double numberOne = ConsoleMessages.GetDouble();
double numberTwo = ConsoleMessages.GetDouble();
Console.WriteLine($"The sum of {numberOne} + {numberTwo} = {MathShortcuts.Add(numberOne, numberTwo)}");

double[] valueCollection = new double[5] {50.5, 123.67, 456, 324.3455, 435.32};
Console.WriteLine($"The sum of all values in the array is: {MathShortcuts.AddAll(valueCollection)}"); 

(string firstName, string lastName) = ConsoleMessages.GetFullName();    
Console.WriteLine($"First Name: {firstName}");     
Console.WriteLine($"Last Name: {lastName}");      
