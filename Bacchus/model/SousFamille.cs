namespace Bacchus.model
{
    public class SousFamille
    {
        public SousFamille(int RefSousFamille, Famille Famille, string Nom)
        {
            this.RefSousFamille = RefSousFamille;
            this.Famille = Famille;
            this.Nom = Nom;
        }

        public int RefSousFamille { get; set; }

        public Famille Famille { get; set; }

        public string Nom { get; set; }

        public string[] ToRow()
        {
            string[] Row = {Nom, Famille.Nom};
            return Row;
        }
    }
}