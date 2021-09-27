using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleVueVueModele
{
    public interface IVue
    {
        // Modification d'une propriété de la vue (transmission vers le modèle)
        event Action<string> OnModifierPropVue;

        // Affiche la vue
        void Afficher();
    }
}
