using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_homework
{
    internal class Plaine : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Airplane is flying...");
        }

        public void SpeedDown(float value)
        {
            Console.WriteLine($"Airplane flight speed reduced by {value}.");
        }

        public void SpeedUp(float value)
        {
            Console.WriteLine($"Airplane flight speed increased by {value}.");
        }
    }
}
