using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int x1, y1,x2,y2,x3,y3;
            string dreapta;
            Console.Write("Dati x-ul punctului A: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati y-ul punctului A: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati x-ul punctului B: ");
            x2= Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati y-ul punctului B: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            punct p1 = new punct(x1,y1);
            punct p2 = new punct(x2,y2);

            Console.Write("Ecuatia dreptei AB este: ");

            p1.Distanta(p2);

            //2
            Console.Write("Dati x-ul punctului C: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Dati y-ul punctului C: ");
            y3 = Convert.ToInt32(Console.ReadLine());

            punct p3 = new punct(x3, y3);
            Console.Write("Introduce-ti dreapta d: ");
            dreapta = Console.ReadLine();

            string[] equationTokens = { "0", "0", "0" };
            equationTokens = dreapta.Split(new char[] { 'x','y' });
            if (equationTokens[2] == "")
                equationTokens[2]="0";
            int a = Convert.ToInt32(equationTokens[0]);
            int b = Convert.ToInt32(equationTokens[1]);
            int c = Convert.ToInt32(equationTokens[2]);

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            double distanta;

            distanta = (Math.Abs(a * x3 + b * y3 + c)) / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.Write("Distanta dintre punctul C si dreapta d este: ");
            Console.Write(distanta);
            Console.WriteLine();

            //3

            Console.Write("Dati x-ul punctului A: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati y-ul punctului A: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati x-ul punctului B: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati y-ul punctului B: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati x-ul punctului C: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati y-ul punctului C: ");
            y3 = Convert.ToInt32(Console.ReadLine());

            double arie;
            arie = x1 * x2 + y1 * y3 + x2 * x3 - x3 * y2 - x3 * x1 - x2 * y1;
            if (arie > 0)
            {
                Console.Write("Aria triunghiului ABC este: ");
                Console.WriteLine(arie);
            }
            else
                Console.WriteLine("Nu se poate forma un triunghi din punctele A,B,C");
        }
    }
}