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
    public partial class RechercheVoyage_Vehicule : Form
    {
        GereData gereData = new GereData();
        DataSet dataSet;
        SqlDataAdapter adapter;
        public RechercheVoyage_Vehicule()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("select id_voyage,date_voyage,immatricule from Voyage", gereData.Connction);
            dataSet = new DataSet();
            dataSet.Clear();
            adapter.Fill(dataSet, "Voyage");
            adapter.SelectCommand.CommandText = "select immatricule from vehicule";
            adapter.Fill(dataSet, "Vehicule");
            ImmatriculeList.ValueMember = "immatricule";
            ImmatriculeList.DisplayMember = "immatricule";
            ImmatriculeList.DataSource = dataSet.Tables["Vehicule"];
        }

        private void ImmatriculeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataSet.Tables["Voyage"].DefaultView.RowFilter = $"immatricule='{ImmatriculeList.SelectedValue}'";
                dataSet.Tables["Voyage"].DefaultView.Sort = "id_voyage";
                VoyagedataGridView.DataSource = dataSet.Tables["Voyage"];
                VoyagedataGridView.Columns["immatricule"].Visible = false;
               
            }catch(SqlException ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }
    }
}
