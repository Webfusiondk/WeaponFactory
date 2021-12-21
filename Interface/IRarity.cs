using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponFactory.Weapons;

namespace WeaponFactory.Interface
{
    interface IRarity
    {
        WeaponRaity CalculateRarity();
    }
}
