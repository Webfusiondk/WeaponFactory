using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponFactory.Weapons;

namespace WeaponFactory.Factory
{
    class HammerFactory : Factory
    {
        /// <summary>
        /// Return Hammer
        /// </summary>
        /// <returns></returns>
        public override Weapon GetWeapon()
        {
            return new Hammer();
        }
    }
}
