using System.ComponentModel;

namespace Bacchus
{
    partial class AddFormMarque
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
            this.AddMarqueBox = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxNom = new System.Windows.Forms.TextBox();
            this.LabelNom = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.AddMarqueBox.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddMarqueBox
            // 
            this.AddMarqueBox.Controls.Add(this.TableLayoutPanel);
            this.AddMarqueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddMarqueBox.Location = new System.Drawing.Point(14, 14);
            this.AddMarqueBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddMarqueBox.Name = "AddMarqueBox";
            this.AddMarqueBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddMarqueBox.Size = new System.Drawing.Size(523, 113);
            this.AddMarqueBox.TabIndex = 0;
            this.AddMarqueBox.TabStop = false;
            this.AddMarqueBox.Text = "Ajout de marque";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.TextBoxNom, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelNom, 0, 0);
            this.TableLayoutPanel.Location = new System.Drawing.Point(6, 32);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.65445F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(511, 66);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBoxNom.Location = new System.Drawing.Point(258, 20);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(250, 26);
            this.TextBoxNom.TabIndex = 1;
            // 
            // LabelNom
            // 
            this.LabelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelNom.Location = new System.Drawing.Point(3, 0);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(249, 66);
            this.LabelNom.TabIndex = 0;
            this.LabelNom.Text = "Nom de la marque :";
            this.LabelNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(434, 132);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(103, 34);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Ajouter";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(328, 132);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(100, 34);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Annuler";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // AddFormMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 176);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddMarqueBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "AddFormMarque";
            this.Text = "Formulaire d\'ajout de marque";
            this.Load += new System.EventHandler(this.AddFormMarque_Load);
            this.AddMarqueBox.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.TextBox TextBoxNom;
        private System.Windows.Forms.GroupBox AddMarqueBox;
    }
}