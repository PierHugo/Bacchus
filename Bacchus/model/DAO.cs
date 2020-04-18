using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Bacchus.model
{
    public static class Dao
    {
        private static readonly SQLiteConnection Database = new SQLiteConnection("Data Source=Bacchus.SQLite");

        /// <summary>
        /// Fonction ouvrant la connexion de la base de données
        /// </summary>
        private static void InitConnexion()
        {
            if (Database.State == ConnectionState.Closed)
                Database.Open();
        }

        /// <summary>
        /// Fonction fermant la connexion à la base de données
        /// </summary>
        private static void CloseConnexion()
        {
            if (Database.State == ConnectionState.Open)
                Database.Close();
        }

        /// <summary>
        /// Fonction retournant la liste des marques
        /// </summary>
        /// <returns>La liste des marques de la base de données</returns>
        private static List<Marque> GetAllMarques()
        {
            var Marques = new List<Marque>();

            InitConnexion();
            var Command = new SQLiteCommand("SELECT * FROM Marques", Database);
            var Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                var RefMarque = Reader.GetInt32(0);
                var Nom = Reader.GetString(1);
                Marques.Add(new Marque(RefMarque, Nom));
            }

            Reader.Close();
            CloseConnexion();

            return Marques;
        }

        /// <summary>
        /// Fonction retournant la liste des familles
        /// </summary>
        /// <returns>La liste des familles de la base de données</returns>
        private static List<Famille> GetAllFamilles()
        {
            var Familles = new List<Famille>();

            InitConnexion();
            var Command = new SQLiteCommand("SELECT * FROM Familles", Database);
            var Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                var RefFamille = Reader.GetInt32(0);
                var Nom = Reader.GetString(1);
                Familles.Add(new Famille(RefFamille, Nom));
            }

            Reader.Close();
            CloseConnexion();

            return Familles;
        }

        /// <summary>
        /// Fonction retournant la liste des sous familles
        /// </summary>
        /// <returns>La liste des sous familles de la base de données</returns>
        private static List<SousFamille> GetAllSousFamilles(BacchusModel BacchusModel)
        {
            var SousFamilles = new List<SousFamille>();

            InitConnexion();
            var Command = new SQLiteCommand("SELECT * FROM SousFamilles", Database);
            var Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                var RefSousFamille = Reader.GetInt32(0);
                var Famille = BacchusModel.GetFamille(Reader.GetInt32(1));
                var Nom = Reader.GetString(2);

                SousFamilles.Add(new SousFamille(RefSousFamille, Famille, Nom));
            }

            Reader.Close();
            CloseConnexion();

            return SousFamilles;
        }

        /// <summary>
        /// Fonction retournant la liste des sous familles d'une famille
        /// </summary>
        /// <returns>La liste des sous familles de la base de données</returns>
        public static List<SousFamille> GetFamilleSousFamilles(Famille Famille)
        {
            var SousFamilles = new List<SousFamille>();

            InitConnexion();
            var Command = new SQLiteCommand("SELECT * FROM SousFamilles WHERE RefFamille = :refFamille", Database);
            Command.Parameters.AddWithValue("refFamille", Famille.RefFamille);
            var Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                var RefSousFamille = Reader.GetInt32(0);
                var Nom = Reader.GetString(2);

                SousFamilles.Add(new SousFamille(RefSousFamille, Famille, Nom));
            }

            Reader.Close();
            CloseConnexion();

            return SousFamilles;
        }

        /// <summary>
        /// Fonction retournant la liste des articles
        /// </summary>
        /// <returns>La liste des articles de la base de données</returns>
        private static List<Article> GetAllArticles(BacchusModel BacchusModel)
        {
            var Articles = new List<Article>();

            InitConnexion();
            var Command = new SQLiteCommand("SELECT * FROM Articles", Database);
            var Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                var RefArticle = Reader.GetString(0);
                var Description = Reader.GetString(1);
                var SousFamille = BacchusModel.GetSousFamille(Reader.GetInt32(2));
                var Marque = BacchusModel.GetMarque(Reader.GetInt32(3));
                var PrixHt = Reader.GetFloat(4);
                var Quantite = Reader.GetInt32(5);

                Articles.Add(new Article(RefArticle, Description, SousFamille, Marque, PrixHt, Quantite));
            }

            Reader.Close();
            CloseConnexion();

            return Articles;
        }

        /// <summary>
        /// Fonction récupérant toutes les données de la base de données à l'instanciation de l'application
        /// </summary>
        /// <returns>Le modèle contenant les données de l'application</returns>
        public static BacchusModel InitialiseAll()
        {
            var BacchusModel = new BacchusModel
            {
                Marques = GetAllMarques(),
                Familles = GetAllFamilles(),
            };
            BacchusModel.SousFamilles = GetAllSousFamilles(BacchusModel);
            BacchusModel.Articles = GetAllArticles(BacchusModel);

            return BacchusModel;
        }

        /// <summary>
        /// Fonction enregistrant un article dans la base de données
        /// </summary>
        /// <param name="Article">L'article à enregistrer</param>
        public static void Save(Article Article)
        {
            InitConnexion();

            using (var Transaction = Database.BeginTransaction())
            {
                using (var Command = new SQLiteCommand(Database))
                {
                    Command.CommandText =
                        "INSERT INTO Articles (RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite) VALUES (:refArticle, :descript, :refSousFamille, :refMarque, :prix, :quantite)";

                    Command.Parameters.AddWithValue("refArticle", Article.RefArticle);
                    Command.Parameters.AddWithValue("descript", Article.Description);
                    Command.Parameters.AddWithValue("refSousFamille", Article.SousFamille.RefSousFamille);
                    Command.Parameters.AddWithValue("refMarque", Article.Marque.RefMarque);
                    Command.Parameters.AddWithValue("prix", Article.PrixHt);
                    Command.Parameters.AddWithValue("quantite", Article.Quantite);

                    Command.ExecuteNonQuery();

                    Transaction.Commit();
                    Command.Dispose();
                }
            }

            CloseConnexion();
        }

        /// <summary>
        /// Fonction enregistrant une sous famille dans la base de données
        /// </summary>
        /// <param name="SousFamille">La sous famille à enregistrer</param>
        /// <returns>La sous famille avec sa référence changée selon la base de données</returns>
        public static SousFamille Save(SousFamille SousFamille)
        {
            InitConnexion();

            using (var Command = new SQLiteCommand(Database))
            {
                // On récupère la référence maximale afin de créer la référence de la sous famille
                Command.CommandText = "SELECT MAX(RefSousFamille) FROM SousFamilles";
                var Scalar = Command.ExecuteScalar();
                SousFamille.RefSousFamille = Scalar.ToString().Equals("") ? 0 : Convert.ToInt32(Scalar) + 1;

                using (var Transaction = Database.BeginTransaction())
                {
                    // Enregistrement de la sous famille
                    Command.CommandText =
                        "INSERT INTO SousFamilles (RefSousFamille, RefFamille, Nom) VALUES (:refSousFamille, :refFamille, :nom)";
                    Command.Parameters.AddWithValue("refSousFamille", SousFamille.RefSousFamille);
                    Command.Parameters.AddWithValue("refFamille", SousFamille.Famille.RefFamille);
                    Command.Parameters.AddWithValue("nom", SousFamille.Nom);

                    Command.ExecuteNonQuery();

                    Transaction.Commit();
                    Command.Dispose();
                }
            }

            CloseConnexion();
            return SousFamille;
        }

        /// <summary>
        /// Fonction enregistrant une famille dans la base de données
        /// </summary>
        /// <param name="Famille">La famille à enregistrer</param>
        /// <returns>La famille avec sa référence changée selon la base de données</returns>
        public static Famille Save(Famille Famille)
        {
            InitConnexion();

            using (var Command = new SQLiteCommand(Database))
            {
                Command.CommandText = "SELECT MAX(RefFamille) FROM Familles";
                var Scalar = Command.ExecuteScalar();
                Famille.RefFamille = Scalar.ToString().Equals("") ? 0 : Convert.ToInt32(Scalar) + 1;

                using (var Transaction = Database.BeginTransaction())
                {
                    Command.CommandText = "INSERT INTO Familles (RefFamille, Nom) VALUES (:refFamille, :nom)";
                    Command.Parameters.AddWithValue("refFamille", Famille.RefFamille);
                    Command.Parameters.AddWithValue("nom", Famille.Nom);
                    Command.ExecuteNonQuery();

                    Transaction.Commit();
                    Command.Dispose();
                }
            }

            CloseConnexion();
            return Famille;
        }

        /// <summary>
        /// Fonction enregistrant une marque dans la base de données
        /// </summary>
        /// <param name="Marque">La marque à enregistrer</param>
        /// <returns>La marque avec la référence changée selon la base de données</returns>
        public static Marque Save(Marque Marque)
        {
            InitConnexion();

            using (var Command = new SQLiteCommand(Database))
            {
                Command.CommandText = "SELECT MAX(RefMarque) FROM Marques";
                var Scalar = Command.ExecuteScalar();
                Marque.RefMarque = Scalar.ToString().Equals("") ? 0 : Convert.ToInt32(Scalar) + 1;

                using (var Transaction = Database.BeginTransaction())
                {
                    Command.CommandText = "INSERT INTO Marques (RefMarque, Nom) VALUES (:refMarque, :nom)";
                    Command.Parameters.AddWithValue("refMarque", Marque.RefMarque);
                    Command.Parameters.AddWithValue("nom", Marque.Nom);
                    Command.ExecuteNonQuery();

                    Transaction.Commit();
                    Command.Dispose();
                }
            }

            CloseConnexion();
            return Marque;
        }

        /// <summary>
        /// Fonction mettant à jour une marque donnée dans la base de données
        /// </summary>
        /// <param name="Marque">La marque à mettre à jour</param>
        public static void Update(Marque Marque)
        {
            InitConnexion();

            var Command = new SQLiteCommand("UPDATE Marques SET Nom = :nom WHERE RefMarque = :refMarque", Database);
            Command.Parameters.AddWithValue("nom", Marque.Nom);
            Command.Parameters.AddWithValue("refMarque", Marque.RefMarque);
            Command.ExecuteNonQuery();

            CloseConnexion();
        }

        /// <summary>
        /// Fonction mettant à jour une famille donnée dans la base de données
        /// </summary>
        /// <param name="Famille">La famille à mettre à jour</param>
        public static void Update(Famille Famille)
        {
            InitConnexion();

            var Command = new SQLiteCommand("UPDATE Familles SET Nom = :nom WHERE RefFamille = :refFamille", Database);
            Command.Parameters.AddWithValue("nom", Famille.Nom);
            Command.Parameters.AddWithValue("refFamille", Famille.RefFamille);
            Command.ExecuteNonQuery();

            CloseConnexion();
        }

        /// <summary>
        /// Fonction mettant à jour une sous famille donnée dans la base de données
        /// </summary>
        /// <param name="SousFamille">La sous famille à mettre à jour</param>
        public static void Update(SousFamille SousFamille)
        {
            InitConnexion();

            var Command =
                new SQLiteCommand(
                    "UPDATE SousFamilles SET Nom = :nom, RefFamille = :refFamille WHERE RefSousFamille = :refSousFamille",
                    Database);
            Command.Parameters.AddWithValue("nom", SousFamille.Nom);
            Command.Parameters.AddWithValue("refFamille", SousFamille.Famille.RefFamille);
            Command.Parameters.AddWithValue("refSousFamille", SousFamille.RefSousFamille);
            Command.ExecuteNonQuery();

            CloseConnexion();
        }

        /// <summary>
        /// Fonction mettant à jour un article donné dans la base de données
        /// </summary>
        /// <param name="Article">L'article à mettre à jour</param>
        public static void Update(Article Article)
        {
            InitConnexion();

            var Command =
                new SQLiteCommand(
                    "UPDATE Articles SET Description = :descript, RefSousFamille = :refSousFamille, RefMarque = :refMarque, PrixHT = :prix, Quantite = :quantite WHERE RefArticle = :refArticle",
                    Database);
            Command.Parameters.AddWithValue("descript", Article.Description);
            Command.Parameters.AddWithValue("refSousFamille", Article.SousFamille.RefSousFamille);
            Command.Parameters.AddWithValue("refMarque", Article.Marque.RefMarque);
            Command.Parameters.AddWithValue("prix", Article.PrixHt);
            Command.Parameters.AddWithValue("quantite", Article.Quantite);
            Command.Parameters.AddWithValue("refArticle", Article.RefArticle);
            Command.ExecuteNonQuery();

            CloseConnexion();
        }

        /// <summary>
        /// Fonction de suppression d'un article
        /// </summary>
        /// <param name="Article">L'article que l'on souhaite supprimer</param>
        public static void Delete(Article Article)
        {
            InitConnexion();

            var Command = new SQLiteCommand("DELETE FROM Articles WHERE RefArticle = :refArticle", Database);
            Command.Parameters.AddWithValue("refArticle", Article.RefArticle);
            Command.ExecuteNonQuery();

            CloseConnexion();
        }

        /// <summary>
        /// Fonction de suppression d'une marque
        /// </summary>
        /// <param name="Marque">La marque que l'on souhaite supprimer</param>
        public static void Delete(Marque Marque)
        {
            InitConnexion();

            var Command = new SQLiteCommand("DELETE FROM Marques WHERE RefMarque = :refMarque", Database);
            Command.Parameters.AddWithValue("refMarque", Marque.RefMarque);
            Command.ExecuteNonQuery();

            CloseConnexion();
        }

        /// <summary>
        /// Fonction de suppression d'une famille
        /// </summary>
        /// <param name="Famille">La famille que l'on souhaite supprimer</param>
        public static void Delete(Famille Famille)
        {
            InitConnexion();

            var Command = new SQLiteCommand("DELETE FROM Familles WHERE RefFamille = :refFamille", Database);
            Command.Parameters.AddWithValue("refFamille", Famille.RefFamille);
            Command.ExecuteNonQuery();

            CloseConnexion();
        }

        /// <summary>
        /// Fonction de suppression d'une sous famille
        /// </summary>
        /// <param name="SousFamille">La sous famille à supprimer</param>
        public static void Delete(SousFamille SousFamille)
        {
            InitConnexion();

            var Command = new SQLiteCommand("DELETE FROM SousFamilles WHERE RefSousFamille = :refSousFamille",
                Database);
            Command.Parameters.AddWithValue("refSousFamille", SousFamille.RefSousFamille);
            Command.ExecuteNonQuery();

            CloseConnexion();
        }

        /// <summary>
        /// Fonction supprimant toutes les données de la base
        /// </summary>
        public static void ClearTables()
        {
            InitConnexion();
            var Transaction = Database.BeginTransaction();
            var Command = new SQLiteCommand("DELETE FROM Articles", Database);
            Command.ExecuteNonQuery();
            Command.CommandText = "DELETE FROM Familles";
            Command.ExecuteNonQuery();
            Command.CommandText = "DELETE FROM Marques";
            Command.ExecuteNonQuery();
            Command.CommandText = "DELETE FROM SousFamilles";
            Command.ExecuteNonQuery();
            Transaction.Commit();
            CloseConnexion();
        }
    }
}