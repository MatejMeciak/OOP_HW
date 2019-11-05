using System;

namespace OOP___HW
{
    class Program
    {
        static void Main(string[] args)
        {
            var dungeon = new Dungeon();
            var weapon = new Weapon(10);
            while (true)
            {
                dungeon.Update();
                weapon.DoDamage(10);

            }
        }
    }
}
