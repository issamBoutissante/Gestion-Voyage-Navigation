using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companie_de_voyage_mode_deconnecte
{
    public partial class NavigationVehicule : Form
    {
        GereData gereData = new GereData();
        DataSet dataSet;
        SqlDataAdapter adapter;
        int i=0 ;
        public NavigationVehicule()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("select * from Vehicule;", gereData.Connction);
            dataSet = new DataSet();
            dataSet.Clear();
            adapter.Fill(dataSet, "Vehicule");
            NombreVehicule.Text = dataSet.Tables["Vehicule"].Rows.Count.ToString();
        }

        private void Premier_Click(object sender, EventArgs e)
        {
            i = 0;
            Remplir();
        }
        void Remplir()
        {
            Immatricule.Text= dataSet.Tables["Vehicule"].Rows[i].ItemArray[0].ToString();
            Marque.Text = dataSet.Tables["Vehicule"].Rows[i].ItemArray[1].ToString();
            TypeVehicule.Text = dataSet.Tables["Vehicule"].Rows[i].ItemArray[2].ToString();
            DateMiseService.Text = dataSet.Tables["Vehicule"].Rows[i].ItemArray[3].ToString();
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            if (i < dataSet.Tables["Vehicule"].Rows.Count - 1)
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
            i = dataSet.Tables["Vehicule"].Rows.Count - 1;
            Remplir();
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            int j = 0;
            foreach(DataRow row in dataSet.Tables["Vehicule"].Rows)
            {
                if (row["immatricule"].ToString() == RechercheTBX.Text)
                {
                    i = j;
                    Remplir();
                    return;
                }
                j++;
            }
            MessageBox.Show("ce vehicule n'est pas existe");
        }
    }
}
