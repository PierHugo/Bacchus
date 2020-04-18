using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bacchus.model;

namespace Bacchus
{
    public partial class FormMain : Form
    {
        private ListViewColumnSorter ColumnSorter;

        public FormMain()
        {
            InitializeComponent();

            /*
             * Paramétrage de la taille de la fenêtre
             */

            var Settings = Properties.Settings.Default;
            if (Settings.Maximized)
                WindowState = FormWindowState.Maximized;
            else if (Settings.Minimized)
                WindowState = FormWindowState.Minimized;
            else if (Settings.Normal)
            {
                WindowState = FormWindowState.Normal;
                Height = Settings.Height;
                Width = Settings.Width;
            }

            CenterToScreen();
        }

        public BacchusModel BacchusModel { get; private set; }


        private void MainForm_Load(object Sender, EventArgs Event)
        {
            BacchusModel = Dao.InitialiseAll();
            InitTreeView();
            Utils.SetNbArticlesAdded += UpdateNbArticles;

            UpdateNbArticles(0); // On update à zéro car le nombre passé en paramètre importe peu
        }

        public void UpdateNbArticles(int NbArticles)
        {
            ToolStripStatusLabel.Text = @"Il y a " + BacchusModel.Articles.Count + @" articles dans la base de données";
        }

        /// <summary>
        /// Action de click sur le sous menu d'importation
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ImportSousMenu_Click(object Sender, EventArgs Event)
        {
            var ImportForm = new ImportForm
            {
                StartPosition = FormStartPosition.CenterParent
            };
            ImportForm.ShowDialog(this);
        }

        /// <summary>
        /// Action lors d'un click sur le sous menu d'exportation
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ExportSousMenu_Click(object Sender, EventArgs Event)
        {
            var ExportForm = new ExportForm
            {
                StartPosition = FormStartPosition.CenterParent
            };
            ExportForm.ShowDialog(this);
        }

        /// <summary>
        /// Action lors d'un click sur le sous menu de mise à jour de la base de données
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void UpdateSousMenu_Click(object Sender, EventArgs Event)
        {
            UpdateListView();
        }

        private void InitTreeView()
        {
            // On ajoute les nodes principaux à la TreeView
            TreeView.Nodes.Add("Articles", "Articles");
            TreeView.Nodes.Add("Marques", "Marques");
            TreeView.Nodes.Add("Familles", "Familles");
            TreeView.Nodes.Add("Sous-Familles", "Sous-Familles");

            TreeView.Sort();
        }

        /// <summary>
        /// Fonction appelée après la sélection d'un item dans la TreeView
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void TreeView_AfterSelect(object Sender, TreeViewEventArgs Event)
        {
            ColumnSorter = new ListViewColumnSorter();
            ListView.ListViewItemSorter = ColumnSorter;
            UpdateListView();
        }

        /// <summary>
        /// Fonction mettant à jour la ListView en fonction de l'item de la TreeView sélectionné
        /// </summary>
        public void UpdateListView()
        {
            ListView.Clear();
            var Node = TreeView.SelectedNode;

            ListView.Hide();

            if (Node.Name.Equals("Articles"))
            {
                /*
                 * On crée la liste des articles
                 */
                ListView.Columns.Add("Référence", "Référence");
                ListView.Columns.Add("Description", "Description");
                ListView.Columns.Add("Marque", "Marque");
                ListView.Columns.Add("Sous-Famille", "Sous-Famille");
                ListView.Columns.Add("Prix", "Prix H.T.");
                ListView.Columns.Add("Quantité", "Quantité");

                foreach (var Article in BacchusModel.Articles)
                {
                    ListView.Items.Add(new ListViewItem(Article.ToRow()));
                }

                ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ListView.Text = @"Articles";
            }

            else if (Node.Name.Equals("Marques"))
            {
                /*
                 * On crée la liste des marques
                 */
                ListView.Columns.Add("Nom", "Nom");

                foreach (var Marque in BacchusModel.Marques)
                {
                    ListView.Items.Add(new ListViewItem(Marque.ToRow()));
                }

                ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ListView.Text = @"Marques";
            }

            else if (Node.Name.Equals("Familles"))
            {
                /*
                 * On crée la liste des familles
                 */
                ListView.Columns.Add("Nom", "Nom");

                foreach (var Famille in BacchusModel.Familles)
                {
                    ListView.Items.Add(new ListViewItem(Famille.ToRow()));
                }

                ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ListView.Text = @"Familles";
            }

            else if (Node.Name.Equals("Sous-Familles"))
            {
                /*
                 * On crée la liste des sous familles
                 */
                ListView.Columns.Add("Nom", "Nom");
                ListView.Columns.Add("Famille", "Famille");

                foreach (var SousFamille in BacchusModel.SousFamilles)
                {
                    ListView.Items.Add(new ListViewItem(SousFamille.ToRow()));
                }

                ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ListView.Text = @"Sous-Familles";
            }

            ListView.Sort();
            ListView.Show();
        }

