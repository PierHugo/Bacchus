using System;
using System.Windows.Forms;
using Bacchus.model;

namespace Bacchus
{
    public partial class AddFormFamille : Form
    {
        public AddFormFamille()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On crée l'action d'ajout d'une famille
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
                var Nom = TextBoxNom.Text;
                var Famille = new Famille(0, Nom);

                if (((FormMain) Owner).BacchusModel.GetFamille(Nom) != null)
                {
                    MessageBox.Show(@"Une famille avec ce nom existe déjà", @"Attention", MessageBoxButtons.OK);
                }
                else
                {
                    Dao.Save(Famille);
                    ((FormMain) Owner).BacchusModel.Add(Famille);
                    ((FormMain) Owner).UpdateListView();
                    Close();
                }
            }
        }

        /// <summary>
        /// On crée l'action d'annulation d'ajout d'une famille
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ButtonCancel_Click(object Sender, EventArgs Event)
        {
            Close();
        }
    }
}