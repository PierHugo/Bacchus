using Bacchus.model;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestUtils
    {
        [SetUp]
        public void CreateBacchusModel()
        {
            BacchusModel = new BacchusModel();

            var Marque = new Marque(0, "Marque1");
            var Marque1 = new Marque(1, "Marque2");

            BacchusModel.Add(Marque);
            BacchusModel.Add(Marque1);

            var Famille = new Famille(0, "Famille1");
            var Famille1 = new Famille(1, "Famille2");

            BacchusModel.Add(Famille1);
            BacchusModel.Add(Famille);

            var SousFamille = new SousFamille(0, Famille, "Sous-Famille1");
            var SousFamille1 = new SousFamille(1, Famille1, "Sous-Famille2");

            BacchusModel.Add(SousFamille);
            BacchusModel.Add(SousFamille1);

            var Article = new Article("F88888", "Article1", SousFamille, Marque, (float) 5.5, 1);
            var Article1 = new Article("F99999", "Article2", SousFamille1, Marque1, (float) 65.5, 1);

            BacchusModel.Add(Article);
            BacchusModel.Add(Article1);
        }

        [TearDown]
        public void DeleteBacchusModel()
        {
            Dao.ClearTables();
            BacchusModel.ClearAll();
        }

        private BacchusModel BacchusModel { get; set; }

        [Test]
        public void TestExport()
        {
            Utils.ExportCsv("UnitTest.csv", BacchusModel);
            TestImport();
        }

        [Test]
        public void TestImport()
        {
            Utils.LoadCsv("UnitTest.csv", true, BacchusModel);

            /*
             * On vérifie l'intégralité des données afin de savoir si le parsing entier a été réalisé et réussi
             */
            Assert.NotNull(BacchusModel.GetMarque("Marque1"));
            Assert.NotNull(BacchusModel.GetMarque("Marque2"));

            Assert.NotNull(BacchusModel.GetFamille("Famille1"));
            Assert.NotNull(BacchusModel.GetFamille("Famille2"));

            Assert.NotNull(BacchusModel.GetSousFamille("Sous-Famille1"));
            Assert.AreEqual(BacchusModel.GetSousFamille("Sous-Famille1").Famille.Nom,
                BacchusModel.GetFamille("Famille1").Nom);
            Assert.NotNull(BacchusModel.GetSousFamille("Sous-Famille2"));
            Assert.AreEqual(BacchusModel.GetSousFamille("Sous-Famille2").Famille.Nom,
                BacchusModel.GetFamille("Famille2").Nom);

            Assert.NotNull(BacchusModel.GetArticle("F88888"));
            Assert.AreEqual(BacchusModel.GetArticle("F88888").Marque.Nom, BacchusModel.GetMarque("Marque1").Nom);
            Assert.AreEqual(BacchusModel.GetArticle("F88888").SousFamille.Nom,
                BacchusModel.GetSousFamille("Sous-Famille1").Nom);
            Assert.AreEqual(BacchusModel.GetArticle("F88888").Description, "Article1");

            Assert.NotNull(BacchusModel.GetArticle("F99999"));
            Assert.AreEqual(BacchusModel.GetArticle("F99999").Marque.Nom, BacchusModel.GetMarque("Marque2").Nom);
            Assert.AreEqual(BacchusModel.GetArticle("F99999").SousFamille.Nom,
                BacchusModel.GetSousFamille("Sous-Famille2").Nom);
            Assert.AreEqual(BacchusModel.GetArticle("F99999").Description, "Article2");
        }
    }
}