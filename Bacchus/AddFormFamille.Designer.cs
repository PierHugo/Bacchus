using System.ComponentModel;

namespace Bacchus
{
    partial class AddFormFamille
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
            this.GroupBoxAdd = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanelAdd = new System.Windows.Forms.TableLayoutPanel();
            this.LabelNom = new System.Windows.Forms.Label();
            this.TextBoxNom = new System.Windows.Forms.TextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.GroupBoxAdd.SuspendLayout();
            this.TableLayoutPanelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxAdd
            // 
            this.GroupBoxAdd.Controls.Add(this.TableLayoutPanelAdd);
            this.GroupBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.GroupBoxAdd.Location = new System.Drawing.Point(27, 16);
            this.GroupBoxAdd.Name = "GroupBoxAdd";
            this.GroupBoxAdd.Size = new System.Drawing.Size(394, 97);
            this.GroupBoxAdd.TabIndex = 1;
            this.GroupBoxAdd.TabStop = false;
            this.GroupBoxAdd.Text = "Ajouter une famille";
            // 
            // TableLayoutPanelAdd
            // 
            this.TableLayoutPanelAdd.AutoSize = true;
            this.TableLayoutPanelAdd.ColumnCount = 2;
            this.TableLayoutPanelAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelAdd.Controls.Add(this.LabelNom, 0, 0);
            this.TableLayoutPanelAdd.Controls.Add(this.TextBoxNom, 1, 0);
            this.TableLayoutPanelAdd.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TableLayoutPanelAdd.Location = new System.Drawing.Point(6, 33);
            this.TableLayoutPanelAdd.Name = "TableLayoutPanelAdd";
            this.TableLayoutPanelAdd.RowCount = 1;
            this.TableLayoutPanelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.57576F));
            this.TableLayoutPanelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.42424F));
            this.TableLayoutPanelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.TableLayoutPanelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.TableLayoutPanelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.TableLayoutPanelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.TableLayoutPanelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.TableLayoutPanelAdd.Size = new System.Drawing.Size(380, 51);
            this.TableLayoutPanelAdd.TabIndex = 0;
            // 
            // LabelNom
            // 
            this.LabelNom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelNom.AutoSize = true;
            this.LabelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelNom.Location = new System.Drawing.Point(133, 15);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(54, 20);
            this.LabelNom.TabIndex = 0;
            this.LabelNom.Text = "Nom :";
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBoxNom.Location = new System.Drawing.Point(193, 12);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(174, 26);
            this.TextBoxNom.TabIndex = 1;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ButtonCancel.Location = new System.Drawing.Point(217, 119);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(101, 31);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Annuler";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ButtonAdd.Location = new System.Drawing.Point(324, 119);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(97, 31);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Ajouter";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // AddFormFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 163);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.GroupBoxAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddFormFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une famille";
            this.GroupBoxAdd.ResumeLayout(false);
            this.GroupBoxAdd.PerformLayout();
            this.TableLayoutPanelAdd.ResumeLayout(false);
            this.TableLayoutPanelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxAdd;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAdd;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.TextBox TextBoxNom;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAdd;
    }
}