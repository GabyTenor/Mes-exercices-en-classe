using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Catégoriser_selon_l_âge
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageKid;         
            Console.WriteLine("Entrez l'âge de votre enfant :");
            ageKid = int.Parse(Console.ReadLine()); //Attribution de l'âge
            Console.ReadLine();

            //Traitement
            Classement(ageKid, out string classKid);

            Console.WriteLine(classKid);
            Console.ReadLine();
        }
        public static void Classement(int ageKid, out string classKid)
        {
            if(ageKid>=1 & ageKid<=150) //Conditions d'existences
            {
                if (ageKid>=6 & ageKid<=14) 
                {
                    if (ageKid <= 7)
                    {
                        classKid = "Poussin";
                    }
                    else
                    {
                        if (ageKid <= 9)
                        {
                            classKid = "Pupille";
                        }
                        else
                        {
                            if (ageKid <= 11)
                            {
                                classKid = "Minime";
                            }
                            else
                            {
                                if (ageKid<=14)
                                {
                                    classKid = "Cadet";
                                }
                                else
                                {
                                    classKid = "Désolé, votre enfant est trop vieux pour être classé";
                                }
                            }
                        }
                    }
                }
                else
                {
                    classKid = "Désolé, votre enfant ne peut pas être classé";
                }
            }
            else
            {
                classKid = "L'âge que vous avez rentré n'est pas possible";
            }
        }
    }
}
