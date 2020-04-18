using System;
using System.Globalization;
using System.Windows.Forms;
using Bacchus.model;

namespace Bacchus
{
    public partial class AddFormArticle : Form
    {
        public AddFormArticle()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialise les combobox de la vue
        /// </summary>
        public void AddFormArticle_Load()
        {
            var BacchusModel = ((FormMain) Owner).BacchusModel;

            ComboBoxFamile.DataSource = BacchusModel.Familles;
            ComboBoxFamile.DisplayMember = "Nom";
            ComboBoxFamile.ValueMember = "RefFamille";

            ComboBoxMarque.DataSource = BacchusModel.Marques;
            ComboBoxMarque.DisplayMember = "Nom";
            ComboBoxMarque.ValueMember = "RefMarque";

            var Famille = BacchusModel.GetFamille((int) ComboBoxFamile.SelectedValue);
            var SousFamille = Dao.GetFamilleSousFamilles(Famille);
            ComboBoxSousFamille.DataSource = SousFamille;
            ComboBoxSousFamille.DisplayMember = "Nom";
            ComboBoxSousFamille.ValueMember = "RefSousFamille";
        }

        /// <summary>
        /// Pour changer la combobox des sous-famille si la combox des familles est changée.
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ComboBoxFamile_SelectedIndexChanged(object Sender, EventArgs Event)
        {
            var BacchusModel = ((FormMain) Owner).BacchusModel;

            var Famille = BacchusModel.GetFamille((int) ComboBoxFamile.SelectedValue);
            var SousFamille = Dao.GetFamilleSousFamilles(Famille);
            ComboBoxSousFamille.DataSource = SousFamille;
            ComboBoxSousFamille.DisplayMember = "Nom";
            ComboBoxSousFamille.ValueMember = "RefSousFamille";
        }

        /// <summary>
        /// Pour n'autoriser que les nombres
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
        /// Pour n'autoriser que les nombres
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
        /// On crée l'annulation de la création d'un article
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ButtonCancel_Click(object Sender, EventArgs Event)
        {
            Close();
        }

        /// <summary>
        /// On crée l'action d'ajout d'un article
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ButtonAdd_Click(object Sender, EventArgs Event)
        {
            var BacchusModel = ((FormMain) Owner).BacchusModel;

            if (TextBoxQuant.Text.Equals("") || TextBoxPrix.Text.Equals("") || TextBoxRef.Text.Equals("") ||
                TextBoxDescription.Text.Equals(""))
            {
                MessageBox.Show(@"Vous n'avez pas remplit tous les champs", @"Attention", MessageBoxButtons.OK);
            }
            else
            {
                if (BacchusModel.GetArticle(TextBoxRef.Text) != null)
                {
                    MessageBox.Show(@"La référence de l'article est déjà utilisée", @"Attention", MessageBoxButtons.OK);
                }
                else
                {
                    if (TextBoxRef.Text.IndexOf('F') == -1 || TextBoxRef.Text.Length != 8)
                    {
                        MessageBox.Show(
                            @"La référence de l'article doit contenir un F en première position et 8 caractères au total",
                            @"Attention", MessageBoxButtons.OK);
                    }
                    else
                    {
                        var SousFamille = BacchusModel.GetSousFamille(ComboBoxSousFamille.Text);
                        var Marque = BacchusModel.GetMarque(ComboBoxMarque.Text);
                        var Description = TextBoxDescription.Text;
                        var Prix = TextBoxPrix.Text;
                        var Quantite = TextBoxQuant.Text;
                        var Reference = TextBoxRef.Text;

                        var PrixHt = float.Parse(Prix, CultureInfo.InvariantCulture);
                        var QuantiteInt = int.Parse(Quantite);

                        var Article = new Article(Reference, Description, SousFamille, Marque, PrixHt, QuantiteInt);

                        BacchusModel.Add(Article);
                        Dao.Save(Article);
                        ((FormMain) Owner).UpdateListView();
                        ((FormMain) Owner).UpdateNbArticles(0);
                        Close();
                    }
                }
            }
        }
    }
}