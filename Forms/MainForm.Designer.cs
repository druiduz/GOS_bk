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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Vente = new System.Windows.Forms.Button();
            this.Gestion_stock = new System.Windows.Forms.Button();
            this.Report_Vente = new System.Windows.Forms.Button();
            this.Gestion_carte_magnetique = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripComboBox1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(720, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(720, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(118, 17);
            this.statusLabel.Text = "toolStripStatusLabel1";
            // 
            // Vente
            // 
            this.Vente.Location = new System.Drawing.Point(94, 165);
            this.Vente.Name = "Vente";
            this.Vente.Size = new System.Drawing.Size(215, 76);
            this.Vente.TabIndex = 2;
            this.Vente.Text = "Vente";
            this.Vente.UseVisualStyleBackColor = true;
            this.Vente.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gestion_stock
            // 
            this.Gestion_stock.Location = new System.Drawing.Point(354, 165);
            this.Gestion_stock.Name = "Gestion_stock";
            this.Gestion_stock.Size = new System.Drawing.Size(215, 76);
            this.Gestion_stock.TabIndex = 3;
            this.Gestion_stock.Text = "Gestion stock";
            this.Gestion_stock.UseVisualStyleBackColor = true;
            this.Gestion_stock.Click += new System.EventHandler(this.button2_Click);
            // 
            // Report_Vente
            // 
            this.Report_Vente.Location = new System.Drawing.Point(354, 280);
            this.Report_Vente.Name = "Report_Vente";
            this.Report_Vente.Size = new System.Drawing.Size(215, 76);
            this.Report_Vente.TabIndex = 5;
            this.Report_Vente.Text = "Report Vente";
            this.Report_Vente.UseVisualStyleBackColor = true;
            // 
            // Gestion_carte_magnetique
            // 
            this.Gestion_carte_magnetique.Location = new System.Drawing.Point(94, 280);
            this.Gestion_carte_magnetique.Name = "Gestion_carte_magnetique";
            this.Gestion_carte_magnetique.Size = new System.Drawing.Size(215, 76);
            this.Gestion_carte_magnetique.TabIndex = 4;
            this.Gestion_carte_magnetique.Text = "Gestion carte Magnétique";
            this.Gestion_carte_magnetique.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 422);
            this.Controls.Add(this.Report_Vente);
            this.Controls.Add(this.Gestion_carte_magnetique);
            this.Controls.Add(this.Gestion_stock);
            this.Controls.Add(this.Vente);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Accueil";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button Vente;
        private System.Windows.Forms.Button Gestion_stock;
        private System.Windows.Forms.Button Report_Vente;
        private System.Windows.Forms.Button Gestion_carte_magnetique;
    }
}

