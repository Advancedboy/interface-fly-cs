using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plaine plaine = new Plaine();
            Duck duck = new Duck();
            plaine.Fly();
            plaine.SpeedUp(10f);
            plaine.SpeedDown(1.123f);
            duck.Fly();
            duck.SpeedDown(0f);
            duck.SpeedUp(123f);

        }
    }
}
