using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetAccesDonnees
{
    // Émulation d'une base de données
    class BDEmulee
    {
        // Implémentation du patron singleton
        private static BDEmulee instance;

        // Liste des articles
        public List<object[]> Articles { get; private set; }

        // Implémentation du patron singleton
        // On remplit la BD fictive avec des données bidons pour l'exemple
        private BDEmulee()
        {
            Articles = new List<object[]>()
            {
                new object[5] {1, "Jean Arrache",  "Un chat vole une tarte", new DateTime(2021, 9, 8, 12, 45, 00), "Il était une fois..."},
                new object[5] { 2, "Jean Arrache", "La tarte a été retrouvée", new DateTime(2021, 9, 12, 8, 51, 17), "Depuis la nuit des temps..."},
                new object[5] {3, "Yvan Dubois", "Détective Doggo fait le point sur la chasse au voleur de tarte", new DateTime(2021, 9, 13, 15, 17, 35), "Depuis que l'homme est homme"},
            };
        }

        // Retourne une connexion à la bd
        public static BDEmulee GetConnexion ()
        {
            if(instance == null)
            {
                instance = new BDEmulee();
            }

            return instance;
        }
    }
}
