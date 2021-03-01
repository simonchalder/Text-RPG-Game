using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public static class Rooms
    {
        public static void Room1()
        {
            Console.WriteLine("You enter an empty room, except for a door to the left and a small box in the middle of the floor");
            Console.WriteLine("Options: 1 - Walk through the door, 2 - Pick up the box");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Room2();
            }
            else if (choice == 2)
            {
                Console.WriteLine("You pick up the box and discover it's empty!");
                Rooms.Room1();
            }
            else
            {
                Console.WriteLine("Try again");
                Rooms.Room1();
            }
        }

        public static void Room2()
        {
            Console.WriteLine("You enter an dusty cluttered room. Rubble and wood everywhere suggest the roof partially collapsed years ago. There is a door to the left and one to the right where you can slip through");
            Console.WriteLine("Options: 1 - Search the room, 2 - Go through the left door, 3 - Go through the right door");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("You are searching the rubble when you see the glint of metal. You punge your hand in to grab it but find a spider's nest. You find an old rusty sword but receive a small bite to the hand");
                Rooms.Room2();
            }
            else if (choice == 2)
            {
                Room3();
            }
            else if (choice == 3)
            {
                Room4();
            }
            else
            {
                Console.WriteLine("Try again");
                Room2();
            }
        }

        public static void Room3()
        {
            Console.WriteLine("You enter a long, dark corridor with light at the end suggesting daylight and freedom. An enourmous spider blocks your way however.");
            Console.WriteLine("Options: 1 - Turn around and go back through the door, 2 - Attack the spider, 3 - Attempt to distract the spider and slip past, 4 - Talk to spider, try to reason with it");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Room2();
            }
            else if (choice == 2)
            {
                Battle newBattle = new Battle(100, 100);
                newBattle.commenceBattle();
            }
            else if (choice == 2 && Player.sword == true && Player.shield == true)
            {
                Console.WriteLine("You attack the spider. It attacks ferociously but your shield keeps you safe. You see your opeing and plunge your sword into it's body killing the spider. You exit the dungeon into the daylight!");
                Battle newBattle = new Battle(100, 100);
                newBattle.commenceBattle();
            }
            else if (choice == 3)
            {
                Console.WriteLine("You attempt to distract the spider but realise you have nothing to use. The spider lunges and attacks!");
                Battle newBattle = new Battle(100, 100);
                newBattle.commenceBattle();
            }
            else
            {
                Console.WriteLine("You realise quickly that your feeble attempt leaves you open to the spider's attack and it bites your neck, inflicting a lethal blow - you died!");
                Console.WriteLine("You Died!");
                Environment.Exit(0);
            }
        }

        public static void Room4()
        {
            Console.WriteLine("You enter an empty room, except for a door to the left and a small box in the middle of the floor");
            Console.WriteLine("Options: 1 - Walk through the door, 2 - Pick up the box");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Room3();
            }
            else if (choice == 2)
            {
                Room4();
            }
            else
            {
                Console.WriteLine("Try again");
                Room2();
            }
        }
    }
}
