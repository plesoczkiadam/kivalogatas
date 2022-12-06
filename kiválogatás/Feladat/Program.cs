using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomszamok = new Random();
            int[] szamok = new int[30];
            List<int> kivalogatott = new List<int>();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = randomszamok.Next(1, 100);
            }
            Console.WriteLine("Az összes 30-nál kiseeb szám ami a random sorozatól.");
            Console.WriteLine("\nAz eredeti számok listája: ");
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write("{0}; ", szamok[i]);
                
            }
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] < 30)
                {
                    kivalogatott.Add(szamok[i]);
                }
            }
            Console.WriteLine("\nA kiválogatott elemek listája:");
            for (int i = 0; i < kivalogatott.Count; i++)
            {
                Console.Write("{0},", kivalogatott[i]);
            }
            Console.ReadLine();

         
        }
    }
}
