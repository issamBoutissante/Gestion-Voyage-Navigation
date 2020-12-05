namespace Companie_de_voyage_mode_deconnecte
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chauffeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voyageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheVoyagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheVehiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chauffeurToolStripMenuItem,
            this.vehiculeToolStripMenuItem,
            this.voyageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chauffeurToolStripMenuItem
            // 
            this.chauffeurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem,
            this.rechercheVoyagesToolStripMenuItem,
            this.rechercheVehiculeToolStripMenuItem});
            this.chauffeurToolStripMenuItem.Name = "chauffeurToolStripMenuItem";
            this.chauffeurToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.chauffeurToolStripMenuItem.Text = "Chauffeur";
            // 
            // vehiculeToolStripMenuItem
            // 
            this.vehiculeToolStripMenuItem.Name = "vehiculeToolStripMenuItem";
            this.vehiculeToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.vehiculeToolStripMenuItem.Text = "Vehicule";
            // 
            // voyageToolStripMenuItem
            // 
            this.voyageToolStripMenuItem.Name = "voyageToolStripMenuItem";
            this.voyageToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.voyageToolStripMenuItem.Text = "Voyage";
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.navigationToolStripMenuItem.Text = "Navigation";
            this.navigationToolStripMenuItem.Click += new System.EventHandler(this.navigationToolStripMenuItem_Click);
            // 
            // rechercheVoyagesToolStripMenuItem
            // 
            this.rechercheVoyagesToolStripMenuItem.Name = "rechercheVoyagesToolStripMenuItem";
            this.rechercheVoyagesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rechercheVoyagesToolStripMenuItem.Text = "Recherche Voyages";
            this.rechercheVoyagesToolStripMenuItem.Click += new System.EventHandler(this.rechercheVoyagesToolStripMenuItem_Click);
            // 
            // rechercheVehiculeToolStripMenuItem
            // 
            this.rechercheVehiculeToolStripMenuItem.Name = "rechercheVehiculeToolStripMenuItem";
            this.rechercheVehiculeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rechercheVehiculeToolStripMenuItem.Text = "Recherche Vehicule";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chauffeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheVoyagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheVehiculeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voyageToolStripMenuItem;
    }
}

