using System;

namespace PlayingCard
{
    internal class playingCard
    {
        private dynamic rank;
        private dynamic suit;

        public playingCard()
        {

            string rank;
            int suit;
            Random rnd = new Random();
            rank = Convert.ToString(rnd.Next(1,13));
            suit = rnd.Next(1,4);



            switch (rank)
            {
                case "11": this.rank = "Jack";
                    break;
                case "12": this.rank = "Queen";
                    break;
                case "13": this.rank = "King";
                    break;

                default:
                    this.rank = rank;
                    break;
            }

            switch (suit)
            {
                case 1: this.suit = "Spade";
                    break;
                case 2: this.suit = "Heart";
                    break;
                case 3: this.suit = "Club";
                    break;
                case 4: this.suit = "Diamond";
                    break;

                default:
                    Console.WriteLine("Invalid Suit");
                    break;
            }

        }

        internal void Reveal()
        {
            Console.WriteLine($"The card you have is: {this.rank} of {suit}");
        }

        public playingCard(int rank, int suit)
        {
            this.rank = Convert.ToString(rank);
            this.suit = Convert.ToString(suit);

            switch (rank)
            {
                case 11:
                    this.rank = "Jack";
                    break;
                case 12:
                    this.rank = "Queen";
                    break;
                case 13:
                    this.rank = "King";
                    break;

                default:
                    if(rank>0&&rank<11)
                    this.rank = Convert.ToString(rank);
                    else
                        Console.WriteLine("Invalid rank");
                    break;
            }

            switch (suit)
            {
                case 1:
                    this.suit = "Spade";
                    break;
                case 2:
                    this.suit = "Heart";
                    break;
                case 3:
                    this.suit = "Club";
                    break;
                case 4:
                    this.suit = "Diamond";
                    break;

                default:
                    Console.WriteLine("Invalid Suit");
                    break;
            }

        }

        public playingCard(int rank,string suit)
        {
            

            switch (rank)
            {
                case 11:
                    this.rank = "Jack";
                    break;
                case 12:
                    this.rank = "Queen";
                    break;
                case 13:
                    this.rank = "King";
                    break;

                default:
                    if (rank > 0 && rank < 11)
                        this.rank = Convert.ToString(rank);
                    else
                        Console.WriteLine("Invalid rank");
                    break;
            }

            switch (suit)
            {
                case "Spade": this.suit = suit;
                    break;
                case "Diamond": this.suit = suit;
                    break;
                case "Club": this.suit = suit;
                    break;
                case "Heart": this.suit = suit;
                    break;

                default:
                    Console.WriteLine("Invalid suit");
                    break;
            }


        }

        public playingCard(string rank, int suit)
        {

            switch (rank)
            {
                case "Jack": this.rank = rank;
                    break;
                case "Queen": this.rank = rank;
                    break;
                case "King": this.rank = rank;
                    break;
                default:
                    Console.WriteLine("Invalid rank");
                    break;
            }

            
            switch (suit)
            {
                case 1:
                    this.suit = "Spade";
                    break;
                case 2:
                    this.suit = "Heart";
                    break;
                case 3:
                    this.suit = "Club";
                    break;
                case 4:
                    this.suit = "Diamond";
                    break;

                default:
                    Console.WriteLine("Invalid suit");
                    break;
            }


        }

        public playingCard(string rank, string suit)
        {
            this.rank = rank;
            this.suit = suit;

            switch (rank)
            {
                case "Jack":
                    this.rank = rank;
                    break;
                case "Queen":
                    this.rank = rank;
                    break;
                case "King":
                    this.rank = rank;
                    break;
                default:
                    Console.WriteLine("Invalid rank");
                    break;
            }

            switch (suit)
            {
                case "Spade":
                    this.suit = suit;
                    break;
                case "Heart":
                    this.suit = suit;
                    break;
                case "Club":
                    this.suit = suit;
                    break;
                case "Diamond":
                    this.suit = suit;
                    break;

                default:
                    Console.WriteLine("Invalid suit");
                    break;
            }

        }
    }
}