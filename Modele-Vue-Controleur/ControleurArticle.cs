using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleVueControleur
{
    public class ControleurArticle : ControleurAbstrait
    {
        static void Main(string[] args)
        {
            // Initialisation des paramètres de l'application
            ParamApplication.TypeVue = (TypeVue) Enum.Parse(typeof(TypeVue), args[0]);

            ControleurArticle controleur = new ControleurArticle();
            controleur.LireArticle(new Dictionary<string, object>
            {
                { "id_article", 1 }
            });

            // Force une pause dans l'exécution
            Console.ReadLine();
        }

        // Méthode permettant d'afficher un article de la base de données
        public void LireArticle(Dictionary<string, object> context)
        {
            Dictionary<string, object> contextVue = new Dictionary<string, object>();

            // Récupérer # article
            if(context.TryGetValue("id_article", out object id_article_object))
            {
                if (id_article_object.GetType() == typeof(int))     // On valide le type avant de caster
                {
                    int id_article = (int)id_article_object;

                    BDEmulee connexion = BDEmulee.GetConnexion();
                    Article article = connexion.RecupererArticleParId(id_article);

                    // On envoie l'article à la vue pour l'affichage
                    contextVue.Add("article", article);
                }
            }

            Rendre("ModeleVueControleur.VueAffichageArticle", contextVue);
        }
    }
}
