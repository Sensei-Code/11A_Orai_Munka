using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombokHasonlitasa
{
    class Program
    {
        //Töltsünk fel két 50 elemű tömböt kétjegyű véletlen számokkal, majd
        //hasonlítsuk össze őket, hogy hány egyezés van a két tömb között.

        static void Main(string[] args)
        {
           const int elemszam = 25;

            int[] tomb1 = new int[elemszam];
            int[] tomb2 = new int[elemszam];
            int[] tombegyezes = new int[elemszam];
            int egyezes = 0;

            Random rnd = new Random();

            for (int i = 0; i < elemszam; i++)
            {
                tomb1[i] = rnd.Next(10, 100);
                tomb2[i] = rnd.Next(10, 100);
            }
            
            for (int i = 0; i < tomb1.Length; i++)
            {
                for (int j = 0; j < tomb2.Length; j++)
                {
                    if (tomb1[i] == tomb2[j])
                    {
                        tombegyezes[egyezes] = tomb1[i];
                        egyezes++;                       
                        break;
                    }
                }
            }

            Console.WriteLine("Az első tömb tartalma:\n");

            foreach (var szam in tomb1)
            {
                for (int i = 0; i < tombegyezes.Length; i++)
                {
                    if (szam == tombegyezes[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                       
                    }
                }
                Console.Write("{0}, ", szam);
                Console.ForegroundColor = ConsoleColor.Gray; ;
            }
            Console.WriteLine("\n\nA második tömb tartalma:\n");

            foreach (var szam in tomb2)
            {
                for (int i = 0; i < tombegyezes.Length; i++)
                {
                    if (szam == tombegyezes[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        
                    }
                }

                Console.Write("{0}, ", szam);
                Console.ForegroundColor = ConsoleColor.Gray; ;
            }

            Console.WriteLine("\n\nA két tömbben {0} db egyezés van!",egyezes);

            

            Console.ReadLine();


        }
    }
}
