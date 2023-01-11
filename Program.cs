using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes");
            Console.WriteLine("-------");
            Console.WriteLine("");

            //single piece of data
            int lives; // declaration
            lives = 3; //initialization

            //multiple pieces of data
            int[] ammo; // declaration 
            ammo = new int[5]; // not initialization
            ammo[0] = 1;
            ammo[1] = 50;
            ammo[2] = 30;
            ammo[4] = 13;
            ammo[5] = 53;

            Player player = new Player();

            Enemy enemy = new Enemy();
            Enemy enemySmall = new Enemy();
            Enemy enemyMedium = new Enemy();
            Enemy enemyLarge = new Enemy();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        }
    }
}
