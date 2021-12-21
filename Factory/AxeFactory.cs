using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponFactory.Weapons;

namespace WeaponFactory.Factory
{
    class AxeFactory : Factory
    {
        /// <summary>
        /// Return Axe
        /// </summary>
        /// <returns></returns>
        public override Weapon GetWeapon()
        {
            return new Axe();
        }
    }
}
