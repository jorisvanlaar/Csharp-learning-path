using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public static class ConsoleMessages
    {
        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome!");
        }

        public static string AskUserName()
        {
            Console.Write("What is your name: ");
            return Console.ReadLine();
        }

        public static void GreetUser(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
