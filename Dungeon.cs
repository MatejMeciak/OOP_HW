using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___HW
{
    class Dungeon
    {
        private readonly List<Mob> mobs;
        public Dungeon()
        {
            mobs = new List<Mob>
            {
                new Mob("Big Foot", 100),
                new Mob("Alien Brain", 150),
                new Mob("Mad Toast", 300),
                new Mob("Dudy", 500),
                new Mob("ULTRABIGSUPERSKELLY", 1000),
            };
                
        }
        public void Update()
        {
            foreach(var mob in mobs)
            {
                mob.Refresh();
            }
        }
    }
                
}