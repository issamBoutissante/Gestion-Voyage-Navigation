namespace Companie_de_voyage_mode_deconnecte
{
    partial class RechercheChauffeur_Vehicule
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
            this.ChauffeurdataGridView = new System.Windows.Forms.DataGridView();
            this.ImmatriculeList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChauffeurdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ChauffeurdataGridView
            // 
            this.ChauffeurdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChauffeurdataGridView.Location = new System.Drawing.Point(76, 148);
            this.ChauffeurdataGridView.Name = "ChauffeurdataGridView";
            this.ChauffeurdataGridView.Size = new System.Drawing.Size(538, 150);
            this.ChauffeurdataGridView.TabIndex = 13;
            // 
            // ImmatriculeList
            // 
            this.ImmatriculeList.FormattingEnabled = true;
            this.ImmatriculeList.Location = new System.Drawing.Point(258, 87);
            this.ImmatriculeList.Name = "ImmatriculeList";
            this.ImmatriculeList.Size = new System.Drawing.Size(154, 21);
            this.ImmatriculeList.TabIndex = 12;
            this.ImmatriculeList.SelectedIndexChanged += new System.EventHandler(this.ImmatriculeList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(72, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vehicule Immatricule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(254, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chauffeur Par Vehicule";
            // 
            // RechercheChauffeur_Vehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChauffeurdataGridView);
            this.Controls.Add(this.ImmatriculeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RechercheChauffeur_Vehicule";
            this.Text = "RechercheChauffeur_Vehicule";
            ((System.ComponentModel.ISupportInitialize)(this.ChauffeurdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ChauffeurdataGridView;
        private System.Windows.Forms.ComboBox ImmatriculeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}