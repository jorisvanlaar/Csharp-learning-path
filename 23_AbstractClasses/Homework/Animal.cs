using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public abstract class Animal : IMobile
    {
        public string Species { get; set; }

        public void Move()
        {
            Console.WriteLine($"{Species} is moving");
        }
    }
}
