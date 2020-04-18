using System.ComponentModel;

namespace Bacchus
{
    partial class ModifFormFamille
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifFormFamille));
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonModifier = new System.Windows.Forms.Button();
            this.GroupBoxAdd = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanelAdd = new System.Windows.Forms.TableLayoutPanel();
            this.LabelNom = new System.Windows.Forms.Label();
            this.TextBoxNom = new System.Windows.Forms.TextBox();
            this.LabelRefFamille = new System.Windows.Forms.Label();
            this.GroupBoxAdd.SuspendLayout();
            this.TableLayoutPanelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonModifier
            // 
            resources.ApplyResources(this.ButtonModifier, "ButtonModifier");
            this.ButtonModifier.Name = "ButtonModifier";
            this.ButtonModifier.UseVisualStyleBackColor = true;
            this.ButtonModifier.Click += new System.EventHandler(this.ButtonModifier_Click);
            // 
            // GroupBoxAdd
            // 
            this.GroupBoxAdd.Controls.Add(this.TableLayoutPanelAdd);
            resources.ApplyResources(this.GroupBoxAdd, "GroupBoxAdd");
            this.GroupBoxAdd.Name = "GroupBoxAdd";
            this.GroupBoxAdd.TabStop = false;
            // 
            // TableLayoutPanelAdd
            // 
            resources.ApplyResources(this.TableLayoutPanelAdd, "TableLayoutPanelAdd");
            this.TableLayoutPanelAdd.Controls.Add(this.LabelNom, 0, 0);
            this.TableLayoutPanelAdd.Controls.Add(this.TextBoxNom, 1, 0);
            this.TableLayoutPanelAdd.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TableLayoutPanelAdd.Name = "TableLayoutPanelAdd";
            // 
            // LabelNom
            // 
            resources.ApplyResources(this.LabelNom, "LabelNom");
            this.LabelNom.Name = "LabelNom";
            // 
            // TextBoxNom
            // 
            resources.ApplyResources(this.TextBoxNom, "TextBoxNom");
            this.TextBoxNom.Name = "TextBoxNom";
            // 
            // LabelRefFamille
            // 
            resources.ApplyResources(this.LabelRefFamille, "LabelRefFamille");
            this.LabelRefFamille.Name = "LabelRefFamille";
            // 
            // ModifFormFamille
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.LabelRefFamille);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonModifier);
            this.Controls.Add(this.GroupBoxAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModifFormFamille";
            this.GroupBoxAdd.ResumeLayout(false);
            this.GroupBoxAdd.PerformLayout();
            this.TableLayoutPanelAdd.ResumeLayout(false);
            this.TableLayoutPanelAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonModifier;
        private System.Windows.Forms.GroupBox GroupBoxAdd;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAdd;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.TextBox TextBoxNom;
        private System.Windows.Forms.Label LabelRefFamille;
    }
}