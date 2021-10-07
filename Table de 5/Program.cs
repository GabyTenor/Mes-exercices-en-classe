using System;

namespace Table_de_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultat = 0 + ",";

            table5(ref resultat);

            Console.WriteLine(resultat);
            Console.ReadLine();
        }
        public static void table5(ref string resultat)
        {
            for(int n = 0; n<=500; n+=5 )
            {
                resultat = resultat + "," + n;
            }
        }
    }
}
