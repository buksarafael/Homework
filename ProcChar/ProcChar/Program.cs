using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcChar
{
    class Program
    {
        static void Main(string[] args)
        {
            int characters = 0, lines = 0, vowel = 0, consonant = 0;
            int[] vocale = { 97, 101, 105, 111, 117 };
            using (StreamReader sr = new StreamReader("test.txt"))
            {

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines++;
                }
                
            }
            using (StreamReader sr = new StreamReader("test.txt"))
            {
                char chr;
                while (!sr.EndOfStream)
                {
                    if (sr.Peek() != 13 && sr.Peek() != 10)
                    {
                        if (sr.Peek() == 97 || sr.Peek() == 101 || sr.Peek() == 105 || sr.Peek() == 111 || sr.Peek() == 117)
                        {
                            vowel++;
                        }
                        else
                            consonant++;
                        
                        characters++;
                        sr.Read();
                    }
                    else sr.Read();
                }
            }
            Console.WriteLine("Fisierul e format din:");
            Console.WriteLine($"{lines} linii");
            Console.WriteLine($"{characters} caractere");
            Console.WriteLine($"{vowel} vocale");
            Console.WriteLine($"{consonant} consoane");
        }
    }
}
