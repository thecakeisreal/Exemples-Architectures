using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleVueVueModele
{
    // Émulation d'une base de données
    class BDEmulee
    {
        // Implémentation du patron singleton
        private static BDEmulee instance;

        // Liste des articles
        private List<Article> articles;

        // Suit l'id séquentiel d'article
        private int idSequentielArticle;

        // Implémentation du patron singleton
        // On remplit la BD fictive avec des données bidons pour l'exemple
        private BDEmulee()
        {
            idSequentielArticle = 1;

            articles = new List<Article>()
            {
                new Article {Id = idSequentielArticle++, Auteur = "Jean Arrache", Titre = "Un chat vole une tarte", DatePublication = new DateTime(2021, 9, 8, 12, 45, 00), Contenu = "Il était une fois..."},
                new Article {Id = idSequentielArticle++, Auteur = "Jean Arrache", Titre = "La tarte a été retrouvée", DatePublication = new DateTime(2021, 9, 12, 8, 51, 17), Contenu = "Depuis la nuit des temps..."},
                new Article {Id = idSequentielArticle++, Auteur = "Yvan Leboeuf", Titre = "Détective Doggo fait le point sur la chasse au voleur de tarte", DatePublication = new DateTime(2021, 9, 13, 15, 17, 35), Contenu = "Depuis que l'homme est homme"},
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

        public void AjouterArticle(Article article)
        {
            article.Id = idSequentielArticle++;
            articles.Add(article);
        }

        public override string ToString()
        {
            return "Nb article : " + articles.Count + "\n" + string.Join(
                    "\n", articles.Select(a => a.Id + " " + a.Titre));
        }
    }
}
