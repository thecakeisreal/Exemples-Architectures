using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleVueControleur
{
    public enum TypeVue
    {
        JSON, HTML
    }

    // Paramètres d'exécution de l'application
    public static class ParamApplication
    {
        public static TypeVue TypeVue { get; set; }
    }
}
