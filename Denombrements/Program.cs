using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int choixOperation = 1;
            while (choixOperation != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                bool boucleTry = false;
                while (!boucleTry)

                try
                {
                    choixOperation = int.Parse(Console.ReadLine());
                        boucleTry = true;
                }
                catch
                {
                    Console.WriteLine("Entrez 0, 1, 2 ou 3");
                }
               
                switch (choixOperation)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:

                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        
                        int n = int.Parse(Console.ReadLine()); 
                        
                        for (int k = 1; k <= n; k++)
                            n *= k;
                        Console.WriteLine(n + "! = " + n);
                        break;

                    case 2:

                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int sousEnsemble = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r
                        long r = 1;
                        for (int k = (t - sousEnsemble + 1); k <= t; k++)
                            r *= k;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + t + "/" + sousEnsemble + ") = " + r);
                        break;

                    case 3:

                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int nombreTotal = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int sousEnsemble2 = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (nombreTotal - sousEnsemble2 + 1); k <= nombreTotal; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= sousEnsemble2; k++)
                            r2 *= k;
                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + nombreTotal + "/" + sousEnsemble2 + ") = " + (r1 / r2));
                        break;

                }
                
            }
            Console.ReadLine();
        }
    }
}
