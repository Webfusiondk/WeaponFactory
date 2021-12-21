using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponFactory.Weapons
{
    class Hammer : Weapon 
    {
        List<string> names = new List<string>()
        {
            "Claw Hammer",
            "Rubber Mallet",
            "Sledge Hammer",
            "Club Hammer",
            "Dead Blow Hammer",
            "War Hammer"

        };
        public Hammer()
        {
            Type = "Hammer";
            Rarity = CalculateRarity();
            Name = Rarity.ToString() + " " + names[random.Next(1, names.Count)];
            Dammage = CalculateDamage();
            Durablity = CalculateDuablity();
        }
    }
}
