using System;
using System.Windows.Forms;
using Bacchus.model;

namespace Bacchus
{
    public partial class ModifFormMarque : Form
    {
        private string NomMarque;
        private int RefMarque;

        public ModifFormMarque()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction d'initialisation du champ dans la TextBox et des attributs
        /// </summary>
        /// <param name="Marque">La marque que nous modifions</param>
        public void InitializeMarque(Marque Marque)
        {
            RefMarque = Marque.RefMarque;
            NomMarque = Marque.Nom;

            TextBoxNom.Text = Marque.Nom;
        }

        /// <summary>
        /// Fonction appelée lorsque l'utilisateur annule la modification de la marque
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ButtonCancel_Click(object Sender, EventArgs Event)
        {
            Close();
        }

        /// <summary>
        /// Fonction de modification de la marque
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ModifyButton_Click(object Sender, EventArgs Event)
        {
            // On remarque d'abord si le nom de la marque est non nul
            if (TextBoxNom.Text.Equals(""))
            {
                MessageBox.Show(@"Vous n'avez pas saisi de nom pour la marque", @"Attention", MessageBoxButtons.OK);
            }
            else
            {
                var TempMarque = ((FormMain) Owner).BacchusModel.GetMarque(TextBoxNom.Text);

                // On regarde ensuite si il n'existe pas déjà une marque avec le nom de la marque modifié, qui ne soit pas la marque actuelle
                if (TempMarque != null && !TempMarque.Nom.Equals(NomMarque))
                {
                    MessageBox.Show(@"Une marque avec ce nom existe déjà", @"Attention", MessageBoxButtons.OK);
                }
                else
                {
                    // On modifie la marque si toutes les conditions sont validées
                    var Marque = ((FormMain) Owner).BacchusModel.GetMarque(RefMarque);
                    Marque.Nom = TextBoxNom.Text;

                    Dao.Update(Marque);

                    ((FormMain) Owner).UpdateListView();
                    Close();
                }
            }
        }

        private void ModifFormMarque_Load(object Sender, EventArgs Event)
        {
        }
    }
}