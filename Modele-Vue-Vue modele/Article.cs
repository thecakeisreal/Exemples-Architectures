using System;

namespace ModeleVueVueModele
{
    // Article pour le journal local
    public class Article
    {
        // Identifiant unique de l'article
        public int Id { get; set; }

        // Journaliste ayant écrit l'article
        public string Auteur { get; set; }

        // Titre de l'article
        private string titre;
        public string Titre
        {
            get => titre;
            set
            {
                titre = value;
                Console.WriteLine("Le titre est " + titre);
            }
        }

        // Date et heure de la mise en ligne
        public DateTime DatePublication { get; set; }

        // Texte de l'article
        public string Contenu { get; set; }
    }
}
