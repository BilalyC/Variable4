using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string civilite, nom;
            int nb;

            civilite = "Monsieur";
            nom = "Vincent";
            nb = 1;

            //Console.WriteLine($"Bonjour {civilite} {nom}, vous êtes venu nous rendre visite {nb} fois");
            Console.WriteLine("Bonjour " + civilite + " " + nom + ", vous êtes venu nous rendre visite " + nb + " fois");
        }
    }
}
