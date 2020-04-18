using System;
using System.Windows.Forms;
using Bacchus.model;

namespace Bacchus
{
    public partial class ModifFormFamille : Form
    {
        public ModifFormFamille()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction permettant de préremplir les champs pour la modification de la famille
        /// </summary>
        /// <param name="Famille">La Famille qui va être modifié</param>
        public void FillField(Famille Famille)
        {
            // On remplit les champs texte
            TextBoxNom.Text = Famille.Nom;
            LabelRefFamille.Text = Famille.RefFamille.ToString();
        }

        /// <summary>
        /// On crée l'action de modification d'une famille
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ButtonModifier_Click(object Sender, EventArgs Event)
        {
            if (TextBoxNom.Text == "")
            {
                MessageBox.Show(@"Veuillez remplir le champ Nom", @"Attention", MessageBoxButtons.OK);
            }
            else
            {
                var TempFamille = ((FormMain) Owner).BacchusModel.GetFamille(TextBoxNom.Text);
                var Nom = TextBoxNom.Text;
                var RefFamille = int.Parse(LabelRefFamille.Text);

                if (TempFamille != null && TempFamille.RefFamille != RefFamille)
                {
                    MessageBox.Show(@"Une famille avec ce nom existe déjà", @"Attention", MessageBoxButtons.OK);
                }
                else
                {
                    var Famille = ((FormMain) Owner).BacchusModel.GetFamille(RefFamille);
                    Famille.Nom = Nom;

                    Dao.Update(Famille);
                    ((FormMain) Owner).UpdateListView();
                    Close();
                }
            }
        }

        /// <summary>
        /// On crée l'action d'annulation de modification d'une famille
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ButtonCancel_Click(object Sender, EventArgs Event)
        {
            Close();
        }
    }
}