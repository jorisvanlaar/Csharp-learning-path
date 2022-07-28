

Volkswagen volkswagen = new Volkswagen();
volkswagen.StartCar();

Renault renault = new();
renault.StopCar();


Smartphone smartphone = new Smartphone();
smartphone.PlaceCall();
smartphone.PutInPocket();

smartphone.Apps.Add("Shazam");

List<Phone> phones = new List<Phone>();
phones.Add(new Cellphone());
phones.Add(new Smartphone());

foreach (var phone in phones)
{
    if (phone is Cellphone cell)
    {
        cell.Carrier = "KPN";
    }

    if (phone is Smartphone sp)
    {
        sp.ConnectToInternet();
    }
}
