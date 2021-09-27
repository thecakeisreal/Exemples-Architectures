using System;
using System.Collections.Generic;

namespace ModeleVueVueModele
{
    // Assure la liaison de donnée entre un modèle et sa vue
    public class LieurDonnees
    {
        // Liste des liaisons entre la vue et le modèle
        private readonly Dictionary<string, string> liaisons;

        // Modèle manipulé
        protected readonly object modele;

        // Vue affichée
        protected readonly IVue vue;

        public LieurDonnees(IVue vue, object modele)
        {
            liaisons = new Dictionary<string, string>();
            this.vue = vue;
            this.modele = modele;

            vue.OnModifierPropVue += MettreAJour;
        }

        // Finaliseur de lieur données
        ~LieurDonnees()
        {
            vue.OnModifierPropVue -= MettreAJour;
        }

        // Lie une propriété de la vue à une propriété du modèle
        public void Lier(string proprieteVue, string proprieteModele)
        {
            liaisons.Add(proprieteVue, proprieteModele);
            
        }

        // Met à jour une propriété dans le modèle suite à un changement dans la vue
        protected void MettreAJour(string proprieteVue)
        {
            if (liaisons.TryGetValue(proprieteVue, out string proprieteModele))
            {
                try
                {
                    object value = vue.GetType().GetProperty(proprieteVue).GetValue(vue);
                    modele.GetType().GetProperty(proprieteModele).SetValue(modele, value);
                }
                catch (Exception exception)     // Beaucoup de types d'erreur peuvent survenir
                {
                    Console.Error.WriteLine("Impossible d'effectuer la liaison de " + proprieteVue + "(" + vue.GetType().Name + ") à " +
                        proprieteModele + "(" + modele.GetType().Name + ")");
                    Console.Error.WriteLine(exception.Message);
                }
            }
            else
            {
                Console.Error.WriteLine("Impossible de trouver une propriété dans le modèle associé à " + proprieteVue);
            }
        }
    }
}
