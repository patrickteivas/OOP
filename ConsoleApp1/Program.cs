using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mängija loomine
            var hp = 100;

            //Vaenlase loomine
            var enemyWolf = new Wolf();
            hp = enemyWolf.Attack(hp);
            Console.WriteLine("");
            hp = enemyWolf.SpecialAttack(hp);
            Console.WriteLine("");

            var FireWolf = new FireWolf();
            hp = FireWolf.Attack(hp);
            Console.WriteLine("");

            var BadMonkey = new BadMonkey();
            hp = BadMonkey.Attack(hp);
            Console.WriteLine("");
            hp = BadMonkey.SpecialAttack(hp);
            Console.WriteLine("");

            var Car = new Cat();
            hp = BadMonkey.Attack(hp);
            Console.WriteLine("");
            hp = Car.SpecialAttack(hp);
        }
    }
}
