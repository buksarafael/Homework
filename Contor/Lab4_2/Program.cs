using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(1, 5, 4);

            //Console.WriteLine(dt);
            //Console.WriteLine(ts);

            DT d = new DT(); //ce tre sa faca constructorul fara parametrii
            //Console.WriteLine(d);

            DT d2 = new DT(2020, 3, 18, 0, 0, 0);
            Console.WriteLine(d2);
            Console.WriteLine($"Anul: {d2.Year}");
            //operatii pentru DT
            //diferenta dintre 2 date calendaristice
            //getters(/setters) pentru componentele lui DT
            d2.AddYears(10);
            Console.WriteLine($"Anul: {d2.Year}");
            //d2.AddMonths(20); //algoritm

            //TODO
            //adaugati operatii cu tipul de data DT (similare cu cele care le are tipul DateTime)

            //TODO
            //Realizati o implementare proprie pentru TimeSpan 
        }
    }
}
