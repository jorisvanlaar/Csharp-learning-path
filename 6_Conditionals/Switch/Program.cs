

string firstName = "Joris";
int age = 50;

switch (firstName.ToLower())
{
    case "joris":                               
        Console.WriteLine("Hello Joris");       
        break;                                  
    case "tom":
        Console.WriteLine("Hello Tom");
        break;
    case "bas":                                 
    case "lotte":
        Console.WriteLine("Hello Bas or Lotte");    
        break;
    case "steve" or "ines":                         
        Console.WriteLine("Hello Steve or Ines");
        break;
    default:                                        
        Console.WriteLine("Unknown person");        
        break;                                      
}

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("You are a child");
        break;
    case >= 18 and < 66:
        Console.WriteLine("You're an adult");
        break;
    case >= 66:
        Console.WriteLine("You're a senior");
        break;
    default:
        Console.WriteLine("Unknown age");
        break;
}
