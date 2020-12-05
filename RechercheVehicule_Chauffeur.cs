using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companie_de_voyage_mode_deconnecte
{
    public partial class RechercheVehicule_Chauffeur : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["monConnection"].ConnectionString;
        DataSet dataSet;
        SqlDataAdapter adapter;

        public RechercheVehicule_Chauffeur()
        {
            InitializeComponent();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter("select voyage.immatricule,marque,id_voyage,date_voyage," +
                "id_chauffeur from voyage join vehicule on voyage.Immatricule=vehicule.Immatricule;", connectionString);
            dataSet.Clear();
            adapter.Fill(dataSet, "voyage");
            adapter.SelectCommand.CommandText = "select * from chauffeur";
            adapter.Fill(dataSet, "chauffeur");
            ChauffeurList.DisplayMember = "nom";
            ChauffeurList.ValueMember = "id_chauffeur";
            ChauffeurList.DataSource = dataSet.Tables["chauffeur"];
        }

        private void ChauffeurList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataSet.Tables["voyage"].DefaultView.RowFilter = $"Id_chauffeur={ChauffeurList.SelectedValue}";
                dataSet.Tables["voyage"].DefaultView.Sort = "id_voyage asc";
                VehiculedataGridView.DataSource = dataSet.Tables["voyage"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($" Error : {ex.Message}");
            }
        }
    }
}
