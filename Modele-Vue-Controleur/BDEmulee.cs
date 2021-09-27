using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleVueControleur
{
    // Émulation d'une base de données
    class BDEmulee
    {
        // Implémentation du patron singleton
        private static BDEmulee instance;

        // Liste des articles
        private List<Article> articles;

        // Implémentation du patron singleton
        // On remplit la BD fictive avec des données bidons pour l'exemple
        private BDEmulee()
        {
            articles = new List<Article>()
            {
                new Article {Id = 1, Auteur = "Jean Arrache", Titre = "Un chat vole une tarte", DatePublication = new DateTime(2021, 9, 8, 12, 45, 00), Contenu = "Il était une fois..."},
                new Article {Id = 2, Auteur = "Jean Arrache", Titre = "La tarte a été retrouvée", DatePublication = new DateTime(2021, 9, 12, 8, 51, 17), Contenu = "Depuis la nuit des temps..."},
                new Article {Id = 3, Auteur = "Yvan Leboeuf", Titre = "Détective Doggo fait le point sur la chasse au voleur de tarte", DatePublication = new DateTime(2021, 9, 13, 15, 17, 35), Contenu = "Depuis que l'homme est homme"},
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

        // Retourne l'article de l'id ou null s'il n'est pas trouvé
        public Article RecupererArticleParId(int id)
        {
            return articles.Where(a => a.Id == id).FirstOrDefault();
        }

    }
}
