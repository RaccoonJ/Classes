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


            //Fundamental data types
            int lives; // declaration
            lives = 3; //initialization

            //Arrays
            int[] ammo; // declaration 
            ammo = new int[5]; // Instantiation
            ammo[0] = 1; //initialization
            ammo[1] = 50; //initialization
            ammo[2] = 30; //initialization
            ammo[3] = 13; //initialization
 

        


        //classes

        Player player = new Player();
            player.health = 100; //Initialization
            player.name = "Raccoon"; //Initialization

            Console.WriteLine("Player health = " + player.health);
            player.TakeDamage(15);
            Console.WriteLine("Player health = " + player.health);

            Enemy enemy = new Enemy();
            Enemy enemySmall = new Enemy();
            Enemy enemyMedium = new Enemy();
            Enemy enemyLarge = new Enemy();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        }
    }
}
