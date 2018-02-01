using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cat : Creature
    {
        public Cat()
        {
            Name = "Cat";
            Damage = 4;
        }

        public int Attack(int hp)
        {
            Console.WriteLine(Name + " meowes at you!");
            Console.WriteLine(Name + " did " + Damage + " Damage");
            var userHitpoints = hp - Damage;
            Console.WriteLine("User has " + userHitpoints + " hitpoints");
            return userHitpoints;
        }

        public override int SpecialAttack(int hp)
        {
            Console.WriteLine(Name + " double meowes at you!");
            Console.WriteLine(Name + " did " + (Damage * 2) + " Damage");
            var userHitpoints = hp - (Damage * 2);
            Console.WriteLine("User has " + userHitpoints + " hitpoints");
            return userHitpoints;
        }
    }
}
