using WeaponFactory.Factory;
using WeaponFactory.Weapons;

while (true)
{
    Random r = new Random(Guid.NewGuid().GetHashCode());
    Factory factory = ChoseRandomFactory(r.Next(1,3));
    if (factory != null)
    {
        PrintWeapon(factory.GetWeapon());
    }
    Console.ReadKey();
}
Factory ChoseRandomFactory(int r)
{
    switch (r)
    {
        case 1:
            Factory axeFactory = new AxeFactory();
            return axeFactory;
        case 2:
            Factory hammerFactory = new HammerFactory();
            return hammerFactory;
        case 3:
            Factory swordFactory = new SwordFactory();
            return swordFactory;
        default:
            return null;
            break;
    }
}

void PrintWeapon(Weapon weapon)
{
    Console.WriteLine("Type: " + weapon.Type);
    RarityToColor(weapon.Rarity);
    Console.WriteLine("Name: " + weapon.Name);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Durability: " + weapon.Durablity);
    Console.WriteLine("Dammage: " + weapon.Dammage);
    Console.WriteLine("\n");
}

void RarityToColor(WeaponRaity raity)
{
    switch (raity)
    {
        case WeaponRaity.Commen:
            Console.ForegroundColor = ConsoleColor.White;
            break;
        case WeaponRaity.Rare:
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        case WeaponRaity.Epic:
            Console.ForegroundColor = ConsoleColor.Blue;
            break;
        case WeaponRaity.Legendarry:
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
        default:
            break;
    }
}

