using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingLibrary.Models
{
    public abstract class Car
    {
        public virtual void StartCar()
        {
            Console.WriteLine("Turn key and start");
        }

        public abstract void SetClock();
    }
}
