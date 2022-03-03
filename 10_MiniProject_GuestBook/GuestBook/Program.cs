using GuestBook;


GuestLogic.WelcomeMessage();
(List<string> parties, int totalGuests) = GuestLogic.GetAllGuests();
GuestLogic.DisplayGuestList(parties);
GuestLogic.DisplayGuestCount(totalGuests);

