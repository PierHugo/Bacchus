using System.ComponentModel;

namespace Bacchus
{
    partial class AddFormSousFamille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.GroupBoxAdd = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanelAdd = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxFamille = new System.Windows.Forms.ComboBox();
            this.LabelFamille = new System.Windows.Forms.Label();
            this.LabelNom = new System.Windows.Forms.Label();
            this.TextBoxNom = new System.Windows.Forms.TextBox();
            this.GroupBoxAdd.SuspendLayout();
            this.TableLayoutPanelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ButtonCancel.Location = new System.Drawing.Point(321, 136);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(89, 29);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "Annuler";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ButtonAdd.Location = new System.Drawing.Point(415, 136);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(85, 29);
            this.ButtonAdd.TabIndex = 6;
            this.ButtonAdd.Text = "Ajouter";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // GroupBoxAdd
            // 
            this.GroupBoxAdd.Controls.Add(this.TableLayoutPanelAdd);
            this.GroupBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.GroupBoxAdd.Location = new System.Drawing.Point(10, 12);
            this.GroupBoxAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBoxAdd.Name = "GroupBoxAdd";
            this.GroupBoxAdd.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBoxAdd.Size = new System.Drawing.Size(489, 119);
            this.GroupBoxAdd.TabIndex = 5;
            this.GroupBoxAdd.TabStop = false;
            this.GroupBoxAdd.Text = "Ajouter une sous-famille";
            // 
            // TableLayoutPanelAdd
            // 
            this.TableLayoutPanelAdd.AutoSize = true;
            this.TableLayoutPanelAdd.ColumnCount = 2;
            this.TableLayoutPanelAdd.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.41316F));
            this.TableLayoutPanelAdd.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.58684F));
            this.TableLayoutPanelAdd.Controls.Add(this.ComboBoxFamille, 1, 1);
            this.TableLayoutPanelAdd.Controls.Add(this.LabelFamille, 0, 1);
            this.TableLayoutPanelAdd.Controls.Add(this.LabelNom, 0, 0);
            this.TableLayoutPanelAdd.Controls.Add(this.TextBoxNom, 1, 0);
            this.TableLayoutPanelAdd.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TableLayoutPanelAdd.Location = new System.Drawing.Point(5, 31);
            this.TableLayoutPanelAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TableLayoutPanelAdd.Name = "TableLayoutPanelAdd";
            this.TableLayoutPanelAdd.RowCount = 2;
            this.TableLayoutPanelAdd.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.77011F));
            this.TableLayoutPanelAdd.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.22989F));
            this.TableLayoutPanelAdd.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanelAdd.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanelAdd.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanelAdd.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanelAdd.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanelAdd.Size = new System.Drawing.Size(478, 87);
            this.TableLayoutPanelAdd.TabIndex = 0;
            // 
            // ComboBoxFamille
            // 
            this.ComboBoxFamille.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ComboBoxFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ComboBoxFamille.FormattingEnabled = true;
            this.ComboBoxFamille.Location = new System.Drawing.Point(204, 57);
            this.ComboBoxFamille.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ComboBoxFamille.Name = "ComboBoxFamille";
            this.ComboBoxFamille.Size = new System.Drawing.Size(261, 24);
            this.ComboBoxFamille.TabIndex = 4;
            // 
            // LabelFamille
            // 
            this.LabelFamille.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelFamille.AutoSize = true;
            this.LabelFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelFamille.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelFamille.Location = new System.Drawing.Point(140, 60);
            this.LabelFamille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFamille.Name = "LabelFamille";
            this.LabelFamille.Size = new System.Drawing.Size(60, 17);
            this.LabelFamille.TabIndex = 3;
            this.LabelFamille.Text = "Famille :";
            // 
            // LabelNom
            // 
            this.LabelNom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelNom.AutoSize = true;
            this.LabelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelNom.Location = new System.Drawing.Point(155, 17);
            this.LabelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(45, 17);
            this.LabelNom.TabIndex = 0;
            this.LabelNom.Text = "Nom :";
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBoxNom.Location = new System.Drawing.Point(204, 14);
            this.TextBoxNom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(261, 23);
            this.TextBoxNom.TabIndex = 1;
            // 
            // AddFormSousFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 179);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.GroupBoxAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddFormSousFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une sous-famille";
            this.GroupBoxAdd.ResumeLayout(false);
            this.GroupBoxAdd.PerformLayout();
            this.TableLayoutPanelAdd.ResumeLayout(false);
            this.TableLayoutPanelAdd.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.GroupBox GroupBoxAdd;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAdd;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.TextBox TextBoxNom;
        private System.Windows.Forms.Label LabelFamille;
        private System.Windows.Forms.ComboBox ComboBoxFamille;
    }
}