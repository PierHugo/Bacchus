using System;
using System.Windows.Forms;
using Bacchus.model;

namespace Bacchus
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void ImportForm_Load(object Sender, EventArgs Event)
        {
            Utils.HasToUpdate += UpdateProgress;
            Utils.SetMaxValue += SetMaxValue;
            Utils.SetNbArticlesAdded += SetNbArticlesAdded;
        }

        private void SetNbArticlesAdded(int NbArticles)
        {
            nbArticleAdded.Text = NbArticles.ToString();
        }

        /// <summary>
        /// Action lors du click sur le bouton d'ajout d'un fichier
        /// Cela permet de choisir un fichier dans un FileDialog afin de l'importer par la suite dans la DB
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void AddFileButton_Click(object Sender, EventArgs Event)
        {
            var OpenFileDialog = new OpenFileDialog {Filter = @"CSV files (*.csv)|*.csv"};

            if (OpenFileDialog.ShowDialog(this) != DialogResult.OK) return;
            var FilePath = OpenFileDialog.FileName;
            FileBox.Text = FilePath;
        }

        /// <summary>
        /// Action lors du click sur le bouton d'importation en écrasement
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ImportButtonRemoving_Click(object Sender, EventArgs Event)
        {
            ToolStripProgressBar.Value = 0;

            if (FileBox.Text == "")
            {
                MessageBox.Show(@"Vous n'avez pas sélectionné de fichier", @"Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Utils.LoadCsv(FileBox.Text, true, ((FormMain) Owner).BacchusModel);
            //((FormMain) Owner).UpdateTreeView();

            var Result = MessageBox.Show(@"Données importées", @"Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (Result != DialogResult.OK) return;

            ((FormMain) Owner).UpdateListView();
            Close();
        }

        /// <summary>
        /// Action lors du click sur le bouton d'importation en ajout
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void ImportButtonAdd_Click(object Sender, EventArgs Event)
        {
            ToolStripProgressBar.Value = 0;

            if (FileBox.Text == "")
            {
                MessageBox.Show(@"Vous n'avez pas sélectionné de fichier", @"Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Utils.LoadCsv(FileBox.Text, false, ((FormMain) Owner).BacchusModel);
            //((FormMain) Owner).UpdateTreeView();

            var Result = MessageBox.Show(@"Données importées", @"Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (Result != DialogResult.OK) return;

            ((FormMain) Owner).UpdateListView();
            Close();
        }

        /// <summary>
        /// Fonction mettant à jour la progression d'une importation
        /// </summary>
        /// <param name="Progress">La progression courante de l'importation</param>
        private void UpdateProgress(int Progress)
        {
            ToolStripProgressBar.Value = Progress;
        }

        /// <summary>
        /// Fonction définissant la valeur maximal de la barre de chargement
        /// </summary>
        /// <param name="MaxValue">La taille maximale de la barre</param>
        private void SetMaxValue(int MaxValue)
        {
            ToolStripProgressBar.Maximum = MaxValue;
        }
    }
}