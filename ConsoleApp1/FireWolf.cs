using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FireWolf : Wolf
    {
        public FireWolf()
        {
            Name = "Firewolf";
            Hitpoints = 100;
            Damage = 50;
        }

        public override int Attack(int hp)
        {
            var userHitpoints = base.Attack(hp);
            return userHitpoints;
        }
    }
}
