using System.Collections.Generic;
using System.Data;

namespace Bacchus.model
{
    public class BacchusModel
    {
        public List<Famille> Familles { get; set; } = new List<Famille>();

        public List<Marque> Marques { get; set; } = new List<Marque>();

        public List<SousFamille> SousFamilles { get; set; } = new List<SousFamille>();

        public List<Article> Articles { get; set; } = new List<Article>();

        /// <summary>
        /// Fonction retournant une famille selon sa référence
        /// </summary>
        /// <param name="RefFamille">La référence de la famille voulue</param>
        /// <returns>La famille</returns>
        public Famille GetFamille(int RefFamille)
        {
            foreach (var Famille in Familles)
            {
                if (Famille.RefFamille == RefFamille)
                    return Famille;
            }

            return null;
        }

        /// <summary>
        /// Fonction retournant une famille selon le nom
        /// </summary>
        /// <param name="Nom">Le nom de la famille</param>
        /// <returns>La famille</returns>
        public Famille GetFamille(string Nom)
        {
            foreach (var Famille in Familles)
            {
                if (Famille.Nom == Nom)
                    return Famille;
            }

            return null;
        }

        /// <summary>
        /// Fonction retournant une sous famille selon sa référence
        /// </summary>
        /// <param name="RefSousFamille">La référence de la sous famille voulue</param>
        /// <returns>La sous famille</returns>
        public SousFamille GetSousFamille(int RefSousFamille)
        {
            foreach (var SousFamille in SousFamilles)
            {
                if (SousFamille.RefSousFamille == RefSousFamille)
                    return SousFamille;
            }

            return null;
        }

        /// <summary>
        /// Fonction retournant une sous famille selon son nom
        /// </summary>
        /// <param name="Nom">Le nom de la sous famille</param>
        /// <returns>La sous famille</returns>
        public SousFamille GetSousFamille(string Nom)
        {
            foreach (var SousFamille in SousFamilles)
            {
                if (SousFamille.Nom == Nom)
                    return SousFamille;
            }

            return null;
        }

        /// <summary>
        /// Fonction retournant une marque selon sa référence
        /// </summary>
        /// <param name="RefMarque">La référence de la marque voulue</param>
        /// <returns>La marque</returns>
        public Marque GetMarque(int RefMarque)
        {
            foreach (var Marque in Marques)
            {
                if (Marque.RefMarque == RefMarque)
                    return Marque;
            }

            return null;
        }

        /// <summary>
        /// Fonction retournant une marque selon son nom
        /// </summary>
        /// <param name="Nom">Le nom de la marque</param>
        /// <returns>La marque</returns>
        public Marque GetMarque(string Nom)
        {
            foreach (var Marque in Marques)
            {
                if (Marque.Nom == Nom)
                    return Marque;
            }

            return null;
        }

        /// <summary>
        /// Fonction retournant un article selon sa référence
        /// </summary>
        /// <param name="RefArticle">La référence de l'article voulu</param>
        /// <returns>L'article</returns>
        public Article GetArticle(string RefArticle)
        {
            foreach (var Article in Articles)
            {
                if (Article.RefArticle.Equals(RefArticle))
                    return Article;
            }

            return null;
        }

        public void Add(Marque Marque)
        {
            Marques.Add(Marque);
        }

        public void Add(Famille Famille)
        {
            Familles.Add(Famille);
        }

        public void Add(SousFamille SousFamille)
        {
            SousFamilles.Add(SousFamille);
        }

        public void Add(Article Article)
        {
            Articles.Add(Article);
        }

        public void ClearAll()
        {
            Articles.Clear();
            Familles.Clear();
            SousFamilles.Clear();
            Marques.Clear();
        }

        public void Remove(SousFamille SousFamille)
        {
            foreach (var Article in Articles)
            {
                if (SousFamille.Equals(Article.SousFamille))
                    throw new ConstraintException("La sous famille est encore référencée parmi des articles");
            }

            SousFamilles.Remove(SousFamille);
        }

        public void Remove(Famille Famille)
        {
            foreach (var SousFamille in SousFamilles)
            {
                if (Famille.Equals(SousFamille.Famille))
                    throw new ConstraintException("La famille est encore référencée parmi des sous familles");
            }

            Familles.Remove(Famille);
        }

        public void Remove(Marque Marque)
        {
            foreach (var Article in Articles)
            {
                if (Marque.Equals(Article.Marque))
                    throw new ConstraintException("La marque est encore référencée parmi des articles");
            }

            Marques.Remove(Marque);
        }

        public void Remove(Article Article)
        {
            Articles.Remove(Article);
        }
    }
}