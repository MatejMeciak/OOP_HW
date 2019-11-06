using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OOP___HW
{
    class Dungeon
    {
        private readonly List<EnemyMob> mobs;
        public Dungeon()
        {
            mobs = new List<EnemyMob>
            {
                new EnemyMob("Big Foot", 100),
                new EnemyMob("Alien Brain", 150),
                new EnemyMob("Mad Toast", 300),
                new EnemyMob("Dudy", 500),
                new EnemyMob("ULTRABIGSUPERSKELLY", 1000),
            };
                
        }
        public void PrintCurrentMobInfo() => GetCurrentMob()?.PrintInfo();

        public void DoDamage(int damage)
        {
            var mob = GetCurrentMob();

            mob.HealthPoints -= damage;
            mob.PrintInfo();

            if (mob.HealthPoints <= 0)
                PrintCurrentMobInfo();
        }

        public bool IsCompleted() => !mobs.Where(mob => mob.HealthPoints > 0).Any();

        private EnemyMob GetCurrentMob() => mobs.Where(mob => mob.HealthPoints > 0).FirstOrDefault();
    }
                
}