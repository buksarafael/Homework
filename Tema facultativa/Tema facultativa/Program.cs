using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_facultativa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 1, 2, 3, -1, 4, 5, -2, 6, 7 };
            string s = "", maxstring = "";
            int max = 0, suma = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] >= 0)
                {
                    suma = suma + v[i];
                    s = s + Convert.ToString(v[i]) + "+";
                }
                if (suma > max)
                {
                    max = suma;
                    maxstring = s;
                }
                if (v[i] <= 0)
                {
                    suma = 0;
                    s = "";
                }
            }
            Console.WriteLine(maxstring);
        }
    }
}
