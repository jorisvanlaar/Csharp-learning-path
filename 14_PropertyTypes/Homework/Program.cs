using Homework;


StreetAddressModel streetAddress = new("Weteringschans", 86, "HS");
AddressModel address = new(streetAddress, "Amsterdam", "Noord Holland", "1017XS");

Console.WriteLine(address.FullAddress);
