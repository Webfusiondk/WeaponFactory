using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponFactory.Weapons
{
    class Sword : Weapon 
    {
        List<string> names = new List<string>()
        {
            "Curtana",
            "Doombringer",
            "Soul-Forged Blade",
            "Lich Glass Carver",
            "Ghost-Forged Shortsword",
            "Lich Glass Carver"
        };
        public Sword()
        {
            Type = "Sword";
            Rarity = CalculateRarity();
            Name = Rarity.ToString() + " " + names[random.Next(1, names.Count)];
            Dammage = CalculateDamage();
            Durablity = CalculateDuablity();
        }
    }
}
