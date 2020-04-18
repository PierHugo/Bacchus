namespace Bacchus.model
{
    public class Marque
    {
        public Marque(int RefMarque, string Nom)
        {
            this.RefMarque = RefMarque;
            this.Nom = Nom;
        }

        public int RefMarque { get; set; }

        public string Nom { get; set; }

        public string[] ToRow()
        {
            string[] Row = {Nom};
            return Row;
        }
    }
}