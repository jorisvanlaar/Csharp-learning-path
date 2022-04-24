using Homework;

AddressModel address = new();
address.Street = "Surinameplein";
address.HouseNumber = "39-3";
address.ZipCode = "1058GM";
address.City = "Amsterdam";
address.Country = "Netherlands";

PersonModel person = new();
person.FirstName = "Joris";
person.LastName = "van Laar";
person.Age = 36;
person.Address = address;

Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age} years old.");
Console.WriteLine($"Lives at {person.Address.Street} {person.Address.HouseNumber}, {person.Address.ZipCode}");
Console.WriteLine($"{person.Address.City}, {person.Address.Country}");
