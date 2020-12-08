namespace Companie_de_voyage_mode_deconnecte
{
    partial class NavigationVoyage
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
            this.Rechercher = new System.Windows.Forms.Button();
            this.FicheChauffeur = new System.Windows.Forms.GroupBox();
            this.IdVoyage = new System.Windows.Forms.TextBox();
            this.IdChauffeur = new System.Windows.Forms.TextBox();
            this.Immatricule = new System.Windows.Forms.TextBox();
            this.Dernier = new System.Windows.Forms.Button();
            this.Presedent = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Suivant = new System.Windows.Forms.Button();
            this.Premier = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateVoyage = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.RechercheTBX = new System.Windows.Forms.TextBox();
            this.NombreVoyage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FicheChauffeur.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rechercher
            // 
            this.Rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Rechercher.ForeColor = System.Drawing.Color.Blue;
            this.Rechercher.Location = new System.Drawing.Point(427, 45);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(112, 27);
            this.Rechercher.TabIndex = 32;
            this.Rechercher.Text = "Recherche";
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // FicheChauffeur
            // 
            this.FicheChauffeur.Controls.Add(this.IdVoyage);
            this.FicheChauffeur.Controls.Add(this.IdChauffeur);
            this.FicheChauffeur.Controls.Add(this.Immatricule);
            this.FicheChauffeur.Controls.Add(this.Dernier);
            this.FicheChauffeur.Controls.Add(this.Presedent);
            this.FicheChauffeur.Controls.Add(this.label11);
            this.FicheChauffeur.Controls.Add(this.Suivant);
            this.FicheChauffeur.Controls.Add(this.Premier);
            this.FicheChauffeur.Controls.Add(this.label12);
            this.FicheChauffeur.Controls.Add(this.label7);
            this.FicheChauffeur.Controls.Add(this.DateVoyage);
            this.FicheChauffeur.Controls.Add(this.label8);
            this.FicheChauffeur.Location = new System.Drawing.Point(16, 115);
            this.FicheChauffeur.Name = "FicheChauffeur";
            this.FicheChauffeur.Size = new System.Drawing.Size(735, 197);
            this.FicheChauffeur.TabIndex = 31;
            this.FicheChauffeur.TabStop = false;
            this.FicheChauffeur.Text = "Fiche Chauffeur";
            // 
            // IdVoyage
            // 
            this.IdVoyage.Location = new System.Drawing.Point(27, 78);
            this.IdVoyage.Name = "IdVoyage";
            this.IdVoyage.Size = new System.Drawing.Size(105, 20);
            this.IdVoyage.TabIndex = 33;
            // 
            // IdChauffeur
            // 
            this.IdChauffeur.Location = new System.Drawing.Point(375, 74);
            this.IdChauffeur.Name = "IdChauffeur";
            this.IdChauffeur.Size = new System.Drawing.Size(105, 20);
            this.IdChauffeur.TabIndex = 34;
            // 
            // Immatricule
            // 
            this.Immatricule.Location = new System.Drawing.Point(546, 75);
            this.Immatricule.Name = "Immatricule";
            this.Immatricule.Size = new System.Drawing.Size(105, 20);
            this.Immatricule.TabIndex = 35;
            // 
            // Dernier
            // 
            this.Dernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Dernier.ForeColor = System.Drawing.Color.Blue;
            this.Dernier.Location = new System.Drawing.Point(519, 138);
            this.Dernier.Name = "Dernier";
            this.Dernier.Size = new System.Drawing.Size(112, 27);
            this.Dernier.TabIndex = 19;
            this.Dernier.Text = "Dernier";
            this.Dernier.UseVisualStyleBackColor = true;
            this.Dernier.Click += new System.EventHandler(this.Dernier_Click);
            // 
            // Presedent
            // 
            this.Presedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Presedent.ForeColor = System.Drawing.Color.Blue;
            this.Presedent.Location = new System.Drawing.Point(342, 138);
            this.Presedent.Name = "Presedent";
            this.Presedent.Size = new System.Drawing.Size(112, 27);
            this.Presedent.TabIndex = 18;
            this.Presedent.Text = "Presedent";
            this.Presedent.UseVisualStyleBackColor = true;
            this.Presedent.Click += new System.EventHandler(this.Presedent_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(26, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 112;
            this.label11.Text = "id voyage";
            // 
            // Suivant
            // 
            this.Suivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Suivant.ForeColor = System.Drawing.Color.Blue;
            this.Suivant.Location = new System.Drawing.Point(180, 138);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(112, 27);
            this.Suivant.TabIndex = 17;
            this.Suivant.Text = "Suivant";
            this.Suivant.UseVisualStyleBackColor = true;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // Premier
            // 
            this.Premier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Premier.ForeColor = System.Drawing.Color.Blue;
            this.Premier.Location = new System.Drawing.Point(16, 138);
            this.Premier.Name = "Premier";
            this.Premier.Size = new System.Drawing.Size(112, 27);
            this.Premier.TabIndex = 16;
            this.Premier.Text = "Premier";
            this.Premier.UseVisualStyleBackColor = true;
            this.Premier.Click += new System.EventHandler(this.Premier_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(195, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 98;
            this.label12.Text = "date voyage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(543, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 108;
            this.label7.Text = "matricule";
            // 
            // DateVoyage
            // 
            this.DateVoyage.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateVoyage.Location = new System.Drawing.Point(198, 75);
            this.DateVoyage.Name = "DateVoyage";
            this.DateVoyage.Size = new System.Drawing.Size(126, 20);
            this.DateVoyage.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(372, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 107;
            this.label8.Text = "id chauffeur";
            // 
            // RechercheTBX
            // 
            this.RechercheTBX.Location = new System.Drawing.Point(562, 50);
            this.RechercheTBX.Name = "RechercheTBX";
            this.RechercheTBX.Size = new System.Drawing.Size(105, 20);
            this.RechercheTBX.TabIndex = 30;
            // 
            // NombreVoyage
            // 
            this.NombreVoyage.AutoSize = true;
            this.NombreVoyage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreVoyage.ForeColor = System.Drawing.Color.Blue;
            this.NombreVoyage.Location = new System.Drawing.Point(195, 51);
            this.NombreVoyage.Name = "NombreVoyage";
            this.NombreVoyage.Size = new System.Drawing.Size(0, 20);
            this.NombreVoyage.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre Voyage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Voyage";
            // 
            // NavigationVoyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.FicheChauffeur);
            this.Controls.Add(this.RechercheTBX);
            this.Controls.Add(this.NombreVoyage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NavigationVoyage";
            this.Text = "NavigationVoyage";
            this.FicheChauffeur.ResumeLayout(false);
            this.FicheChauffeur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.GroupBox FicheChauffeur;
        private System.Windows.Forms.Button Dernier;
        private System.Windows.Forms.Button Presedent;
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.Button Premier;
        private System.Windows.Forms.TextBox RechercheTBX;
        private System.Windows.Forms.Label NombreVoyage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdVoyage;
        private System.Windows.Forms.TextBox IdChauffeur;
        private System.Windows.Forms.TextBox Immatricule;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateVoyage;
        private System.Windows.Forms.Label label8;
    }
}