using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companie_de_voyage_mode_deconnecte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void navigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new NavigationChauffeur());
        }
        void openForm(Form newForm)
        {
            newForm.MdiParent = this;
            newForm.Dock = DockStyle.Fill;
            newForm.Show();
        }

        private void rechercheVoyagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new RechercheVoyage_Chauffeur());
        }
    }
}
