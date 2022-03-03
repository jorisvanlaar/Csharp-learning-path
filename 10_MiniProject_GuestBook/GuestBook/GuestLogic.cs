using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    public static class GuestLogic
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome at the Hilton!");
            Console.WriteLine("We would love for you to sign our guestbook.");
            Console.WriteLine();
        }

        public static string GetPartyName()
        {
            string output;

            do
            {
                Console.Write("What is your party name: ");
                output = Console.ReadLine();

            } while (output == "");
            
            return output;
        }

        public static int GetPartySize()
        {
            int output;
            bool isValidNumber;

            do
            {
                Console.Write("How many are in your party: ");
                string partySizeText = Console.ReadLine();
                isValidNumber = int.TryParse(partySizeText, out output);
            } while (isValidNumber == false);

            return output;
        }

        public static bool AskToContinue()
        {
            Console.Write("Is there another party (y/n): ");
            string continueLooping = Console.ReadLine();
            Console.WriteLine();

            bool output = (continueLooping.ToLower() == "y");

            return output;
        }

        public static (List<string> parties, int total) GetAllGuests()
        {
            List<string> parties = new List<string>();
            int totalGuests = 0;

            do
            {
                parties.Add(GetPartyName());
                totalGuests += GetPartySize();
            } while (AskToContinue());

            return (parties, totalGuests);
        }

        public static void DisplayGuestList(List<string> guestList)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("GUESTBOOK");
            Console.WriteLine("-----------");

            foreach (string party in guestList)
            {
                Console.WriteLine(party);
            }
            Console.WriteLine();
        }

        public static void DisplayGuestCount(int guests)
        {
            Console.WriteLine($"Total guests: {guests}");
        }
    }
}
