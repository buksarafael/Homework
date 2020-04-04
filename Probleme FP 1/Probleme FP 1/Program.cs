using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_FP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mat[i, j] = rnd.Next(-3, 3);
                }
            }

            int princ = 0, sec = 4;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mat[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Elementele din zona de nord sunt:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j > princ && j < sec)
                    {
                        Console.Write(mat[i, j]+" ");
                    }
                    
                }
                princ++;
                    sec--;
            }
            Console.WriteLine();
        }
    }
}
