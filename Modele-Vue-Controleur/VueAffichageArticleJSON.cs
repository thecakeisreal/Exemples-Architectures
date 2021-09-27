using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleVueControleur
{
    class VueAffichageArticleJSON : IVue
    {
        public void Afficher(Dictionary<string, object> contexteVue)
        {
            // Récupérer l'objet article
            if (contexteVue.TryGetValue("article", out object article_object))
            {
                Article article = article_object as Article;
                string contenuJSON = string.Format("{{\n\t\"Titre\" : \"{0}\",\n" +
                    "\t\"DatePublication\" : \"{1}\",\n" +
                    "\t\"Auteur\" : \"{2}\",\n" +
                    "\t\"Contenu\" : \"{3}\"\n}}",
                    article.Titre, article.DatePublication, article.Auteur, article.Contenu);

                Console.WriteLine(contenuJSON);
            }
        }
    }
}
