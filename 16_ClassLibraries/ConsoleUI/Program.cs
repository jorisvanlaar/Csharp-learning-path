using DemoLibrary;
using DemoLibrary.Models;


Calculation.Add(2, 3);     
                                
PersonModel person = new("Joris", "van Laar");     

string firstName = UserMessages.GetString("What is your first name: "); 
string lastName = UserMessages.GetString("What is your last name: ");
PersonModel person2 = new(firstName, lastName);
UserMessages.Greet(person2.FirstName, person2.LastName);    
