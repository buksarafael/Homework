using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sir_Aleatoriu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, k;
            Random rnd = new Random();
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            int[] v =new int[n];
            int[] a = new int[11];
            for (int i = 0; i < v.Length; i++)
            {
                //rnd.Next();
                k = rnd.Next(10);
                a[k] = a[k] + 1;
                if (a[k] <= m)
                {
                    v[i] = k;
                }
                else
                    i--;
            }
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]}, ");
            }
            Console.WriteLine();
        }
    }
}
