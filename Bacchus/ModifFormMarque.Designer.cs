using System.ComponentModel;

namespace Bacchus
{
    partial class ModifFormMarque
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
            this.ModifyMarqueBox = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxNom = new System.Windows.Forms.TextBox();
            this.LabelNom = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.ModifyMarqueBox.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModifyMarqueBox
            // 
            this.ModifyMarqueBox.Controls.Add(this.TableLayoutPanel);
            this.ModifyMarqueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ModifyMarqueBox.Location = new System.Drawing.Point(12, 11);
            this.ModifyMarqueBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyMarqueBox.Name = "ModifyMarqueBox";
            this.ModifyMarqueBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyMarqueBox.Size = new System.Drawing.Size(523, 112);
            this.ModifyMarqueBox.TabIndex = 1;
            this.ModifyMarqueBox.TabStop = false;
            this.ModifyMarqueBox.Text = "Modification de marque";
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
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.TextBoxNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ButtonCancel.Location = new System.Drawing.Point(326, 128);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(100, 40);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Annuler";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ModifyButton.Location = new System.Drawing.Point(432, 128);
            this.ModifyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(103, 40);
            this.ModifyButton.TabIndex = 4;
            this.ModifyButton.Text = "Modifier";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // ModifFormMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 179);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ModifyMarqueBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModifFormMarque";
            this.Text = "Formulaire de modification de marque";
            this.Load += new System.EventHandler(this.ModifFormMarque_Load);
            this.ModifyMarqueBox.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox ModifyMarqueBox;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.TextBox TextBoxNom;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Label LabelNom;
    }
}