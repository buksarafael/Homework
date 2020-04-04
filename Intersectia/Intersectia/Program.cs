using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersectia
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v= { 1, 2, 3, 4, 5, 6, 5  },a= { 4, 5, 6, 7, 8, 9, 4 };
            Array.Sort(v);
            Array.Sort(a);
            var m = v.Intersect(a);
            foreach(int r in m)
                Console.WriteLine(r);


        }
    }
}
