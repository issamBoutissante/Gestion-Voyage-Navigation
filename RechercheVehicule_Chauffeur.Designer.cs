namespace Companie_de_voyage_mode_deconnecte
{
    partial class RechercheVehicule_Chauffeur
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
            this.VehiculedataGridView = new System.Windows.Forms.DataGridView();
            this.ChauffeurList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VehiculedataGridView
            // 
            this.VehiculedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiculedataGridView.Location = new System.Drawing.Point(186, 223);
            this.VehiculedataGridView.Name = "VehiculedataGridView";
            this.VehiculedataGridView.Size = new System.Drawing.Size(303, 150);
            this.VehiculedataGridView.TabIndex = 9;
            // 
            // ChauffeurList
            // 
            this.ChauffeurList.FormattingEnabled = true;
            this.ChauffeurList.Location = new System.Drawing.Point(368, 126);
            this.ChauffeurList.Name = "ChauffeurList";
            this.ChauffeurList.Size = new System.Drawing.Size(121, 21);
            this.ChauffeurList.TabIndex = 8;
            this.ChauffeurList.SelectedIndexChanged += new System.EventHandler(this.ChauffeurList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(182, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom Chauffeur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(364, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vehicule Par Chauffeur";
            // 
            // RechercheVehicule_Chauffeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VehiculedataGridView);
            this.Controls.Add(this.ChauffeurList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RechercheVehicule_Chauffeur";
            this.Text = "RechercheVehicule_Chauffeur";
            ((System.ComponentModel.ISupportInitialize)(this.VehiculedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VehiculedataGridView;
        private System.Windows.Forms.ComboBox ChauffeurList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}