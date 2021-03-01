using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Enemies
    {
        public int health;

        public Enemies(int aHealth)
        {
            health = aHealth;
        }

        public void playerAttack()
        {
            Random dice = new Random();
            int diceRoll = dice.Next(01, 100);
            if (diceRoll >= 30)
            {
                Console.WriteLine("Monster Hits");
                Console.WriteLine("You receive 20 damage");
                takeDamage(20);
                Console.WriteLine("Press any key to continue");
            }
            else
            {
                Console.WriteLine("Monster Misses");
                Console.WriteLine("Press any key to continue");
            }
        }

        public void takeDamage(int num)
        {
            health = health - num;
        }
    }
}
