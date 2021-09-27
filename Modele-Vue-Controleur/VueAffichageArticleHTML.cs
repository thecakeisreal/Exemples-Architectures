using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleVueControleur
{
    // Affiche l'article dans une page HTML
    public class VueAffichageArticleHTML : IVue
    {
        public void Afficher(Dictionary<string, object> contexteVue)
        {
            // Récupérer l'objet article
            if(contexteVue.TryGetValue("article", out object article_object))
            {
                Article article = article_object as Article;
                string contenuHTML = string.Format("<h2>{0}</h2>\n" +
                    "<p class=\"date\">{1}</p>\n" +
                    "<p class=\"auteur\">Par : {2}</p>\n" +
                    "<p>{3}</p>",
                    article.Titre, article.DatePublication, article.Auteur, article.Contenu);

                Console.WriteLine(contenuHTML);
            }
        }
    }
}
