using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinaison
{
    class Program
    {
        public static void combinaison(ref int[] comb)
        {
            Random rnd = new Random();

            for (int n = 0; n < comb.Length; n++) 
            {
                comb[n] = rnd.Next(1, 7);
            }
        }
        static void Main(string[] args)
        {
            int[] comb = new int[4];

            combinaison(ref comb);

            for (int n = 0; n < comb.Length; n++)
            {
                Console.WriteLine(comb[n]);
            }           
            Console.ReadLine();
        }
    }
}
