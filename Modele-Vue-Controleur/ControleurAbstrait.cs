using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleVueControleur
{
    // Fournit des méthodes communes à tous les controleurs
    public abstract class ControleurAbstrait
    {
        // Appelle la vue associé au nom fournit et lui passe l'objet contexte
        protected void Rendre(string nomVue, Dictionary<string, object> contexteVue)
        {
            string nomClasseVue = nomVue + ParamApplication.TypeVue.ToString();
            try
            {
                Type typeVue = Type.GetType(nomClasseVue);
                IVue vue = Activator.CreateInstance(typeVue) as IVue;

                if (vue != null)
                {
                    vue.Afficher(contexteVue);
                }
            }
            catch(Exception exception)
            {
                // Affichage de l'erreur
                Console.Error.WriteLine("Impossible d'afficher la vue : " + nomClasseVue + "\n" + exception.Message);
            }
        } 

    }
}
