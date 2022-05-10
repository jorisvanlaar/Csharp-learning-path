using PropertyTypes;


PersonModel person = new();
person.FirstName = "Joris";
person.Age = 36;
person.ISBN = "123456789";          

Console.WriteLine(person.ISBN);     
                                    
PersonModel p = new("Joris", "van Laar", 36, "123456789", "beertje");
Console.WriteLine(p.FullName);
