using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponFactory.Weapons;

namespace WeaponFactory.Factory
{
    abstract class Factory
    {
        /// <summary>
        /// Return a wepont type depend on the Factory
        /// </summary>
        /// <returns></returns>
        public abstract Weapon GetWeapon();
    }
}
