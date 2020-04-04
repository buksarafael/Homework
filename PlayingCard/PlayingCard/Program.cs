using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCard
{
    class Program
    {
        //Tema "Playing Card"


        static void Main(string[] args)
        {
            //Am adaugat un constructor cam pentru fiecare caz de initializare
            playingCard p1 = new playingCard();
            playingCard p2 = new playingCard(2,3);
            playingCard p3 = new playingCard(4, "Spade");
            playingCard p5 = new playingCard("Queen", 2);
            playingCard p4 = new playingCard("King", "Diamond");
            //Proprietatea Reveal arata cartea "trasa"
            p1.Reveal();
            p2.Reveal();
            p3.Reveal();
            p4.Reveal();
            p5.Reveal();
        }

       

    }
}
