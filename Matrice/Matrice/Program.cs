using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrice
{
    class Program
    {
        static bool prim(int v)
        {
            bool prime=true;
            for (int i = 2; i < v/2; i++)
            {
                if (v % i == 0)
                    prime = false;
            }
            return prime;
        }

        static void Main(string[] args)
        {
            
            int m, n;
            int k = 2;
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a=new int[m,n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Again:
                    if (prim(k))
                    {
                        a[i, j] = k;
                        k++;
                    }
                    else
                    {
                        k++;
                        goto Again;
                    }
                   
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i,j]+" ");  
                }
                Console.WriteLine();
            }

        }
    }
}
