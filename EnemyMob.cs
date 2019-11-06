using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___HW
{
    class EnemyMob
    {
        public EnemyMob(string name, int healthPoints)
        {
            Name = name;
            HealthPoints = healthPoints;
            
        }
        public string Name { get; }
        public int HealthPoints { get; set; }
        public void PrintInfo()
        {
            if (HealthPoints > 0)
                Console.WriteLine($"{Name} : {HealthPoints}");
            else
                Console.WriteLine($"{Name} is defeated.");
        }

    }
}
