
namespace ModeleVueVueModele
{
    // Lie le modèle article à la vue article
    public class VueModeleArticle
    {
        // Instances liées entre la couche métier et l'interface
        private readonly VueArticle vueArticle;
        private Article article;

        // Responsable de gérer les liaisons
        private LieurDonnees liaisons;

        // Lien à la BD applicative
        private readonly BDEmulee connexion;

        public VueModeleArticle()
        {
            vueArticle = new VueArticle();
            connexion = BDEmulee.GetConnexion();
        }

        // Permet d'ajouter un nouvel article
        public void CreerArticle()
        {
            article = new Article();
            connexion.AjouterArticle(article);

            RendreVue(article);
        }

        // Lance la modification d'article
        public void ModifierArticle(int idArticle)
        {
            article = connexion.RecupererArticleParId(idArticle);
            vueArticle.Initialiser(article.Titre);

            RendreVue(article);
        }

        // Préparer la vue, fait la liaison et affiche la vue
        private void RendreVue(Article article)
        {
            liaisons = new LieurDonnees(vueArticle, article);
            liaisons.Lier("TitreArticle", "Titre");

            vueArticle.Afficher();
        }
    }
}
