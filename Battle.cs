using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Battle
    {
        int playerHealth;
        int monsterHealth;

        public Battle(int aPlayerHealth, int aMonsterHealth)
        {
            playerHealth = aPlayerHealth;
            monsterHealth = aMonsterHealth;
        }

        public void playerAttack()
        {
            Random dice = new Random();
            int diceRoll = dice.Next(01, 100);
            {
                if (diceRoll <= 41)
                {
                    Console.WriteLine($"Dice roll: {diceRoll}");
                    Console.WriteLine("Your Attack Hits");
                    Console.WriteLine("You inflict 20 damage");                      
                    monsterHealth = monsterHealth - 20;
                    Console.WriteLine($"Monster Health is now {monsterHealth}");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    if (monsterHealth < 1)
                    {
                        Console.WriteLine("You win the game!");
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        monsterAttack();
                    }
                    
                }
                else
                {
                    Console.WriteLine($"Dice roll: {diceRoll}");
                    Console.WriteLine("You Miss");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    monsterAttack();
                }

            }
        }

        public void monsterAttack()
        {
            Random dice = new Random();
            int diceRoll = dice.Next(01, 100);
            {
                if (diceRoll <= 41)
                {
                    Console.WriteLine($"Dice roll: {diceRoll}");
                    Console.WriteLine("Monster Attack Hits");
                    Console.WriteLine("Monster inflicts 20 damage");
                    playerHealth = playerHealth - 20;
                    Console.WriteLine($"Player Health is now {playerHealth}");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    if (playerHealth < 1)
                    {
                        Console.WriteLine("You Died!");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        playerAttack();
                    }
                    
                }
                else
                {
                    Console.WriteLine($"Dice roll: {diceRoll}");
                    Console.WriteLine("Monster attack misses");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    playerAttack();
                }
            }
        }

        public void commenceBattle()
        {
                playerAttack();
        }
    }
}
