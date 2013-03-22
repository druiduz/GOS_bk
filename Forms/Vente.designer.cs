namespace GOS
{
    partial class Vente
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
            this.Panier = new System.Windows.Forms.DataGridView();
            this.Carte = new System.Windows.Forms.Button();
            this.Espèce = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Panier)).BeginInit();
            this.SuspendLayout();
            // 
            // Panier
            // 
            this.Panier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Panier.Location = new System.Drawing.Point(751, 113);
            this.Panier.Name = "Panier";
            this.Panier.Size = new System.Drawing.Size(207, 215);
            this.Panier.TabIndex = 0;
            // 
            // Carte
            // 
            this.Carte.Location = new System.Drawing.Point(753, 429);
            this.Carte.Name = "Carte";
            this.Carte.Size = new System.Drawing.Size(239, 60);
            this.Carte.TabIndex = 1;
            this.Carte.Text = "Carte";
            this.Carte.UseVisualStyleBackColor = true;
            this.Carte.Click += new System.EventHandler(this.button1_Click);
            // 
            // Espèce
            // 
            this.Espèce.Location = new System.Drawing.Point(753, 522);
            this.Espèce.Name = "Espèce";
            this.Espèce.Size = new System.Drawing.Size(239, 60);
            this.Espèce.TabIndex = 2;
            this.Espèce.Text = "Espèce";
            this.Espèce.UseVisualStyleBackColor = true;
            this.Espèce.Click += new System.EventHandler(this.Espèce_Click);
            // 
            // Vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.Espèce);
            this.Controls.Add(this.Carte);
            this.Controls.Add(this.Panier);
            this.Name = "Vente";
            this.Text = "Vente";
            ((System.ComponentModel.ISupportInitialize)(this.Panier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Panier;
        private System.Windows.Forms.Button Carte;
        private System.Windows.Forms.Button Espèce;
    }
}