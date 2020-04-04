using System;

namespace Geometrie4
{
    public class punct
    {
        public int x, y;

        public punct(int x2, int y2)
        {
            x = x2;
            y = y2;
        }

        internal void Distanta(punct p2)
        {
            int r =  -x * p2.y + p2.x + y ;
            if (p2.x > 0 && r>0)
            {
                Console.WriteLine($"{p2.y}x-{p2.x}y+{-x*p2.y+p2.x+y}");
            }
            if (p2.x > 0 && r<0)
            {
                Console.WriteLine($"{p2.y}x-{p2.x}y{-x * p2.y + p2.x + y}");
            }
            if (p2.x < 0 && p2.y > 0)
            {
                Console.WriteLine($"{p2.y}x+{p2.x}y+{-x * p2.y + p2.x + y}");
            }
            if (p2.x < 0 && p2.y < 0)
            {
                Console.WriteLine($"{p2.y}x+{p2.x}y{-x * p2.y + p2.x + y}");
            }
        }
    }
}