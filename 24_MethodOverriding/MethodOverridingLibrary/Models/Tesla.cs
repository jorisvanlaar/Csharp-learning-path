using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingLibrary.Models
{
    public class Tesla : Car            
    {
        public override void SetClock()
        {
            Console.WriteLine("Tesla clock sets itself automatically");
        }

        public override void StartCar()
        {
            Console.WriteLine("Press start button");
        }
    }
}
