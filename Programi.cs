using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Programi
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0,78,0,'*');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '*');
            VertikalLine leftLine = new VertikalLine(0, 24, 0, '*');
            VertikalLine rightLine = new VertikalLine(0,24,78, '*');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Snake snake = new Snake(p, 4, Direction.RIGHT);

            Console.ReadLine();
        }
        static void Draw(int x, int y,char sym) 
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
