using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetAccesDonnees
{
    // Gère les accès à la BD pour les objets articles
    class ArticleDAO
    {
        // Référence sur la bd
        private readonly BDEmulee connexion;

        public ArticleDAO()
        {
            // Récupère la connexion à la bd
            connexion = BDEmulee.GetConnexion();
        }

        // Ajoute un nouvel article dans la base de données
        public bool AjouterArticle(Article article)
        {
            connexion.Articles.Add(new object[5] { article.Id, article.Auteur, article.Titre, article.DatePublication, article.Contenu });
            return true;    // Ici on pourrait valider avec le SGBD que tout s'est bien déroulé
        }

        // Trouve un article selon son identifiant unique dans la base de données
        public Article TrouverArticleParId(int id)
        {
            return ChargerArticle(connexion.Articles.Where(ligne => (int)ligne[0] == id).FirstOrDefault());
        }

        // Construit un objet article à partir des données chargées de la BD
        private Article ChargerArticle(object[] donnees)
        {
            if(donnees == null || donnees.Length < 5)
            {
                return null;
            }

            return new Article
            {
                Id = (int)donnees[0],
                Auteur = donnees[1] as string,
                Titre = donnees[2] as string,
                DatePublication = (DateTime)donnees[3],
                Contenu = donnees[3] as string
            };
        }

    }
}
