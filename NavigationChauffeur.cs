using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Companie_de_voyage_mode_deconnecte
{
    public partial class NavigationChauffeur : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["monConnection"].ConnectionString;
        DataSet dataSet;
        int i;
        SqlDataAdapter adapter;
        public NavigationChauffeur()
        {
            InitializeComponent();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter("select * from chauffeur;", connectionString);
            dataSet.Clear();
            adapter.Fill(dataSet, "chauffeur");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            Remplir();
        }
        void Remplir()
        {
            Id_chauffeur.Text = dataSet.Tables["chauffeur"].Rows[i].ItemArray[0].ToString();
            Nom.Text = dataSet.Tables["chauffeur"].Rows[i].ItemArray[1].ToString();
            Prenom.Text = dataSet.Tables["chauffeur"].Rows[i].ItemArray[2].ToString();
            DateRecrutement.Text = dataSet.Tables["chauffeur"].Rows[i].ItemArray[4].ToString();
            Salaire.Text = dataSet.Tables["chauffeur"].Rows[i].ItemArray[5].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i < dataSet.Tables["chauffeur"].Rows.Count - 1)
            {
                i++;
                Remplir();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                Remplir();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = dataSet.Tables["chauffeur"].Rows.Count;
        }
    }
}
