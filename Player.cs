using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Player
    {
        public static bool sword;
        public static bool shield;
        public static bool torch;
        public static bool key1;
        public static bool key2;

        public Player(bool aSword, bool aShield, bool aTorch, bool aKey1, bool aKey2)
        {
            sword = aSword;
            shield = aShield;
            torch = aTorch;
            key1 = aKey1;
            key2 = aKey2;
        }

    }
}
