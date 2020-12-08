namespace Companie_de_voyage_mode_deconnecte
{
    partial class RechercheVoyage_Vehicule
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
            this.VoyagedataGridView = new System.Windows.Forms.DataGridView();
            this.ImmatriculeList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VoyagedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VoyagedataGridView
            // 
            this.VoyagedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VoyagedataGridView.Location = new System.Drawing.Point(186, 223);
            this.VoyagedataGridView.Name = "VoyagedataGridView";
            this.VoyagedataGridView.Size = new System.Drawing.Size(255, 150);
            this.VoyagedataGridView.TabIndex = 9;
            // 
            // ImmatriculeList
            // 
            this.ImmatriculeList.FormattingEnabled = true;
            this.ImmatriculeList.Location = new System.Drawing.Point(368, 126);
            this.ImmatriculeList.Name = "ImmatriculeList";
            this.ImmatriculeList.Size = new System.Drawing.Size(121, 21);
            this.ImmatriculeList.TabIndex = 8;
            this.ImmatriculeList.SelectedIndexChanged += new System.EventHandler(this.ImmatriculeList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(182, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Immatricule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(364, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Voyage Effectue par Vehicule";
            // 
            // RechercheVoyage_Vehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VoyagedataGridView);
            this.Controls.Add(this.ImmatriculeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RechercheVoyage_Vehicule";
            this.Text = "RechercheVoyage_Vehicule";
            ((System.ComponentModel.ISupportInitialize)(this.VoyagedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VoyagedataGridView;
        private System.Windows.Forms.ComboBox ImmatriculeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}