using System;
using System.Windows.Forms;
using Bacchus.model;

namespace Bacchus
{
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction chargée lorsque la vue s'ouvre
        /// On définit ici les évenements dont on aura besoin pour l'exportation
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ExportForm_Load(object Sender, EventArgs Event)
        {
            Utils.HasToUpdate += UpdateProgress;
            Utils.SetMaxValue += SetMaxValue;
            Utils.SetNbArticlesExported += SetNbArticleExported;
        }

        /// <summary>
        /// Fonction définissant le nombre d'articles exportés
        /// </summary>
        /// <param name="NbArticles"></param>
        private void SetNbArticleExported(int NbArticles)
        {
            TextBoxExported.Text = NbArticles.ToString();
        }

        /// <summary>
        /// Fonction définissant le maximum de la barre de chargement
        /// </summary>
        /// <param name="MaxValue"></param>
        private void SetMaxValue(int MaxValue)
        {
            ToolStripProgressBar.Maximum = MaxValue;
        }

        /// <summary>
        /// Fonction définissant le pourcentage actuel de la barre de chargement
        /// </summary>
        /// <param name="Progress"></param>
        private void UpdateProgress(int Progress)
        {
            ToolStripProgressBar.Value = Progress;
        }

        /// <summary>
        /// Fonction définissant l'action lorsque l'on clique sur le bouton "..." pour ouvrir un file chooser
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void AddFileButton_Click(object Sender, EventArgs Event)
        {
            var SaveFileDialog = new SaveFileDialog {Filter = @"CSV files (*.csv)|*.csv"};

            if (SaveFileDialog.ShowDialog(this) != DialogResult.OK) return;
            var FilePath = SaveFileDialog.FileName;
            FileBox.Text = FilePath;
        }

        /// <summary>
        /// Fonction définissant l'action lorsque l'utilisateur clique sur le bouton "exporter les données"
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ExportButton_Click(object Sender, EventArgs Event)
        {
            ToolStripProgressBar.Value = 0;

            if (FileBox.Text == "")
            {
                MessageBox.Show(@"Vous n'avez pas sélectionné de fichier", @"Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Utils.ExportCsv(FileBox.Text, ((FormMain) Owner).BacchusModel);

            var Result = MessageBox.Show(@"Données Exportées", @"Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            if (Result == DialogResult.OK)
            {
                Close();
            }
        }
    }
}