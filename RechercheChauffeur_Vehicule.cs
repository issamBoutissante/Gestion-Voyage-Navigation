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
    public partial class RechercheChauffeur_Vehicule : Form
    {
        GereData gereData = new GereData();
        DataSet dataSet;
        SqlDataAdapter adapter;
        public RechercheChauffeur_Vehicule()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("select immatricule from vehicule;", gereData.Connction);
            dataSet = new DataSet();
            dataSet.Clear();
            adapter.Fill(dataSet, "Vehicule");
            adapter.SelectCommand.CommandText = "select voyage.id_chauffeur,concat(nom,' ',prenom) as Nom,id_Voyage,date_voyage ,immatricule " +
                "from voyage join chauffeur on voyage.ID_chauffeur=chauffeur.ID_chauffeur;";
            adapter.Fill(dataSet, "Voyage");
            ImmatriculeList.ValueMember = "immatricule";
            ImmatriculeList.DisplayMember = "immatricule";
            ImmatriculeList.DataSource = dataSet.Tables["Vehicule"];

        }

        private void ImmatriculeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataSet.Tables["Voyage"].DefaultView.RowFilter = $"immatricule ='{ImmatriculeList.SelectedValue}'";
                dataSet.Tables["Voyage"].DefaultView.Sort = "id_chauffeur";
                ChauffeurdataGridView.DataSource = dataSet.Tables["Voyage"].DefaultView;
                ChauffeurdataGridView.Columns["immatricule"].Visible = false;
            }catch(SqlException ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }
    }
}
