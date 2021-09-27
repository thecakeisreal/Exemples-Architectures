using System;

namespace ModeleVueVueModele
{
    // Affiche le menu principal de l'application
    class VueMenu : IVue
    {
        public event Action<string> OnModifierPropVue;

        public void Afficher()
        {
            bool terminerExecution = false;

            while (!terminerExecution)
            {
                Console.WriteLine("Que souhaitez-vous faire ?\n" +
                    "1) Ajouter un article\n" +
                    "2) Modifier un article\n" +
                    "3) Lister les articles\n" +
                    "Q) Quitter le programme");

                string saisie = Console.ReadLine();

                switch(saisie)
                {
                    case "1":
                        VueModeleArticle mvaCreation = new VueModeleArticle();
                        mvaCreation.CreerArticle();
                        break;
                    case "2":
                        Console.WriteLine("Quel est l'id de l'article à modifier (1-3) ?");
                        int idArticle = SaisirEntier();

                        VueModeleArticle mvaModification = new VueModeleArticle();
                        mvaModification.ModifierArticle(idArticle);

                        break;
                    case "3":
                        // On devrait ici utiliser un vue modele suportant les listes
                        // Pour l'exemple on simplifie et on accède directement à la BD
                        Console.WriteLine(BDEmulee.GetConnexion().ToString());
                        break;
                    case "Q":
                    case "q":
                        terminerExecution = true;
                        break;
                    default:
                        Console.WriteLine("Veuillez saisir une entrée valide.");
                        break;
                }
            }
        }

        // Saisie un entier de façon sécuritaire
        private int SaisirEntier()
        {
            int valeur;
            while(!int.TryParse(Console.ReadLine(), out valeur) || valeur < 1 || valeur > 3)
            {
                Console.WriteLine("Veuillez entrer un entier valide (1-3)");
            }

            return valeur;
        }
    }
}
