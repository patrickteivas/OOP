using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BadMonkey : Creature
    {
        public BadMonkey()
        {
            Name = "BadMonkey";
            Hitpoints = 60;
            Damage = 20;
            Defence = 5;
            Ranged = true;
        }

        public override int SpecialAttack(int hp)
        {
            Console.WriteLine(Name + " is throwing a double banana at you!");
            Console.WriteLine(Name + " did " + (Damage * 2) + " Damage");
            var userHitpoints = hp - (Damage * 2);
            Console.WriteLine("User has " + userHitpoints + " hitpoints");
            return userHitpoints;
        }
    }
}
