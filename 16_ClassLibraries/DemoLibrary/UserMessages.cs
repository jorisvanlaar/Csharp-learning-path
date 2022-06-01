using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class UserMessages
    {
        public static string GetString(string message)
        {
            Console.Write(message);
            
            string output = Console.ReadLine();
            return output;
        }

        public static void Greet(string firstName, string lastName)
        {
            Console.WriteLine($"Hello {firstName} {lastName}");
        }
    }
}
