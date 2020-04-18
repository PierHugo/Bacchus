namespace Bacchus
{
    partial class ImportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.groupResults = new System.Windows.Forms.GroupBox();
            this.nbAnomaliesFound = new System.Windows.Forms.TextBox();
            this.LabelAnomalies = new System.Windows.Forms.Label();
            this.nbArticleAdded = new System.Windows.Forms.TextBox();
            this.LabelArticles = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Label();
            this.GroupSelect = new System.Windows.Forms.GroupBox();
            this.FileLabel = new System.Windows.Forms.Label();
            this.SelectCsv = new System.Windows.Forms.Label();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.GroupMode = new System.Windows.Forms.GroupBox();
            this.Mode = new System.Windows.Forms.Label();
            this.ImportButtonAdd = new System.Windows.Forms.Button();
            this.ImportButtonRemove = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.MainPanel.SuspendLayout();
            this.groupResults.SuspendLayout();
            this.GroupSelect.SuspendLayout();
            this.GroupMode.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.groupResults);
            this.MainPanel.Controls.Add(this.GroupSelect);
            this.MainPanel.Controls.Add(this.GroupMode);
            this.MainPanel.Controls.Add(this.StatusStrip);
            this.MainPanel.Location = new System.Drawing.Point(10, 12);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(555, 383);
            this.MainPanel.TabIndex = 0;
            // 
            // groupResults
            // 
            this.groupResults.Controls.Add(this.nbAnomaliesFound);
            this.groupResults.Controls.Add(this.LabelAnomalies);
            this.groupResults.Controls.Add(this.nbArticleAdded);
            this.groupResults.Controls.Add(this.LabelArticles);
            this.groupResults.Controls.Add(this.Results);
            this.groupResults.Location = new System.Drawing.Point(19, 217);
            this.groupResults.Margin = new System.Windows.Forms.Padding(2);
            this.groupResults.Name = "groupResults";
            this.groupResults.Padding = new System.Windows.Forms.Padding(2);
            this.groupResults.Size = new System.Drawing.Size(523, 125);
            this.groupResults.TabIndex = 9;
            this.groupResults.TabStop = false;
            // 
            // nbAnomaliesFound
            // 
            this.nbAnomaliesFound.Enabled = false;
            this.nbAnomaliesFound.Location = new System.Drawing.Point(206, 92);
            this.nbAnomaliesFound.Margin = new System.Windows.Forms.Padding(2);
            this.nbAnomaliesFound.Name = "nbAnomaliesFound";
            this.nbAnomaliesFound.ReadOnly = true;
            this.nbAnomaliesFound.Size = new System.Drawing.Size(76, 23);
            this.nbAnomaliesFound.TabIndex = 4;
            // 
            // LabelAnomalies
            // 
            this.LabelAnomalies.AutoSize = true;
            this.LabelAnomalies.Location = new System.Drawing.Point(6, 93);
            this.LabelAnomalies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAnomalies.Name = "LabelAnomalies";
            this.LabelAnomalies.Size = new System.Drawing.Size(179, 15);
            this.LabelAnomalies.TabIndex = 3;
            this.LabelAnomalies.Text = "Nombre d\'annomalies trouvées :";
            // 
            // nbArticleAdded
            // 
            this.nbArticleAdded.Enabled = false;
            this.nbArticleAdded.Location = new System.Drawing.Point(174, 58);
            this.nbArticleAdded.Margin = new System.Windows.Forms.Padding(2);
            this.nbArticleAdded.Name = "nbArticleAdded";
            this.nbArticleAdded.ReadOnly = true;
            this.nbArticleAdded.Size = new System.Drawing.Size(76, 23);
            this.nbArticleAdded.TabIndex = 2;
            // 
            // LabelArticles
            // 
            this.LabelArticles.AutoSize = true;
            this.LabelArticles.Location = new System.Drawing.Point(6, 60);
            this.LabelArticles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelArticles.Name = "LabelArticles";
            this.LabelArticles.Size = new System.Drawing.Size(148, 15);
            this.LabelArticles.TabIndex = 1;
            this.LabelArticles.Text = "Nombre d\'articles ajoutés :";
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Dock = System.Windows.Forms.DockStyle.Left;
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Results.Location = new System.Drawing.Point(2, 18);
            this.Results.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(70, 18);
            this.Results.TabIndex = 0;
            this.Results.Text = "Résultats";
            this.Results.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GroupSelect
            // 
            this.GroupSelect.Controls.Add(this.FileLabel);
            this.GroupSelect.Controls.Add(this.SelectCsv);
            this.GroupSelect.Controls.Add(this.FileBox);
            this.GroupSelect.Controls.Add(this.AddFileButton);
            this.GroupSelect.Location = new System.Drawing.Point(19, 2);
            this.GroupSelect.Margin = new System.Windows.Forms.Padding(2);
            this.GroupSelect.Name = "GroupSelect";
            this.GroupSelect.Padding = new System.Windows.Forms.Padding(2);
            this.GroupSelect.Size = new System.Drawing.Size(523, 98);
            this.GroupSelect.TabIndex = 7;
            this.GroupSelect.TabStop = false;
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(5, 72);
            this.FileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(106, 15);
            this.FileLabel.TabIndex = 0;
            this.FileLabel.Text = "Fichier à importer :";
            // 
            // SelectCsv
            // 
            this.SelectCsv.AutoSize = true;
            this.SelectCsv.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.SelectCsv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SelectCsv.Location = new System.Drawing.Point(2, 18);
            this.SelectCsv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectCsv.Name = "SelectCsv";
            this.SelectCsv.Size = new System.Drawing.Size(166, 18);
            this.SelectCsv.TabIndex = 0;
            this.SelectCsv.Text = "Sélection du fichier CSV";
            this.SelectCsv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FileBox
            // 
            this.FileBox.Enabled = false;
            this.FileBox.Location = new System.Drawing.Point(127, 69);
            this.FileBox.Margin = new System.Windows.Forms.Padding(2);
            this.FileBox.Name = "FileBox";
            this.FileBox.ReadOnly = true;
            this.FileBox.Size = new System.Drawing.Size(333, 23);
            this.FileBox.TabIndex = 1;
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(464, 67);
            this.AddFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(52, 28);
            this.AddFileButton.TabIndex = 2;
            this.AddFileButton.Text = "...";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // GroupMode
            // 
            this.GroupMode.Controls.Add(this.Mode);
            this.GroupMode.Controls.Add(this.ImportButtonAdd);
            this.GroupMode.Controls.Add(this.ImportButtonRemove);
            this.GroupMode.Location = new System.Drawing.Point(19, 107);
            this.GroupMode.Margin = new System.Windows.Forms.Padding(2);
            this.GroupMode.Name = "GroupMode";
            this.GroupMode.Padding = new System.Windows.Forms.Padding(2);
            this.GroupMode.Size = new System.Drawing.Size(523, 104);
            this.GroupMode.TabIndex = 8;
            this.GroupMode.TabStop = false;
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.Dock = System.Windows.Forms.DockStyle.Left;
            this.Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Mode.Location = new System.Drawing.Point(2, 18);
            this.Mode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(129, 18);
            this.Mode.TabIndex = 0;
            this.Mode.Text = "Mode d\'intégration";
            this.Mode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ImportButtonAdd
            // 
            this.ImportButtonAdd.Location = new System.Drawing.Point(6, 57);
            this.ImportButtonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.ImportButtonAdd.Name = "ImportButtonAdd";
            this.ImportButtonAdd.Size = new System.Drawing.Size(163, 36);
            this.ImportButtonAdd.TabIndex = 4;
            this.ImportButtonAdd.Text = "Importer le fichier (ajout)";
            this.ImportButtonAdd.UseVisualStyleBackColor = true;
            this.ImportButtonAdd.Click += new System.EventHandler(this.ImportButtonAdd_Click);
            // 
            // ImportButtonRemove
            // 
            this.ImportButtonRemove.Location = new System.Drawing.Point(174, 57);
            this.ImportButtonRemove.Margin = new System.Windows.Forms.Padding(2);
            this.ImportButtonRemove.Name = "ImportButtonRemove";
            this.ImportButtonRemove.Size = new System.Drawing.Size(224, 36);
            this.ImportButtonRemove.TabIndex = 3;
            this.ImportButtonRemove.Text = "Importer le fichier (écrasement)";
            this.ImportButtonRemove.UseVisualStyleBackColor = true;
            this.ImportButtonRemove.Click += new System.EventHandler(this.ImportButtonRemoving_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripStatusLabelProgress, this.ToolStripProgressBar});
            this.StatusStrip.Location = new System.Drawing.Point(0, 359);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.StatusStrip.Size = new System.Drawing.Size(555, 24);
            this.StatusStrip.TabIndex = 5;
            this.StatusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelProgress
            // 
            this.toolStripStatusLabelProgress.Name = "toolStripStatusLabelProgress";
            this.toolStripStatusLabelProgress.Size = new System.Drawing.Size(75, 19);
            this.toolStripStatusLabelProgress.Text = "Progression :";
            // 
            // ToolStripProgressBar
            // 
            this.ToolStripProgressBar.Name = "ToolStripProgressBar";
            this.ToolStripProgressBar.Size = new System.Drawing.Size(437, 18);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 405);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ImportForm";
            this.Text = "Importer des données";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.groupResults.ResumeLayout(false);
            this.groupResults.PerformLayout();
            this.GroupSelect.ResumeLayout(false);
            this.GroupSelect.PerformLayout();
            this.GroupMode.ResumeLayout(false);
            this.GroupMode.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.TextBox FileBox;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Button ImportButtonRemove;
        private System.Windows.Forms.Button ImportButtonAdd;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar;
        private System.Windows.Forms.GroupBox GroupSelect;
        private System.Windows.Forms.Label SelectCsv;
        private System.Windows.Forms.GroupBox groupResults;
        private System.Windows.Forms.TextBox nbAnomaliesFound;
        private System.Windows.Forms.Label LabelAnomalies;
        private System.Windows.Forms.TextBox nbArticleAdded;
        private System.Windows.Forms.Label LabelArticles;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.GroupBox GroupMode;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProgress;
    }
}