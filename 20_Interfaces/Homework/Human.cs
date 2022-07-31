using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Human : IRun
    {
        public int MaxSpeed { get; set; } = 23;

        public void StartRunning()
        {
            Console.WriteLine("Human is running");
        }

        public void StopRunning()
        {
            Console.WriteLine("Human stopped running");
        }

        public void DisplayMaxHumanSpeed()
        {
            Console.WriteLine($"Max speed of a human: {MaxSpeed}mph");
        }
    }
}
