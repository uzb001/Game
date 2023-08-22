using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Murlock:Hero
    {
        public int NightAttack { get; set; }
        public double NightSpeed { get; set; }
        public Murlock(string name, int attackStrength, double speed, int health)
            : base(name, attackStrength, speed, health)
        {
            NightAttack = AttackStrength + 10;
            NightSpeed = Speed + 20;
        }

        public override void Attack()
        {
            if (DateTime.Now.Hour > 19 && DateTime.Now.Hour < 4)
            {
                Console.WriteLine($"{Name} Attacking with strength {NightAttack}");
            }
            else
            {
                Console.WriteLine($"{Name} attacking with strength {AttackStrength}");
            }
        }
        public override void Run()
        {
            if (DateTime.Now.Hour > 19 && DateTime.Now.Hour < 4)
            {
                Console.WriteLine($"{Name} Speed = {NightSpeed}");
            }
            else
            {
                Console.WriteLine($"{Name} Speed = {Speed}");
            }
        }
    }
}