        /// <summary>
        /// Fonction définie pour le double click dans la ListView
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ListView_DoubleClick(object Sender, EventArgs Event)
        {
            if (ListView.SelectedItems.Count == 0) return;

            ModifyAction(ListView.SelectedItems[0]);
        }

        /// <summary>
        /// Fonctino définie pour la mise à jour ou la suppression d'éléments dans la ListView
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ListView_KeyUp(object Sender, KeyEventArgs Event)
        {
            switch (Event.KeyCode)
            {
                case Keys.F5:
                    UpdateListView();
                    break;
                case Keys.Delete:
                    DeleteElement();
                    break;
                case Keys.Enter:
                    ModifyAction(ListView.SelectedItems[0]);
                    break;
            }
        }

        /// <summary>
        /// Fonction permettant de supprimer un objet de la ListView en fonction de son type
        /// </summary>
        /// <exception cref="NullReferenceException">Si l'objet à supprimer n'existe pas</exception>
        private void DeleteElement()
        {
            var Item = ListView.SelectedItems[0];

            if (ListView.Text.Equals("Articles"))
            {
                /*
                 * On est entrain de supprimer un article
                 */
                var Result = MessageBox.Show(@"Êtes-vous sûr de vouloir supprimer l'article " + Item.Text + @" ?",
                    @"Suppression d'un article", MessageBoxButtons.YesNo);

                if (Result != DialogResult.Yes) return;

                // Si l'utilisateur clique sur Yes alors on supprime
                var Article = BacchusModel.GetArticle(Item.Text);
                if (Article == null)
                    throw new NullReferenceException("L'article à supprimer n'existe pas.");
                BacchusModel.Remove(Article);
                Dao.Delete(Article);

                UpdateNbArticles(0); // On update à zéro car le nombre passé en paramètre importe peu
                UpdateListView();
            }

            else if (ListView.Text.Equals("Marques"))
            {
                /*
                 * On est entrain de supprimer une marque
                 */
                var Result = MessageBox.Show(@"Êtes-vous sûr de vouloir supprimer la marque " + Item.Text + @" ?",
                    @"Suppression d'un article", MessageBoxButtons.YesNo);

                if (Result != DialogResult.Yes) return;

                // Si l'utilisateur clique sur Yes alors on supprime
                var Marque = BacchusModel.GetMarque(Item.Text);
                if (Marque == null)
                    throw new NullReferenceException("La marque à supprimer n'existe pas.");

                try
                {
                    BacchusModel.Remove(Marque);
                    Dao.Delete(Marque);
                    UpdateListView();
                }
                catch (ConstraintException Exception)
                {
                    DisplayTemporaryMessage(Exception.Message);
                }
            }

            else if (ListView.Text.Equals("Familles"))
            {
                /*
                 * On est entrain de supprimer une famille
                 */
                var Result = MessageBox.Show(@"Êtes-vous sûr de vouloir supprimer la famille " + Item.Text + @" ?",
                    @"Suppression d'un article", MessageBoxButtons.YesNo);

                if (Result != DialogResult.Yes) return;

                // Si l'utilisateur clique sur Yes alors on supprime
                var Famille = BacchusModel.GetFamille(Item.Text);
                if (Famille == null)
                    throw new NullReferenceException("La famille à supprimer n'existe pas.");

                try
                {
                    BacchusModel.Remove(Famille);
                    Dao.Delete(Famille);
                    UpdateListView();
                }
                catch (ConstraintException Exception)
                {
                    DisplayTemporaryMessage(Exception.Message);
                }
            }
            else if (ListView.Text.Equals("Sous-Familles"))
            {
                /*
                 * On est entrain de supprimer une sous famille
                 */
                var Result = MessageBox.Show(@"Êtes-vous sûr de vouloir supprimer l'article " + Item.Text + @" ?",
                    @"Suppression d'un article", MessageBoxButtons.YesNo);

                if (Result != DialogResult.Yes) return;

                // Si l'utilisateur clique sur Yes alors on supprime
                var SousFamille = BacchusModel.GetSousFamille(Item.Text);
                if (SousFamille == null)
                    throw new NullReferenceException("L'article à supprimer n'existe pas.");
                try
                {
                    BacchusModel.Remove(SousFamille);
                    Dao.Delete(SousFamille);
                    UpdateListView();
                }
                catch (ConstraintException Exception)
                {
                    DisplayTemporaryMessage(Exception.Message);
                }
            }
        }

        /// <summary>
        /// Fonction définie pour le click droit dans la ListView
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ListView_MouseClick(object Sender, MouseEventArgs Event)
        {
            if (Event.Button != MouseButtons.Right) return;

            if (ListView.FocusedItem.Bounds.Contains(Event.Location))
                ContextMenuStripList.Show(Cursor.Position);
        }

