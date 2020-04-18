using System.IO;
using System.Text;

namespace Bacchus.model
{
    public static class Utils
    {
        public delegate void MaxValue(int MaxValue);

        public delegate void NbArticlesAdded(int NbArticles);

        public delegate void NbArticlesExported(int NbArticles);

        public delegate void UpdateBar(int Progress);

        public static event UpdateBar HasToUpdate;
        public static event MaxValue SetMaxValue;
        public static event NbArticlesAdded SetNbArticlesAdded;
        public static event NbArticlesExported SetNbArticlesExported;

        /// <summary>
        /// Fonction chargeant un fichier CSV dans la base de données
        /// </summary>
        /// <param name="FilePath">Le nom du fichier CSV à charger</param>
        /// <param name="Removing">Si vrai alors on supprime les données existantes de la DB</param>
        /// <param name="BacchusModel">Le modèle existant</param>
        /// <returns>Le modèle initialisé, qui remplacera ou sera ajouté au modèle existant</returns>
        public static void LoadCsv(string FilePath, bool Removing, BacchusModel BacchusModel)
        {
            // On supprime toutes les données de la base car on est en méthode écrasement
            if (Removing)
            {
                // On vide les données du modèle existant
                BacchusModel.ClearAll();
                Dao.ClearTables();
            }

            // On lit et instancit les données du fichier CSV
            using (var StreamReader = new StreamReader(FilePath, Encoding.Default))
            {
                // On compte le nombre de ligne total
                var NbLines = File.ReadAllLines(FilePath).Length;
                SetMaxValue?.Invoke(NbLines);

                var CurrentLine = 0;

                // On saute la première ligne avec les entêtes
                StreamReader.ReadLine();
                CurrentLine++;

                string Line;
                while ((Line = StreamReader.ReadLine()) != null)
                {
                    CurrentLine++;

                    // On lit la ligne en séparant selon le ;
                    var Values = Line.Split(';');

                    // On récupère chaque colonne en retirant les espaces au début et à la fin qui sont en trop
                    var Description = Values[0].Trim();
                    var RefArticle = Values[1].Trim();
                    var NomMarque = Values[2].Trim();
                    var NomFamille = Values[3].Trim();
                    var NomSousFamille = Values[4].Trim();
                    var PrixHt = float.Parse(Values[5].Trim());

                    // Si l'article existe déjà on va ignorer la ligne
                    if (BacchusModel.GetArticle(RefArticle) != null)
                    {
                        HasToUpdate?.Invoke(CurrentLine);
                        continue;
                    }

                    // On enregistre la marque si elle n'existe pas déjà
                    var Marque = BacchusModel.GetMarque(NomMarque);
                    if (Marque == null)
                    {
                        Marque = Dao.Save(new Marque(0, NomMarque));
                        BacchusModel.Add(Marque);
                    }

                    // On enregistre la famille si elle n'existe pas déjà
                    var Famille = BacchusModel.GetFamille(NomFamille);
                    if (Famille == null)
                    {
                        Famille = Dao.Save(new Famille(0, NomFamille));
                        BacchusModel.Add(Famille);
                    }

                    // On enregistre la sous famille si elle n'existe pas déjà
                    var SousFamille = BacchusModel.GetSousFamille(NomSousFamille);
                    if (SousFamille == null)
                    {
                        SousFamille = Dao.Save(new SousFamille(0, Famille, NomSousFamille));
                        BacchusModel.Add(SousFamille);
                    }

                    // On enregistre l'article
                    var Article = new Article(RefArticle, Description, SousFamille, Marque, PrixHt, 1);
                    BacchusModel.Add(Article);
                    Dao.Save(Article);

                    HasToUpdate?.Invoke(CurrentLine);
                }

                StreamReader.Close();

                SetNbArticlesAdded?.Invoke(BacchusModel.Articles.Count);
            }
        }

        /// <summary>
        /// Fonction exportant les données dans un fichier CSV
        /// </summary>
        /// <param name="FilePath">Le chemin du fichier</param>
        /// <param name="BacchusModel">Le modèle à exporter</param>
        public static void ExportCsv(string FilePath, BacchusModel BacchusModel)
        {
            using (var StreamWriter =
                new StreamWriter(new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Write), Encoding.Default))
            {
                SetMaxValue?.Invoke(BacchusModel.Articles.Count);

                StreamWriter.Write("Description;Ref;Marque;Famille;Sous-Famille;Prix H.T.\n");
                var CurrentArticle = 0;
                foreach (var Article in BacchusModel.Articles)
                {
                    StreamWriter.Write(Article.ToCsv());

                    CurrentArticle++;
                    HasToUpdate?.Invoke(CurrentArticle);
                }

                StreamWriter.Close();

                SetNbArticlesExported?.Invoke(CurrentArticle);
            }
        }
    }
}