using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Animal : IRun
    {
        public int MaxSpeed { get; set; } = 70;

        public void StartRunning()
        {
            Console.WriteLine("Animal is running");
        }

        public void StopRunning()
        {
            Console.WriteLine("Animal stopped running");
        }

        public void DisplayMaxAnimalSpeed()
        {
            Console.WriteLine($"Max speed of an animal: {MaxSpeed}mph");
        }
    }
}
