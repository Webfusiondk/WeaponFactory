using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponFactory.Interface;

namespace WeaponFactory.Weapons
{
    enum WeaponRaity
    {
        Commen,
        Rare,
        Epic,
        Legendarry

    }

    abstract class Weapon: IRarity
    {
        public Random random = new Random(Guid.NewGuid().GetHashCode());
        public string Name { get; set;}
        public int Durablity { get; set;}
        public float Dammage { get; set;}
        public string Type { get; set;}
        public WeaponRaity Rarity { get; set;}

        /// <summary>
        /// caulate the weapon raity from a random
        /// </summary>
        /// <returns></returns>
        public virtual WeaponRaity CalculateRarity() 
        {
            int randomNum = random.Next(1, 100);
            if (randomNum <= 65)
                return WeaponRaity.Commen;
            else if (randomNum >= 66 && randomNum <= 85)
                return WeaponRaity.Rare;
            else if (randomNum >= 86 && randomNum <= 95)
                return WeaponRaity.Epic;
            else if (randomNum >= 96 && randomNum <= 100)
                return WeaponRaity.Legendarry;
            return WeaponRaity.Commen;
        }

        /// <summary>
        /// calculate the weapon duablity from a random
        /// </summary>
        /// <returns></returns>
        public virtual int CalculateDuablity()
        {
            if (Rarity == WeaponRaity.Commen)
                return random.Next(10, 45);
            else if (Rarity == WeaponRaity.Rare)
                return random.Next(45, 65);
            else if (Rarity == WeaponRaity.Epic)
                return random.Next(65, 80);
            else if (Rarity == WeaponRaity.Legendarry)
                return random.Next(80, 100);
            return 10;
        }

        /// <summary>
        /// calculate the weapon dammage from a random
        /// </summary>
        /// <returns></returns>
        public virtual float CalculateDamage()
        {
            if (Rarity == WeaponRaity.Commen)
                return random.Next(100, 200);
            else if (Rarity == WeaponRaity.Rare)
                return random.Next(200, 350);
            else if (Rarity == WeaponRaity.Epic)
                return random.Next(350, 400);
            else if (Rarity == WeaponRaity.Legendarry)
                return random.Next(450, 700);
            return 70;
        }
    }
}
