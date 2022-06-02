using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_homework
{
    internal class Duck : IFly, IQuack
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying..");
        }

        public void Quack()
        {
            Console.WriteLine("Duck is flying..");
        }

        public void SpeedDown(float value)
        {
            Console.WriteLine($"Duck flight speed reduced by {value}.");
        }

        public void SpeedUp(float value)
        {
            Console.WriteLine($"Duck flight speed increased by {value}.");
        }
    }
}
