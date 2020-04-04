using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridicarematrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] matrice=new int[4,4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrice[i, j] = rnd.Next(0, 10);
                    Console.Write(matrice[i,j]+" ");
                }
                Console.WriteLine();
            }
            int k;
            k=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrice[i, j] =Convert.ToInt32(Math.Pow( matrice[i,j],2));
                    Console.Write(matrice[i, j]+" ");
                }
                Console.WriteLine();
            }



        }
    }
}
