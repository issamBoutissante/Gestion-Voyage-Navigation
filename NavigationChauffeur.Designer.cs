namespace Companie_de_voyage_mode_deconnecte
{
    partial class NavigationChauffeur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreChauffeur = new System.Windows.Forms.Label();
            this.RechercheTBX = new System.Windows.Forms.TextBox();
            this.FicheChauffeur = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Salaire = new System.Windows.Forms.TextBox();
            this.DateRecrutement = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Id_chauffeur = new System.Windows.Forms.TextBox();
            this.Rechercher = new System.Windows.Forms.Button();
            this.FicheChauffeur.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(301, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chauffeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Chauffeur";
            // 
            // NombreChauffeur
            // 
            this.NombreChauffeur.AutoSize = true;
            this.NombreChauffeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreChauffeur.ForeColor = System.Drawing.Color.Blue;
            this.NombreChauffeur.Location = new System.Drawing.Point(206, 78);
            this.NombreChauffeur.Name = "NombreChauffeur";
            this.NombreChauffeur.Size = new System.Drawing.Size(0, 20);
            this.NombreChauffeur.TabIndex = 4;
            // 
            // RechercheTBX
            // 
            this.RechercheTBX.Location = new System.Drawing.Point(573, 77);
            this.RechercheTBX.Name = "RechercheTBX";
            this.RechercheTBX.Size = new System.Drawing.Size(105, 20);
            this.RechercheTBX.TabIndex = 5;
            // 
            // FicheChauffeur
            // 
            this.FicheChauffeur.Controls.Add(this.button4);
            this.FicheChauffeur.Controls.Add(this.button3);
            this.FicheChauffeur.Controls.Add(this.button2);
            this.FicheChauffeur.Controls.Add(this.button1);
            this.FicheChauffeur.Controls.Add(this.label8);
            this.FicheChauffeur.Controls.Add(this.label7);
            this.FicheChauffeur.Controls.Add(this.label6);
            this.FicheChauffeur.Controls.Add(this.label5);
            this.FicheChauffeur.Controls.Add(this.label4);
            this.FicheChauffeur.Controls.Add(this.Salaire);
            this.FicheChauffeur.Controls.Add(this.DateRecrutement);
            this.FicheChauffeur.Controls.Add(this.Prenom);
            this.FicheChauffeur.Controls.Add(this.Nom);
            this.FicheChauffeur.Controls.Add(this.Id_chauffeur);
            this.FicheChauffeur.Location = new System.Drawing.Point(27, 142);
            this.FicheChauffeur.Name = "FicheChauffeur";
            this.FicheChauffeur.Size = new System.Drawing.Size(735, 156);
            this.FicheChauffeur.TabIndex = 6;
            this.FicheChauffeur.TabStop = false;
            this.FicheChauffeur.Text = "Fiche Chauffeur";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(509, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 27);
            this.button4.TabIndex = 19;
            this.button4.Text = "Dernier";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(332, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 27);
            this.button3.TabIndex = 18;
            this.button3.Text = "Presedent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(170, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "Suivant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(6, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Premier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(594, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Salaire";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(431, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date Recrutement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(293, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(141, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id_chauffeur";
            // 
            // Salaire
            // 
            this.Salaire.Location = new System.Drawing.Point(598, 60);
            this.Salaire.Name = "Salaire";
            this.Salaire.Size = new System.Drawing.Size(105, 20);
            this.Salaire.TabIndex = 11;
            // 
            // DateRecrutement
            // 
            this.DateRecrutement.Location = new System.Drawing.Point(435, 60);
            this.DateRecrutement.Name = "DateRecrutement";
            this.DateRecrutement.Size = new System.Drawing.Size(153, 20);
            this.DateRecrutement.TabIndex = 10;
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(297, 60);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(105, 20);
            this.Prenom.TabIndex = 9;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(145, 60);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(105, 20);
            this.Nom.TabIndex = 8;
            // 
            // Id_chauffeur
            // 
            this.Id_chauffeur.Location = new System.Drawing.Point(6, 60);
            this.Id_chauffeur.Name = "Id_chauffeur";
            this.Id_chauffeur.Size = new System.Drawing.Size(105, 20);
            this.Id_chauffeur.TabIndex = 7;
            // 
            // Rechercher
            // 
            this.Rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Rechercher.ForeColor = System.Drawing.Color.Blue;
            this.Rechercher.Location = new System.Drawing.Point(438, 72);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(112, 27);
            this.Rechercher.TabIndex = 20;
            this.Rechercher.Text = "Recherche";
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // NavigationChauffeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.FicheChauffeur);
            this.Controls.Add(this.RechercheTBX);
            this.Controls.Add(this.NombreChauffeur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NavigationChauffeur";
            this.Text = "NavigationChauffeur";
            this.FicheChauffeur.ResumeLayout(false);
            this.FicheChauffeur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NombreChauffeur;
        private System.Windows.Forms.TextBox RechercheTBX;
        private System.Windows.Forms.GroupBox FicheChauffeur;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Salaire;
        private System.Windows.Forms.TextBox DateRecrutement;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Id_chauffeur;
        private System.Windows.Forms.Button Rechercher;
    }
}