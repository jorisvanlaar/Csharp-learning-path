using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class ConsoleMessages
    {
        public static void SayHi(string firstName)
        {
            Console.WriteLine($"Hi {firstName}!");
        }
        
        public static void SayGoodbye(string firstName)
        {
            Console.WriteLine($"Bye {firstName}!");
        }
        
        public static string GetUserName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();
            return output;
        }
        
        public static double GetDouble()
        {
            bool isValidDouble;
            double output;

            do
            {
                Console.Write("Please enter a number you want to add: ");
                string numberText = Console.ReadLine();
                isValidDouble = double.TryParse(numberText, out output);
            } while (isValidDouble == false);

            return output;
        }

        public static (string, string) GetFullName()                  
        {
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();

            return (firstName, lastName);
        }
    }
}
