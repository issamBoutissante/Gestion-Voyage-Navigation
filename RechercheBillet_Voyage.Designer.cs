namespace Companie_de_voyage_mode_deconnecte
{
    partial class RechercheBillet_Voyage
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
            this.BilletdataGridView = new System.Windows.Forms.DataGridView();
            this.Voyagelist = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BilletdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BilletdataGridView
            // 
            this.BilletdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BilletdataGridView.Location = new System.Drawing.Point(133, 205);
            this.BilletdataGridView.Name = "BilletdataGridView";
            this.BilletdataGridView.Size = new System.Drawing.Size(359, 150);
            this.BilletdataGridView.TabIndex = 17;
            // 
            // Voyagelist
            // 
            this.Voyagelist.FormattingEnabled = true;
            this.Voyagelist.Location = new System.Drawing.Point(338, 144);
            this.Voyagelist.Name = "Voyagelist";
            this.Voyagelist.Size = new System.Drawing.Size(154, 21);
            this.Voyagelist.TabIndex = 16;
            this.Voyagelist.SelectedIndexChanged += new System.EventHandler(this.Voyagelist_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(129, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Voyage Id ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(334, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Billet par voyage";
            // 
            // RechercheBillet_Voyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BilletdataGridView);
            this.Controls.Add(this.Voyagelist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RechercheBillet_Voyage";
            this.Text = "RechercheBillet_Voyage";
            ((System.ComponentModel.ISupportInitialize)(this.BilletdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BilletdataGridView;
        private System.Windows.Forms.ComboBox Voyagelist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}