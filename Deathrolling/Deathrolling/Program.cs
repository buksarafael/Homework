using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathrolling
{

    class Program
    {
        static Random rnd = new Random();
        static string nickname;
        static int increment;
        static int roll(int number)
        {
            number = number * increment;
            int result,i=1;
            string rolling;
            result = rnd.Next(1,number);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{nickname} rolls {result} (1-{number})");
            Console.ForegroundColor = ConsoleColor.White;
            while (result != 1)
            {
                string tru = $"/roll {result}";
                number = result;
                if (i%2 == 1)
                {
                    result = rnd.Next(1,result);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"God rolls {result} (1-{number})");
                    Console.ForegroundColor = ConsoleColor.White;
                    i++;
                }
                else
                {
                    rollin:
                    rolling = Console.ReadLine();
                    
                    if(rolling==tru)
                    {
                        result = rnd.Next(1,result);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"{nickname} rolls {result} (1-{number})");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Unkown command");
                        Console.ForegroundColor = ConsoleColor.White;
                        goto rollin;
                    }
                    i++;
                }
            }
            return i;
        }
        static void Main(string[] args)
        {
            int gold=10,bet;
            int result;
            int achi1 = 0, achi2 = 0, achi3 = 0, achi4 = 0, achi5 = 0, achi6 = 0, achi7 = 0, achi8 = 0, achi9 = 0, achi10 = 0; ;  //pentru 100,1000,5000,10000,50000,100000,250000,500000,750000,1000000;
            Console.Write("╔");
            for (int i = 0; i < 118; i++)
            {
                Console.Write("═");
            }
            Console.Write("╗");

            for (int i = 0; i < 360; i++)
            {
                if(i%120==0||i==0||i%120==119)
                    Console.Write("║");
                else
                    Console.Write("█");
            }
            Console.Write("║");
            for (int i = 0; i < 48; i++)
            {
                Console.Write("█");

            }
            Console.Write("WELCOME TO DEATHROLLING");
            for (int i = 0; i < 47; i++)
            {
                Console.Write("█");
            }
            Console.Write("║");
            for (int i = 0; i < 360; i++)
            {
                if (i % 120 == 0 || i == 0 || i % 120 == 119)
                    Console.Write("║");
                else
                    Console.Write("█");
            }
            Console.Write("╚");
            for (int i = 0; i < 118; i++)
            {
                Console.Write("═");
            }
            Console.Write("╝");
            Console.WriteLine("What is your nickname?");
            nickname = Console.ReadLine();
            Console.WriteLine("What increment do you want to play with? x10 or x100? (type 1 for x10 and 2 for x100)");
            int q;
            Input:
            q = Convert.ToInt32(Console.ReadLine());
            if (q == 1 || q == 2)
            {
                if (q == 1)
                    increment = 10;
                else
                    increment = 100;
            }
            else
            {
                Console.WriteLine("Please input a valid option");
                goto Input;
            }

            start:
            Console.Write("You have: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{gold}g");
            Console.ForegroundColor = ConsoleColor.White;
            if (gold != 0)
            {
            goldo:
                Console.WriteLine("How much gold do you want to bet?");
                bet = Convert.ToInt32(Console.ReadLine());
                if (bet < 0 || bet > gold)
                {
                    Console.WriteLine($"Please input a valid ammount, betwen 0 and {gold}");
                    goto goldo;
                }
                else
                    result = roll(bet);
                if (result % 2 == 1)
                {
                    gold = gold - bet;
                }
                else
                    gold = gold + bet;
                if (gold >= 100 && achi1 == 0)
                {
                    Console.WriteLine("Congrats on getting 100 gold!");
                    achi1 = 1;
                }
                if (gold >= 1000 && achi2 == 0)
                {
                    Console.WriteLine("Congrats on getting 1000 gold!");
                    achi2 = 1;
                }
                if (gold >= 5000 && achi3 == 0)
                {
                    Console.WriteLine("Congrats on getting 5000 gold!");
                    achi3 = 1;
                }
                if (gold >= 10000 && achi4 == 0)
                {
                    Console.WriteLine("Congrats on getting 10000 gold!");
                    achi4 = 1;
                }
                if (gold >= 50000 && achi5 == 0)
                {
                    Console.WriteLine("Congrats on getting 50000 gold!");
                    achi5 = 1;
                }
                if (gold >= 100000 && achi6 == 0)
                {
                    Console.WriteLine("Congrats on getting 100000 gold!");
                    achi6 = 1;
                }
                if (gold >= 250000 && achi7 == 0)
                {
                    Console.WriteLine("Congrats on getting 250000 gold!");
                    achi7 = 1;
                }
                if (gold >= 500000 && achi8 == 0)
                {
                    Console.WriteLine("Congrats on getting 500000 gold!");
                    achi8 = 1;
                }
                if (gold >= 750000 && achi9 == 0)
                {
                    Console.WriteLine("Congrats on getting 750000 gold!");
                    achi9 = 1;
                }
                if (gold >= 1000000 && achi10 == 0)
                {
                    Console.WriteLine("Congrats on getting 1000000 gold!");
                    achi10 = 1;
                }
                goto start;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("GAME OVER");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
