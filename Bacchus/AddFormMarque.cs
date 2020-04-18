using System;
using System.Windows.Forms;
using Bacchus.model;

namespace Bacchus
{
    public partial class AddFormMarque : Form
    {
        public AddFormMarque()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction d'annulation de l'ajout de la marque
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ButtonCancel_Click(object Sender, EventArgs Event)
        {
            Close();
        }

        /// <summary>
        /// Fonction d'ajout de la marque à la base de données
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void AddButton_Click(object Sender, EventArgs Event)
        {
            // On vérifie que le nom de la marque est bien saisi
            if (TextBoxNom.Text.Equals(""))
            {
                MessageBox.Show(@"Vous n'avez pas saisi de nom pour la marque", @"Attention", MessageBoxButtons.OK);
            }
            else
            {
                var TempMarque = ((FormMain) Owner).BacchusModel.GetMarque(TextBoxNom.Text);

                // On vérifie que le nom de la marque saisi n'existe pas déjà
                if (TempMarque != null)
                {
                    MessageBox.Show(@"Une marque avec ce nom existe déjà", @"Attention", MessageBoxButtons.OK);
                }
                else
                {
                    // On crée la marque si toutes les conditions sont validées
                    var Marque = new Marque(0, TextBoxNom.Text);
                    try
                    {
                        Dao.Save(Marque);
                        ((FormMain) Owner).BacchusModel.Add(Marque);

                        ((FormMain) Owner).UpdateListView();
                        Close();
                    }
                    catch (Exception Exception)
                    {
                        Console.Write(Exception.Message);
                        MessageBox.Show(@"La référence/nom de la marque est déjà utilisée", @"Attention",
                            MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void AddFormMarque_Load(object Sender, EventArgs Event)
        {
        }
    }
}