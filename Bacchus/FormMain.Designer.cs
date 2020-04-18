using System;
using System.Windows.Forms;

namespace Bacchus
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FichierMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateSousMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportSousMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportSousMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.Splitter = new System.Windows.Forms.Splitter();
            this.ListView = new System.Windows.Forms.ListView();
            this.ContextMenuStripList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modiferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.ContextMenuStripList.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FichierMenu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(982, 27);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip";
            // 
            // FichierMenu
            // 
            this.FichierMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.UpdateSousMenu, this.ImportSousMenu, this.ExportSousMenu});
            this.FichierMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FichierMenu.Name = "FichierMenu";
            this.FichierMenu.Size = new System.Drawing.Size(60, 23);
            this.FichierMenu.Text = "Fichier";
            // 
            // UpdateSousMenu
            // 
            this.UpdateSousMenu.Name = "UpdateSousMenu";
            this.UpdateSousMenu.Size = new System.Drawing.Size(137, 24);
            this.UpdateSousMenu.Text = "Actualiser";
            this.UpdateSousMenu.Click += new System.EventHandler(this.UpdateSousMenu_Click);
            // 
            // ImportSousMenu
            // 
            this.ImportSousMenu.Name = "ImportSousMenu";
            this.ImportSousMenu.Size = new System.Drawing.Size(137, 24);
            this.ImportSousMenu.Text = "Importer";
            this.ImportSousMenu.Click += new System.EventHandler(this.ImportSousMenu_Click);
            // 
            // ExportSousMenu
            // 
            this.ExportSousMenu.Name = "ExportSousMenu";
            this.ExportSousMenu.Size = new System.Drawing.Size(137, 24);
            this.ExportSousMenu.Text = "Exporter";
            this.ExportSousMenu.Click += new System.EventHandler(this.ExportSousMenu_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ToolStripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 531);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StatusStrip.Size = new System.Drawing.Size(982, 22);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip";
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // TreeView
            // 
            this.TreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TreeView.Location = new System.Drawing.Point(0, 27);
            this.TreeView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(209, 504);
            this.TreeView.TabIndex = 2;
            this.TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            // 
            // Splitter
            // 
            this.Splitter.Location = new System.Drawing.Point(209, 27);
            this.Splitter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(3, 504);
            this.Splitter.TabIndex = 3;
            this.Splitter.TabStop = false;
            // 
            // ListView
            // 
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ListView.FullRowSelect = true;
            this.ListView.Location = new System.Drawing.Point(212, 27);
            this.ListView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(770, 504);
            this.ListView.TabIndex = 4;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClicked);
            this.ListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListView_KeyUp);
            this.ListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseClick);
            this.ListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_DoubleClick);
            // 
            // ContextMenuStripList
            // 
            this.ContextMenuStripList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStripList.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.ajouterToolStripMenuItem, this.modiferToolStripMenuItem, this.supprimerToolStripMenuItem});
            this.ContextMenuStripList.Name = "contextMenuStrip1";
            this.ContextMenuStripList.Size = new System.Drawing.Size(130, 70);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.AjouterToolStripMenuItem_Click);
            // 
            // modiferToolStripMenuItem
            // 
            this.modiferToolStripMenuItem.Name = "modiferToolStripMenuItem";
            this.modiferToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modiferToolStripMenuItem.Text = "Modifier";
            this.modiferToolStripMenuItem.Click += new System.EventHandler(this.ModiferToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.SupprimerToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.Splitter);
            this.Controls.Add(this.TreeView);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bacchus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ContextMenuStripList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FichierMenu;
        private System.Windows.Forms.ToolStripMenuItem UpdateSousMenu;
        private System.Windows.Forms.ToolStripMenuItem ImportSousMenu;
        private System.Windows.Forms.ToolStripMenuItem ExportSousMenu;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.Splitter Splitter;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripList;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modiferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ListView ListView;
    }
}

