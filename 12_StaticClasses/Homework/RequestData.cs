using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public static class RequestData
    {
        public static double GetADouble(string message)
        {
            bool isDouble;
            double output;
            
            do
            {
                Console.Write(message);
                string? doubleText = Console.ReadLine();
                isDouble = double.TryParse(doubleText, out output);
            } while (!isDouble);
            
            return output;
        }
    }
}
