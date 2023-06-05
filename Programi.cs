using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Snake
{
    class Programi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1, 2, 3 - LEVEL");
            string level = Console.ReadLine();

            Console.WriteLine("Choose color (red, white, green, yellow): ");
            string color = Console.ReadLine();

            Console.WriteLine("Sisse nimi: ");
            string playerName = Console.ReadLine();

            while (color != "red" && color != "white" && color != "green" && color != "yellow")
            {
                Console.WriteLine("Choose color (red, white, green, yellow): ");
                color = Console.ReadLine();
            }
            Console.Clear();
            Game game = new Game(level, color);
            game.Start();
        }

    }
}
