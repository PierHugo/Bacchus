using System;
using System.Globalization;
using System.Windows.Forms;
using Bacchus.model;

namespace Bacchus
{
    public partial class ModifFormArticle : Form
    {
        public ModifFormArticle()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction permettant de préremplir les champs pour la modification de l'article
        /// </summary>
        /// <param name="Article">L'article qui va être modifié</param>
        public void FillField(Article Article)
        {
            // On remplit les champs texte
            TextBoxRef.Text = Article.RefArticle;
            TextBoxPrix.Text = Article.PrixHt.ToString(CultureInfo.CurrentCulture);
            TextBoxQuant.Text = Article.Quantite.ToString();
            TextBoxDescription.Text = Article.Description;

            var BacchusModel = ((FormMain) Owner).BacchusModel;

            // On remplit la comboBox des familles
            ComboBoxFamille.DataSource = BacchusModel.Familles;
            ComboBoxFamille.DisplayMember = "Nom";
            ComboBoxFamille.ValueMember = "RefFamille";
            ComboBoxFamille.SelectedItem = Article.SousFamille.Famille;
            ComboBoxFamille.DropDownStyle = ComboBoxStyle.DropDownList;

            // On remplit la comboBox des marques
            ComboBoxMarque.DataSource = BacchusModel.Marques;
            ComboBoxMarque.DisplayMember = "Nom";
            ComboBoxMarque.ValueMember = "RefMarque";
            ComboBoxMarque.SelectedItem = Article.Marque;
            ComboBoxMarque.DropDownStyle = ComboBoxStyle.DropDownList;

            /*
             * La comboBox des sous familles se charge par un évenement "indexChanged" de la box des familles
             * On set donc juste le bon nom de sous familles
             */
            ComboBoxSousFamille.DataSource = Dao.GetFamilleSousFamilles(Article.SousFamille.Famille);
            ComboBoxSousFamille.DisplayMember = "Nom";
            ComboBoxSousFamille.ValueMember = "RefSousFamille";
            ComboBoxSousFamille.SelectedText = Article.SousFamille.Nom;
            ComboBoxSousFamille.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// On crée l'action d'annulation de la modification
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ButtonCancel_Click(object Sender, EventArgs Event)
        {
            Close();
        }

        /// <summary>
        /// On crée l'action de modification de l'article
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ButtonModif_Click(object Sender, EventArgs Event)
        {
            var BacchusModel = ((FormMain) Owner).BacchusModel;

            if (TextBoxQuant.Text.Equals("") || TextBoxPrix.Text.Equals("") || TextBoxDescription.Text.Equals(""))
            {
                MessageBox.Show(@"Vous n'avez pas saisi de valeur pour la quantité, le prix, ou la description",
                    @"Attention",
                    MessageBoxButtons.OK);
            }
            else
            {
                var Article = BacchusModel.GetArticle(TextBoxRef.Text);

                Article.Description = TextBoxDescription.Text;
                Article.Quantite = int.Parse(TextBoxQuant.Text);
                Article.PrixHt = float.Parse(TextBoxPrix.Text, CultureInfo.InvariantCulture);

                Article.SousFamille = BacchusModel.GetSousFamille(ComboBoxSousFamille.Text);
                Article.Marque = BacchusModel.GetMarque(ComboBoxMarque.Text);

                Dao.Update(Article);

                ((FormMain) Owner).UpdateListView();
                Close();
            }
        }

        /// <summary>
        /// Action lorsqu'une touche est saisie par l'utilisateur dans le champ quantité
        /// Pour ne permettre la saisie que de chiffres
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void TextBoxQuant_KeyPress(object Sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar) &&
                (Event.KeyChar != '.'))
            {
                Event.Handled = true;
            }
        }

        /// <summary>
        /// Action lorsqu'une touche est saisie par l'utilisateur dans le champ prix
        /// Pour ne permettre la saisie que de chiffres
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void TextBoxPrix_KeyPress(object Sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar) &&
                (Event.KeyChar != '.'))
            {
                Event.Handled = true;
            }

            if ((Event.KeyChar == '.') && (((TextBox) Sender).Text.IndexOf('.') > -1))
            {
                Event.Handled = true;
            }
        }

        /// <summary>
        /// Action lorsque l'index dans la comboBox des familles change
        /// Pour charger les sous familles liées
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ComboBoxFamille_SelectedIndexChanged(object Sender, EventArgs Event)
        {
            var Item = ComboBoxFamille.Text;

            var Famille = ((FormMain) Owner).BacchusModel.GetFamille(Item);

            ComboBoxSousFamille.DataSource = Dao.GetFamilleSousFamilles(Famille);
            ComboBoxSousFamille.DisplayMember = "Nom";
            ComboBoxSousFamille.ValueMember = "RefSousFamille";
        }
    }
}