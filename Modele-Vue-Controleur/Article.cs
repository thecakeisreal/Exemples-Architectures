using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleVueControleur
{
    // Article pour le journal local
    public class Article
    {
        // Identifiant unique de l'article
        public int Id { get; set; }

        // Journaliste ayant écrit l'article
        public string Auteur { get; set; }

        // Titre de l'article
        public string Titre { get; set; }

        // Date et heure de la mise en ligne
        public DateTime DatePublication { get; set; }

        // Texte de l'article
        public string Contenu { get; set; }
    }
}
