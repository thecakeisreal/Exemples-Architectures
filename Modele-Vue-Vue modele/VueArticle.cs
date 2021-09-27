using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleVueVueModele
{
    public class VueArticle : IVue
    {
        // Affiche le titre de l'article
        private string titre;
        public string TitreArticle 
        { 
            get => titre; 
            set
            {
                titre = value;
                OnModifierPropVue?.Invoke("TitreArticle");
            }
        }

        // Modification d'une propriété
        public event Action<string> OnModifierPropVue;

        // Initialise les valeurs affichées dans la vue
        public void Initialiser(string titre)
        {
            this.titre = titre;     // En passant par l'attribut, on évite une màj inutile
        }

        public void Afficher()
        {
            if (TitreArticle != null)
            {
                Console.WriteLine("Le titre de l'article est " + TitreArticle);
            }
            Console.WriteLine("Quel est le  titre de l'article ?");
            TitreArticle = Console.ReadLine(); 
        }
    }
}
