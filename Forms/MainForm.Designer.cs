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
            this.Vente = new System.Windows.Forms.Button();
            this.Gestion_stock = new System.Windows.Forms.Button();
            this.Report_Vente = new System.Windows.Forms.Button();
            this.Gestion_carte_magnetique = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.Name = "MainForm";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vente;
        private System.Windows.Forms.Button Gestion_stock;
        private System.Windows.Forms.Button Report_Vente;
        private System.Windows.Forms.Button Gestion_carte_magnetique;
    }
}

