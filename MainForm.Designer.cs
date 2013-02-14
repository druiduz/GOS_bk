namespace GOS
{
    partial class MainForm
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
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MenuFichier = new System.Windows.Forms.ToolStripDropDownButton();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFichier,
            this.MenuHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(753, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MenuFichier
            // 
            this.MenuFichier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem});
            this.MenuFichier.Image = ((System.Drawing.Image)(resources.GetObject("MenuFichier.Image")));
            this.MenuFichier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuFichier.Name = "MenuFichier";
            this.MenuFichier.Size = new System.Drawing.Size(55, 22);
            this.MenuFichier.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir...";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuHelp.Image = ((System.Drawing.Image)(resources.GetObject("MenuHelp.Image")));
            this.MenuHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(25, 22);
            this.MenuHelp.Text = "?";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(753, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(118, 17);
            this.statusLabel.Text = "toolStripStatusLabel1";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 437);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripDropDownButton MenuFichier;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton MenuHelp;
    }
}

