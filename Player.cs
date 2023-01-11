using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Player
    {
        //player
        int x;
        int y;
        public int health;
        public int shield;
        public int lives;
        public string name;

        public Player() // Constructor
        {
            Console.WriteLine("Player class constructed...");
            x = 0;
            y = 0;
            name = "Raccoon";
            health = 50;
        }
        public void TakeDamage(int hp)
        {
            health -= hp;
        }
    }
}
