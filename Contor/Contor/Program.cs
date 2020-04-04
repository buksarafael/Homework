using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contor
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter();
            //while (true)
            {
                //c.Count();
                //Console.WriteLine(c);
            }
            Counter3 c3 = new Counter3();

            while (true)
            {
                c3.Count();
                Console.WriteLine(c3);
            }
            //TODO
            //actualizarea programului driver prin introducerea clasei timer
            //contorul sa fie "actionat" la fiecare secunda

            //sa se creeze un contor generalizat
            //ContorN = new ContorN(7);

        }
    }
}
