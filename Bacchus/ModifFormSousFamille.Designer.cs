using System.ComponentModel;

namespace Bacchus
{
    partial class ModifFormSousFamille
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
            this.ButtonModif = new System.Windows.Forms.Button();
            this.GroupBoxAdd = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanelAdd = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxFamille = new System.Windows.Forms.ComboBox();
            this.LabelFamille = new System.Windows.Forms.Label();
            this.LabelNom = new System.Windows.Forms.Label();
            this.TextBoxNom = new System.Windows.Forms.TextBox();
            this.LabelRefSousFamille = new System.Windows.Forms.Label();
            this.GroupBoxAdd.SuspendLayout();
            this.TableLayoutPanelAdd.SuspendLayout();
            this.SuspendLayout();
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ButtonCancel.Location = new System.Drawing.Point(380, 179);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(101, 39);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Annuler";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            this.ButtonModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ButtonModif.Location = new System.Drawing.Point(487, 179);
            this.ButtonModif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonModif.Name = "ButtonModif";
            this.ButtonModif.Size = new System.Drawing.Size(97, 39);
            this.ButtonModif.TabIndex = 9;
            this.ButtonModif.Text = "Modifier";
            this.ButtonModif.UseVisualStyleBackColor = true;
            this.ButtonModif.Click += new System.EventHandler(this.ButtonModif_Click);
            this.GroupBoxAdd.Controls.Add(this.TableLayoutPanelAdd);
            this.GroupBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.GroupBoxAdd.Location = new System.Drawing.Point(12, 15);
            this.GroupBoxAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxAdd.Name = "GroupBoxAdd";
            this.GroupBoxAdd.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxAdd.Size = new System.Drawing.Size(572, 159);
            this.GroupBoxAdd.TabIndex = 8;
            this.GroupBoxAdd.TabStop = false;
            this.GroupBoxAdd.Text = "Modifier une sous-famille";
            this.TableLayoutPanelAdd.AutoSize = true;
            this.TableLayoutPanelAdd.ColumnCount = 2;
            this.TableLayoutPanelAdd.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.97496F));
            this.TableLayoutPanelAdd.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.02504F));
            this.TableLayoutPanelAdd.Controls.Add(this.ComboBoxFamille, 1, 1);
            this.TableLayoutPanelAdd.Controls.Add(this.LabelFamille, 0, 1);
            this.TableLayoutPanelAdd.Controls.Add(this.LabelNom, 0, 0);
            this.TableLayoutPanelAdd.Controls.Add(this.TextBoxNom, 1, 0);
            this.TableLayoutPanelAdd.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TableLayoutPanelAdd.Location = new System.Drawing.Point(6, 41);
            this.TableLayoutPanelAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableLayoutPanelAdd.Name = "TableLayoutPanelAdd";
            this.TableLayoutPanelAdd.RowCount = 2;
            this.TableLayoutPanelAdd.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.77011F));
            this.TableLayoutPanelAdd.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.22989F));
            this.TableLayoutPanelAdd.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.TableLayoutPanelAdd.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.TableLayoutPanelAdd.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.TableLayoutPanelAdd.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.TableLayoutPanelAdd.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.TableLayoutPanelAdd.Size = new System.Drawing.Size(559, 106);
            this.TableLayoutPanelAdd.TabIndex = 0;
            this.ComboBoxFamille.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ComboBoxFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ComboBoxFamille.FormattingEnabled = true;
            this.ComboBoxFamille.Location = new System.Drawing.Point(260, 70);
            this.ComboBoxFamille.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxFamille.Name = "ComboBoxFamille";
            this.ComboBoxFamille.Size = new System.Drawing.Size(259, 28);
            this.ComboBoxFamille.TabIndex = 4;
            this.LabelFamille.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelFamille.AutoSize = true;
            this.LabelFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelFamille.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelFamille.Location = new System.Drawing.Point(181, 74);
            this.LabelFamille.Name = "LabelFamille";
            this.LabelFamille.Size = new System.Drawing.Size(73, 20);
            this.LabelFamille.TabIndex = 3;
            this.LabelFamille.Text = "Famille :";
            this.LabelNom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelNom.AutoSize = true;
            this.LabelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelNom.Location = new System.Drawing.Point(200, 21);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(54, 20);
            this.LabelNom.TabIndex = 0;
            this.LabelNom.Text = "Nom :";
            this.TextBoxNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBoxNom.Location = new System.Drawing.Point(260, 18);
            this.TextBoxNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(259, 26);
            this.TextBoxNom.TabIndex = 1;
            this.LabelRefSousFamille.AutoSize = true;
            this.LabelRefSousFamille.Location = new System.Drawing.Point(18, 198);
            this.LabelRefSousFamille.Name = "LabelRefSousFamille";
            this.LabelRefSousFamille.Size = new System.Drawing.Size(0, 20);
            this.LabelRefSousFamille.TabIndex = 11;
            this.LabelRefSousFamille.Visible = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 238);
            this.Controls.Add(this.LabelRefSousFamille);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonModif);
            this.Controls.Add(this.GroupBoxAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModifFormSousFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifier une sous-famille";
            this.GroupBoxAdd.ResumeLayout(false);
            this.GroupBoxAdd.PerformLayout();
            this.TableLayoutPanelAdd.ResumeLayout(false);
            this.TableLayoutPanelAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonModif;
        private System.Windows.Forms.GroupBox GroupBoxAdd;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAdd;
        private System.Windows.Forms.ComboBox ComboBoxFamille;
        private System.Windows.Forms.Label LabelFamille;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.TextBox TextBoxNom;
        private System.Windows.Forms.Label LabelRefSousFamille;
    }
}