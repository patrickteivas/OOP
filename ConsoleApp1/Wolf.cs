using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Wolf : Creature
    {
        public Wolf()
        {
            Name = "Wolf";
            Hitpoints = 50;
            Damage = 15;
            Defence = 10;
            Ranged = false;
        }

        public override int Attack(int hp)
        {
            Console.WriteLine(Name + " bite you!");
            Console.WriteLine(Name + " did " + Damage + " Damage");
            var userHitpoints = hp - Damage;
            Console.WriteLine("User has " + userHitpoints + " hitpoints");
            return userHitpoints;
        }

        public override int SpecialAttack(int hp)
        {
            Console.WriteLine(Name + " double bite you!");
            Console.WriteLine(Name + " did " + (Damage * 2) + " Damage");
            var userHitpoints = hp - (Damage * 2);
            Console.WriteLine("User has " + userHitpoints + " hitpoints");
            return userHitpoints;
        }
    }
}
