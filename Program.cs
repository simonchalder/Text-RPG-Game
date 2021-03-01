using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{


    

    

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Player player1 = new Player(false, false, false, false, false);
            Enemies monster1 = new Enemies(100);
            Rooms.Room1();
        }
        

        
    }

}
