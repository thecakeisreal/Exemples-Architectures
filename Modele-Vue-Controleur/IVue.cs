using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleVueControleur
{
    // Interface de base de toutes les vues
    public interface IVue
    {
        // Affiche une vue à l'écran
        void Afficher(Dictionary<string, object> contexteVue);
    }
}
