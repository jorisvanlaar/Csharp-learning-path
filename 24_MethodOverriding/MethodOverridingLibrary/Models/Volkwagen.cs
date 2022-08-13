using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingLibrary.Models
{
    public class Volkswagen : Car                   
    {
        public override void SetClock()
        {
            Console.WriteLine("Manually setting clock for Volkwagen");
        }
    }
}
