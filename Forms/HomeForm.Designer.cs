namespace GOS.Forms
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Report_Vente = new System.Windows.Forms.Button();
            this.Gestion_carte_magnetique = new System.Windows.Forms.Button();
            this.Gestion_stock = new System.Windows.Forms.Button();
            this.Vente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Report_Vente
            // 
            this.Report_Vente.Location = new System.Drawing.Point(349, 277);
            this.Report_Vente.Name = "Report_Vente";
            this.Report_Vente.Size = new System.Drawing.Size(215, 76);
            this.Report_Vente.TabIndex = 9;
            this.Report_Vente.Text = "Report Vente";
            this.Report_Vente.UseVisualStyleBackColor = true;
            // 
            // Gestion_carte_magnetique
            // 
            this.Gestion_carte_magnetique.Location = new System.Drawing.Point(89, 277);
            this.Gestion_carte_magnetique.Name = "Gestion_carte_magnetique";
            this.Gestion_carte_magnetique.Size = new System.Drawing.Size(215, 76);
            this.Gestion_carte_magnetique.TabIndex = 8;
            this.Gestion_carte_magnetique.Text = "Gestion carte Magnétique";
            this.Gestion_carte_magnetique.UseVisualStyleBackColor = true;
            // 
            // Gestion_stock
            // 
            this.Gestion_stock.Location = new System.Drawing.Point(349, 162);
            this.Gestion_stock.Name = "Gestion_stock";
            this.Gestion_stock.Size = new System.Drawing.Size(215, 76);
            this.Gestion_stock.TabIndex = 7;
            this.Gestion_stock.Text = "Gestion stock";
            this.Gestion_stock.UseVisualStyleBackColor = true;
            // 
            // Vente
            // 
            this.Vente.Location = new System.Drawing.Point(89, 162);
            this.Vente.Name = "Vente";
            this.Vente.Size = new System.Drawing.Size(215, 76);
            this.Vente.TabIndex = 6;
            this.Vente.Text = "Vente";
            this.Vente.UseVisualStyleBackColor = true;
            this.Vente.Click += new System.EventHandler(this.Vente_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 417);
            this.Controls.Add(this.Report_Vente);
            this.Controls.Add(this.Gestion_carte_magnetique);
            this.Controls.Add(this.Gestion_stock);
            this.Controls.Add(this.Vente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Report_Vente;
        private System.Windows.Forms.Button Gestion_carte_magnetique;
        private System.Windows.Forms.Button Gestion_stock;
        private System.Windows.Forms.Button Vente;
    }
}