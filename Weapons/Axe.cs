using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponFactory.Interface;
namespace WeaponFactory.Weapons
{
    class Axe : Weapon
    {
        List<string> names = new List<string>()
        {
            "BLACK AXE",
            "POWER AXE",
            "BATTLE AXE",
            "GOREHOWL",
            "GORECHILD"
        };

        public Axe()
        {
            Type = "Axe";
            Rarity = CalculateRarity();
            Name = Rarity.ToString() + " " + names[random.Next(1,names.Count)];
            Dammage = CalculateDamage();
            Durablity = CalculateDuablity();
        }
    }
}
