using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Companie_de_voyage_mode_deconnecte
{
    public partial class NavigationVoyage : Form
    {
        GereData gereData = new GereData();
        DataSet dataSet;
        SqlDataAdapter adapter;
        int i=0;
        public NavigationVoyage()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("select id_voyage,date_voyage,id_chauffeur,immatricule from Voyage;", gereData.Connction);
            dataSet = new DataSet();
            dataSet.Clear();
            adapter.Fill(dataSet, "Voyage");
            NombreVoyage.Text = dataSet.Tables["Voyage"].Rows.Count.ToString();
        }

        private void Premier_Click(object sender, EventArgs e)
        {
            i = 0;
            Remplir();
        }
        void Remplir()
        {
            IdVoyage.Text = dataSet.Tables["Voyage"].Rows[i].ItemArray[0].ToString();
            DateVoyage.Text = dataSet.Tables["Voyage"].Rows[i].ItemArray[1].ToString();
            IdChauffeur.Text = dataSet.Tables["Voyage"].Rows[i].ItemArray[2].ToString();
            Immatricule.Text = dataSet.Tables["Voyage"].Rows[i].ItemArray[3].ToString();
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            if (i < dataSet.Tables["Voyage"].Rows.Count - 1)
            {
                i++;
                Remplir();
            }
        }

        private void Presedent_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                Remplir();
            }
        }

        private void Dernier_Click(object sender, EventArgs e)
        {
            i = dataSet.Tables["Voyage"].Rows.Count - 1;
            Remplir();
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            int j = 0;
            foreach(DataRow row in dataSet.Tables["Voyage"].Rows)
            {
                if (row["id_voyage"].ToString() == RechercheTBX.Text)
                {
                    i = j;
                    Remplir();
                    return;
                }
                j++;
            }
            MessageBox.Show("cette voyage n'existe pas");
        }
    }
}
