using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    internal class Program
    {

        static int x;
        static int y;
        
        static bool gameOver;


        static void Main(string[] args)
        {
          

            x = 10;
            y = 10;
           
            gameOver = false;

            while(gameOver == false)
            {
                PlayerUpdate();
                DrawPlayer();
              
            }



        }
        static void PlayerUpdate()
        {
           ConsoleKeyInfo input;
           input = Console.ReadKey(true);

            //Console.WriteLine(input);
            Console.WriteLine(input.KeyChar);

            if (input.KeyChar == 'w')
            {
                y--;
            }
            else if (input.KeyChar == 's')
            {
                y++;
            }
            else if (input.KeyChar == 'a')
            {
                x--;
            }
            else
            {
                x++;
            }
            if (input.Key == ConsoleKey.Escape)
            {
                gameOver = true;
            }
            

            

           
        }
        static void DrawPlayer()
        {

            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write(">");
            
        }
    }
}
