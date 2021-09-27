using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleVueVueModele
{
    class Programme
    {
        // Exécute le programme
        public void Executer()
        {
            new VueMenu().Afficher();
        }

        static void Main(string[] args)
        {
            new Programme().Executer();
        }
    }
}
