namespace Companie_de_voyage_mode_deconnecte
{
    partial class RechercheVoyage_Chauffeur
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
            this.ChauffeurList = new System.Windows.Forms.ComboBox();
            this.VehiculedataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(238, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voyage effectue par chauffeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(56, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom Chauffeur";
            // 
            // ChauffeurList
            // 
            this.ChauffeurList.FormattingEnabled = true;
            this.ChauffeurList.Location = new System.Drawing.Point(242, 107);
            this.ChauffeurList.Name = "ChauffeurList";
            this.ChauffeurList.Size = new System.Drawing.Size(121, 21);
            this.ChauffeurList.TabIndex = 4;
            this.ChauffeurList.SelectedIndexChanged += new System.EventHandler(this.ChauffeurList_SelectedIndexChanged);
            // 
            // VehiculedataGridView
            // 
            this.VehiculedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiculedataGridView.Location = new System.Drawing.Point(60, 204);
            this.VehiculedataGridView.Name = "VehiculedataGridView";
            this.VehiculedataGridView.Size = new System.Drawing.Size(303, 150);
            this.VehiculedataGridView.TabIndex = 5;
            // 
            // RechercheVoyage_Chauffeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VehiculedataGridView);
            this.Controls.Add(this.ChauffeurList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RechercheVoyage_Chauffeur";
            this.Text = "RechercheVoyage_Chauffeur";
            ((System.ComponentModel.ISupportInitialize)(this.VehiculedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ChauffeurList;
        private System.Windows.Forms.DataGridView VehiculedataGridView;
    }
}