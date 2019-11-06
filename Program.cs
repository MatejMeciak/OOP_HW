using System;
using System.Threading;

namespace OOP___HW
{
    class Program
    {
        static void Main(string[] args)
        {
            var dungeon = new Dungeon();
            dungeon.PrintCurrentMobInfo();
            while (true)
            {
                if (dungeon.IsCompleted())
                {
                    Console.WriteLine("Congratulations!");
                    Thread.Sleep(1000);
                    return;
                }

                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                    dungeon.DoDamage(10);
                else if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("FF");
                    return;
                }
            }
        }
    }
}
