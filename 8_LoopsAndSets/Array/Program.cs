

string[] firstNames = new string[5];    

firstNames[0] = "Tim";                  
firstNames[1] = "Sue";
firstNames[2] = "Bob";
firstNames[4] = "Jane";

Console.WriteLine($"The first firstName is: {firstNames[0]}");  
firstNames[0] = "Timothy";              

string data = "Tim,Sue,Bob,Jane,Frank";     
string[] firstNamesCsv = data.Split(',');   
Console.WriteLine(firstNamesCsv[0]);        
Console.WriteLine(firstNamesCsv.Length);    
Console.WriteLine(firstNamesCsv[firstNamesCsv.Length - 1]); 

string[] lastNames = new string[] { "Corey", "Smith", "Jones" };

int[] ages = new int[] { 2, 3, 4 };

