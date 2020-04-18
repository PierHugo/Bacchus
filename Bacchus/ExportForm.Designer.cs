namespace Bacchus
{
    partial class ExportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer Components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="Disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool Disposing)
        {
            if (Disposing && (Components != null))
            {
                Components.Dispose();
            }
            base.Dispose(Disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.GroupBoxResult = new System.Windows.Forms.GroupBox();
            this.TextBoxAnomalies = new System.Windows.Forms.TextBox();
            this.LabelAnomalies = new System.Windows.Forms.Label();
            this.TextBoxExported = new System.Windows.Forms.TextBox();
            this.LabelExported = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.GroupBoxFile = new System.Windows.Forms.GroupBox();
            this.FileLabel = new System.Windows.Forms.Label();
            this.LabelCsv = new System.Windows.Forms.Label();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.GroupBoxMode = new System.Windows.Forms.GroupBox();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.MainPanel.SuspendLayout();
            this.GroupBoxResult.SuspendLayout();
            this.GroupBoxFile.SuspendLayout();
            this.GroupBoxMode.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.GroupBoxResult);
            this.MainPanel.Controls.Add(this.GroupBoxFile);
            this.MainPanel.Controls.Add(this.GroupBoxMode);
            this.MainPanel.Controls.Add(this.StatusStrip);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(633, 413);
            this.MainPanel.TabIndex = 1;
            // 
            // GroupBoxResult
            // 
            this.GroupBoxResult.Controls.Add(this.TextBoxAnomalies);
            this.GroupBoxResult.Controls.Add(this.LabelAnomalies);
            this.GroupBoxResult.Controls.Add(this.TextBoxExported);
            this.GroupBoxResult.Controls.Add(this.LabelExported);
            this.GroupBoxResult.Controls.Add(this.ResultLabel);
            this.GroupBoxResult.Location = new System.Drawing.Point(21, 231);
            this.GroupBoxResult.Name = "GroupBoxResult";
            this.GroupBoxResult.Size = new System.Drawing.Size(597, 133);
            this.GroupBoxResult.TabIndex = 9;
            this.GroupBoxResult.TabStop = false;
            // 
            // TextBoxAnomalies
            // 
            this.TextBoxAnomalies.Location = new System.Drawing.Point(225, 100);
            this.TextBoxAnomalies.Name = "TextBoxAnomalies";
            this.TextBoxAnomalies.ReadOnly = true;
            this.TextBoxAnomalies.Size = new System.Drawing.Size(86, 22);
            this.TextBoxAnomalies.TabIndex = 4;
            // 
            // LabelAnomalies
            // 
            this.LabelAnomalies.AutoSize = true;
            this.LabelAnomalies.Location = new System.Drawing.Point(7, 100);
            this.LabelAnomalies.Name = "LabelAnomalies";
            this.LabelAnomalies.Size = new System.Drawing.Size(212, 17);
            this.LabelAnomalies.TabIndex = 3;
            this.LabelAnomalies.Text = "Nombre d\'annomalies trouvées :";
            // 
            // TextBoxExported
            // 
            this.TextBoxExported.Location = new System.Drawing.Point(201, 64);
            this.TextBoxExported.Name = "TextBoxExported";
            this.TextBoxExported.ReadOnly = true;
            this.TextBoxExported.Size = new System.Drawing.Size(86, 22);
            this.TextBoxExported.TabIndex = 2;
            // 
            // LabelExported
            // 
            this.LabelExported.AutoSize = true;
            this.LabelExported.Location = new System.Drawing.Point(7, 64);
            this.LabelExported.Name = "LabelExported";
            this.LabelExported.Size = new System.Drawing.Size(188, 17);
            this.LabelExported.TabIndex = 1;
            this.LabelExported.Text = "Nombre d\'articles exportés : ";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(3, 18);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(85, 24);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "Résultats";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GroupBoxFile
            // 
            this.GroupBoxFile.Controls.Add(this.FileLabel);
            this.GroupBoxFile.Controls.Add(this.LabelCsv);
            this.GroupBoxFile.Controls.Add(this.FileBox);
            this.GroupBoxFile.Controls.Add(this.AddFileButton);
            this.GroupBoxFile.Location = new System.Drawing.Point(21, 3);
            this.GroupBoxFile.Name = "GroupBoxFile";
            this.GroupBoxFile.Size = new System.Drawing.Size(597, 105);
            this.GroupBoxFile.TabIndex = 7;
            this.GroupBoxFile.TabStop = false;
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(7, 74);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(126, 17);
            this.FileLabel.TabIndex = 0;
            this.FileLabel.Text = "Fichier à exporter :";
            // 
            // LabelCsv
            // 
            this.LabelCsv.AutoSize = true;
            this.LabelCsv.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCsv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelCsv.Location = new System.Drawing.Point(3, 18);
            this.LabelCsv.Name = "LabelCsv";
            this.LabelCsv.Size = new System.Drawing.Size(213, 24);
            this.LabelCsv.TabIndex = 0;
            this.LabelCsv.Text = "Sélection du fichier CSV";
            this.LabelCsv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FileBox
            // 
            this.FileBox.Enabled = false;
            this.FileBox.Location = new System.Drawing.Point(139, 74);
            this.FileBox.Name = "FileBox";
            this.FileBox.ReadOnly = true;
            this.FileBox.Size = new System.Drawing.Size(367, 22);
            this.FileBox.TabIndex = 1;
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(512, 71);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(79, 28);
            this.AddFileButton.TabIndex = 2;
            this.AddFileButton.Text = "...";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // GroupBoxMode
            // 
            this.GroupBoxMode.Controls.Add(this.ModeLabel);
            this.GroupBoxMode.Controls.Add(this.ExportButton);
            this.GroupBoxMode.Location = new System.Drawing.Point(21, 114);
            this.GroupBoxMode.Name = "GroupBoxMode";
            this.GroupBoxMode.Size = new System.Drawing.Size(597, 111);
            this.GroupBoxMode.TabIndex = 8;
            this.GroupBoxMode.TabStop = false;
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeLabel.Location = new System.Drawing.Point(3, 18);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(172, 24);
            this.ModeLabel.TabIndex = 0;
            this.ModeLabel.Text = "Mode d\'exportation";
            this.ModeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(7, 60);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(171, 38);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "Exporter les données";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelProgress,
            this.ToolStripProgressBar});
            this.StatusStrip.Location = new System.Drawing.Point(0, 387);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(633, 26);
            this.StatusStrip.TabIndex = 5;
            this.StatusStrip.Text = "statusStrip";
            // 
            // ToolStripStatusLabelProgress
            // 
            this.ToolStripStatusLabelProgress.Name = "ToolStripStatusLabelProgress";
            this.ToolStripStatusLabelProgress.Size = new System.Drawing.Size(93, 21);
            this.ToolStripStatusLabelProgress.Text = "Progression :";
            // 
            // ToolStripProgressBar
            // 
            this.ToolStripProgressBar.Name = "ToolStripProgressBar";
            this.ToolStripProgressBar.Size = new System.Drawing.Size(500, 20);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 437);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExportForm";
            this.Text = "Exporter des données";
            this.Load += new System.EventHandler(this.ExportForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.GroupBoxResult.ResumeLayout(false);
            this.GroupBoxResult.PerformLayout();
            this.GroupBoxFile.ResumeLayout(false);
            this.GroupBoxFile.PerformLayout();
            this.GroupBoxMode.ResumeLayout(false);
            this.GroupBoxMode.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.GroupBox GroupBoxResult;
        private System.Windows.Forms.TextBox TextBoxAnomalies;
        private System.Windows.Forms.Label LabelAnomalies;
        private System.Windows.Forms.TextBox TextBoxExported;
        private System.Windows.Forms.Label LabelExported;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.GroupBox GroupBoxFile;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Label LabelCsv;
        private System.Windows.Forms.TextBox FileBox;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.GroupBox GroupBoxMode;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelProgress;
        private System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar;
    }
}