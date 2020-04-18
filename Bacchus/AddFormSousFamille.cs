using System;
using System.Windows.Forms;
using Bacchus.model;

namespace Bacchus
{
    public partial class AddFormSousFamille : Form
    {
        public AddFormSousFamille()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialise les combobox de la vue
        /// </summary>
        public void AddFormSousFamille_Load()
        {
            var BacchusModel = ((FormMain) Owner).BacchusModel;

            ComboBoxFamille.DataSource = BacchusModel.Familles;
            ComboBoxFamille.DisplayMember = "Nom";
            ComboBoxFamille.ValueMember = "RefFamille";
        }

        /// <summary>
        /// On crée l'action d'ajout d'une sous-famille
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ButtonAdd_Click(object Sender, EventArgs Event)
        {
            if (TextBoxNom.Text == "")
            {
                MessageBox.Show(@"Veuillez remplir le champ Nom", @"Attention", MessageBoxButtons.OK);
            }
            else
            {
                var BacchusModel = ((FormMain) Owner).BacchusModel;
                var Nom = TextBoxNom.Text;
                var Famille = BacchusModel.GetFamille(ComboBoxFamille.Text);
                var SousFamille = new SousFamille(0, Famille, Nom);

                if (BacchusModel.GetSousFamille(Nom) != null)
                {
                    MessageBox.Show(@"Une sous famille avec ce nom existe déjà", @"Attention", MessageBoxButtons.OK);
                }
                else
                {
                    Dao.Save(SousFamille);
                    BacchusModel.Add(SousFamille);
                    ((FormMain) Owner).UpdateListView();
                    Close();
                }
            }
        }

        /// <summary>
        /// On crée l'action d'annulation d'ajout d'une sous-famille
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ButtonCancel_Click(object Sender, EventArgs Event)
        {
            Close();
        }
    }
}