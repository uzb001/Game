using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lion : Hero
    {
        public readonly int NormalHealth = 50;

        public Lion(string name, int attackStrength, double speed, int health)
            : base(name,attackStrength, speed, health)
        {

        }
        public override void Run()
        {
            if(NormalHealth > Health)
            {
                Console.WriteLine($"{Name} speed decreased to = {Speed * 0.6}");
            }
            else
            {
                Console.WriteLine($"{Name} speed = {Speed}");
            }
        }
    }
}
