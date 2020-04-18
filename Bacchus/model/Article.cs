using System.Globalization;

namespace Bacchus.model
{
    public class Article
    {
        public Article(string RefArticle, string Description, SousFamille SousFamille, Marque Marque, float PrixHt,
            int Quantite)
        {
            this.RefArticle = RefArticle;
            this.Description = Description;
            this.SousFamille = SousFamille;
            this.Marque = Marque;
            this.PrixHt = PrixHt;
            this.Quantite = Quantite;
        }

        public string RefArticle { get; private set; }

        public string Description { get; set; }

        public SousFamille SousFamille { get; set; }

        public Marque Marque { get; set; }

        public float PrixHt { get; set; }

        public int Quantite { get; set; }

        /// <summary>
        /// Fonction retournant la chaîne de caractère correspondant à la ligne CSV de l'article
        /// </summary>
        /// <returns>La chaîne de caractère</returns>
        public string ToCsv()
        {
            return Description + ";" + RefArticle + ";" + Marque.Nom + ";" + SousFamille.Famille.Nom + ";" +
                   SousFamille.Nom + ";" + PrixHt + "\n";
        }

        public override string ToString()
        {
            return Description + " - " + PrixHt + " - " + Quantite;
        }

        public string[] ToRow()
        {
            string[] Row =
            {
                RefArticle, Description, Marque.Nom, SousFamille.Nom, PrixHt.ToString(CultureInfo.InvariantCulture),
                Quantite.ToString()
            };
            return Row;
        }
    }
}