using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mini Game");
            Console.WriteLine();

            //for loop
            //--------
            //// count 1 to 10
            //for (int i = 1; i <= 10; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            /* 3 parts:
            1) declaration/initialization - start at 1 (outside of loop)
            2) test -- at the top of loop
            --- where the inside of the loop occures --- 
            3) increment -- at bottom of loop
            */

            int x = 10; // player position
            int y = 10; // player position
            char avatar = '@';

            bool gameOver = false;
            // Game loop
            while(gameOver != true)
            {
                ConsoleKeyInfo input;
                input = Console.ReadKey();

                if(input.Key == ConsoleKey.W)
                {
                    y = y - 1;
                    if (y<0) y = 0; // creates border avatar won't go past
                }

                Console.SetCursorPosition(x, y); // player position
                Console.WriteLine(avatar); // player avatar
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey(true);
        }
    }
}
