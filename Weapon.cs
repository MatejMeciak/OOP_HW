using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___HW
{
    class Weapon
    {
        public Weapon(int damage)
        {
            Damage = damage; 
        }
        
        public int Damage { get; }

        public int DoDamage(int Damage)
        {
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                return Damage;
            }
            return 0;//////////
        }
    }
}

