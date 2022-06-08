using GuestBookLibrary.Models;


List<GuestModel> guests = new();
GetGuestInformation(guests);
PrintGuestInformation(guests);


static string GetInfoFromConsole(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

static void GetGuestInformation(List<GuestModel> guests)
{
    string moreGuestsComing = "";

    do
    {
        GuestModel guest = new();

        guest.FirstName = GetInfoFromConsole("What is your first name: ");
        guest.LastName = GetInfoFromConsole("What is your last name: ");
        guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");
        guests.Add(guest);

        moreGuestsComing = GetInfoFromConsole("Are more guests coming (yes/no): ");

        Console.Clear();
    } while (moreGuestsComing.ToLower() == "yes");
}

static void PrintGuestInformation(List<GuestModel> guests)
{
    foreach (GuestModel guest in guests)
    {
        Console.WriteLine(guest.GuestInfo);
    }
}