        /// <summary>
        /// Fonction affichant un message temporaire de trois secondes dans la status strip
        /// </summary>
        /// <param name="Message"></param>
        private void DisplayTemporaryMessage(string Message)
        {
            var Timer = new Timer {Interval = 5000};
            Timer.Start();
            ToolStripStatusLabel.ForeColor = Color.DarkRed;
            ToolStripStatusLabel.Text = Message;

            Timer.Tick += (Sender, Event) =>
            {
                ToolStripStatusLabel.ForeColor = Color.Black;
                UpdateNbArticles(0);
                Timer.Stop();
            };
        }

        /// <summary>
        /// Lorsque l'on ferme l'application, on enregistre les paramètres pour la taille de la fenêtre
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void FormMain_FormClosing(object Sender, FormClosingEventArgs Event)
        {
            Properties.Settings.Default.Height = Height;
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Maximized = WindowState == FormWindowState.Maximized;
            Properties.Settings.Default.Minimized = WindowState == FormWindowState.Minimized;
            Properties.Settings.Default.Normal = WindowState == FormWindowState.Normal;

            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Fonction définissant l'action lorsque l'utilisateur clique sur "supprimer" dans le menu contextuel
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void SupprimerToolStripMenuItem_Click(object Sender, EventArgs Event)
        {
            DeleteElement();
        }

        /// <summary>
        /// Fonction définissant l'action lorsque l'utilisateur clique sur "modifier" dans le menu contextuel
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ModiferToolStripMenuItem_Click(object Sender, EventArgs Event)
        {
            var Item = ListView.SelectedItems[0];

            ModifyAction(Item);
        }

        /// <summary>
        /// Action de modification
        /// On la dissocie car utilisée à plusieurs endroits
        /// </summary>
        /// <param name="Item">L'item sélectionné</param>
        private void ModifyAction(ListViewItem Item)
        {
            if (ListView.Text.Equals("Articles"))
            {
                var Article = BacchusModel.GetArticle(Item.Text);

                var FormModify = new ModifFormArticle
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this
                };

                FormModify.FillField(Article);
                FormModify.ShowDialog(this);
            }
            else if (ListView.Text.Equals("Marques"))
            {
                var Marque = BacchusModel.GetMarque(Item.Text);

                var ModifyFormMarque = new ModifFormMarque
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this,
                };
                ModifyFormMarque.InitializeMarque(Marque);
                ModifyFormMarque.ShowDialog(this);
            }
            else if (ListView.Text.Equals("Familles"))
            {
                var Famille = BacchusModel.GetFamille(Item.Text);
                var ModifFormFamille = new ModifFormFamille
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this
                };

                ModifFormFamille.FillField(Famille);
                ModifFormFamille.ShowDialog(this);
            }
            else if (ListView.Text.Equals("Sous-Familles"))
            {
                var SousFamille = BacchusModel.GetSousFamille(Item.Text);
                var ModifFormSousFamille = new ModifFormSousFamille
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this
                };

                ModifFormSousFamille.FillField(SousFamille);
                ModifFormSousFamille.ShowDialog(this);
            }
        }

        /// <summary>
        /// Fonction définissant l'action lorsque l'utilisateur clique sur "ajouter" dans le menu contextuel
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void AjouterToolStripMenuItem_Click(object Sender, EventArgs Event)
        {
            if (ListView.Text.Equals("Articles"))
            {
                var AddFormArticle = new AddFormArticle
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this
                };
                AddFormArticle.AddFormArticle_Load();
                AddFormArticle.ShowDialog(this);
            }
            else if (ListView.Text.Equals("Marques"))
            {
                var AddFormMarque = new AddFormMarque
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this,
                };
                AddFormMarque.ShowDialog(this);
            }
            else if (ListView.Text.Equals("Familles"))
            {
                var AddFormFamille = new AddFormFamille
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this
                };
                AddFormFamille.ShowDialog(this);
            }
            else if (ListView.Text.Equals("Sous-Familles"))
            {
                var AddFormSousFamille = new AddFormSousFamille
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this
                };
                AddFormSousFamille.AddFormSousFamille_Load();
                AddFormSousFamille.ShowDialog(this);
            }
        }

        /// <summary>
        /// Action lorsqu'un click est réalisé sur les headers des colonnes
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ListView_ColumnClicked(object Sender, ColumnClickEventArgs Event)
        {
            if (Event.Column == ColumnSorter.SortColumn)
            {
                ColumnSorter.Order = ColumnSorter.Order == SortOrder.Ascending
                    ? SortOrder.Descending
                    : SortOrder.Ascending;
            }
            else
            {
                ColumnSorter.SortColumn = Event.Column;
                ColumnSorter.Order = SortOrder.Ascending;
            }

            ListView.Sort();
        }
    }
}