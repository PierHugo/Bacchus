namespace Bacchus.model
{
    public class Famille
    {
        public Famille(int RefFamille, string Nom)
        {
            this.RefFamille = RefFamille;
            this.Nom = Nom;
        }

        public int RefFamille { get; set; }

        public string Nom { get; set; }

        public string[] ToRow()
        {
            string[] Row = {Nom};
            return Row;
        }
    }
}