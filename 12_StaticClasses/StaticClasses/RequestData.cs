using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public static class RequestData     
    {
        public static string GetAString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        
        public static double GetADouble(string message)
        {
            double output;
            bool isDouble;

            do
            {
                Console.Write(message);
                string? numberText = Console.ReadLine();
                isDouble = double.TryParse(numberText, out output);
            } while (!isDouble);

            return output;
        }
    }
}
