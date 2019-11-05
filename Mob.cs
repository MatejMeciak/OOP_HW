using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___HW
{
    class Mob
    {
        public Mob(string name, int healthPoints)
        {
            Name = name;
            HealthPoints = healthPoints;
            
        }
        public string Name { get; }
        public int HealthPoints { get; }
        public void Refresh()
        {
            int i = 0;
            foreach (var mob in mobs)
            {
                if (mob[i].HealthPoints > 0)
                    Console.WriteLine($"{mob[i]}");

            
            else
            {
                Console.WriteLine($"{Name} is defeated.");
            }
            }
                
        }

    }
}
