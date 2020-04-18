using System;
using System.Windows.Forms;
using Bacchus.model;

namespace Bacchus
{
    public partial class ModifFormSousFamille : Form
    {
        public ModifFormSousFamille()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction permettant de préremplir les champs pour la modification de la sous-famille
        /// </summary>
        /// <param name="SousFamille">La sous-famille qui va être modifié</param>
        public void FillField(SousFamille SousFamille)
        {
            // On remplit les champs texte
            TextBoxNom.Text = SousFamille.Nom;
            LabelRefSousFamille.Text = SousFamille.RefSousFamille.ToString();

            var BacchusModel = ((FormMain) Owner).BacchusModel;

            // On remplit la comboBox des familles
            ComboBoxFamille.DataSource = BacchusModel.Familles;
            ComboBoxFamille.DisplayMember = "Nom";
            ComboBoxFamille.ValueMember = "RefFamille";
            ComboBoxFamille.SelectedItem = SousFamille.Famille;
        }

        /// <summary>
        /// On crée l'action de modification d'une sous-famille
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ButtonModif_Click(object Sender, EventArgs Event)
        {
            if (TextBoxNom.Text == "")
            {
                MessageBox.Show(@"Veuillez remplir le champ Nom", @"Attention", MessageBoxButtons.OK);
            }
            else
            {
                var BacchusModel = ((FormMain) Owner).BacchusModel;
                var Nom = TextBoxNom.Text;
                var RefSousFamille = int.Parse(LabelRefSousFamille.Text);
                var Famille = BacchusModel.GetFamille(ComboBoxFamille.Text);

                var TempSousFamille = BacchusModel.GetSousFamille(Nom);

                if (TempSousFamille != null && TempSousFamille.RefSousFamille != RefSousFamille)
                {
                    MessageBox.Show(@"Une sous famille avec ce nom existe déjà", @"Attention", MessageBoxButtons.OK);
                }
                else
                {
                    var SousFamille = BacchusModel.GetSousFamille(RefSousFamille);
                    SousFamille.Famille = Famille;
                    SousFamille.Nom = Nom;

                    Dao.Update(SousFamille);
                    ((FormMain) Owner).UpdateListView();
                    Close();
                }
            }
        }

        /// <summary>
        /// On crée l'annulation de la modfication d'une sous-famille
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ButtonCancel_Click(object Sender, EventArgs Event)
        {
            Close();
        }
    }
}