using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Creature
    {
        protected string Name;
        protected int Hitpoints;
        protected int Damage;
        protected int Defence;
        protected bool Ranged;

        public virtual int Attack(int hp)
        {
            Console.WriteLine(Name + " attacked you!");
            Console.WriteLine(Name + " did " + Damage + " Damage");
            var userHitpoints = hp - Damage;
            Console.WriteLine("User has " + userHitpoints + " hitpoints");
            return userHitpoints;
        }

        public abstract int SpecialAttack(int hp);
    }
}
