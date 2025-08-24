using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter WASD to move, Q to exit");
            char simb = '+';
            int x = 0, y = 1;               //coordinates
            Console.Write(simb);
            ConsoleKeyInfo key;
            char dir;                       //direction
            key = Console.ReadKey(true);    //key of direction
            dir = key.KeyChar;

            //Console.SetCursorPosition(10, 10);
            //Console.Write(simb);

            while (dir != 'q' && dir != 'Q') {
                switch (dir)
                {
                    case 'w': if (y > 0) y--; break;
                    case 'W': if (y > 0) y--; break;
                    case 'a': if (x > 0) x--;  break;
                    case 'A': if (x > 0) x--;  break;
                    case 's': if (y < 20) y++; break;
                    case 'S': if (y < 20) y++;  break;
                    case 'd': if (x < 60) x++;  break;
                    case 'D': if (x < 60) x++;  break;

                }
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write(simb);
                key = Console.ReadKey(true);    
                dir = key.KeyChar;
            }

        }
    }
}
