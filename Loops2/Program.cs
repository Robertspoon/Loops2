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
        static void Main(string[] args)
        {
            Console.WriteLine("Loops");
            x = 10;
            y = -10;


            Console.ReadKey(true);
        }
        static void PlayerUpdate()
        {

           
        }
        static void DrawPlayer()
        {
            Console.Clear();
            Console.SetCursorPosition(x,y);
            Console.Write(">");
        }
    }
}
