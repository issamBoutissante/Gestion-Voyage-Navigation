using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Companie_de_voyage_mode_deconnecte
{
    public partial class RechercheVoyage_Chauffeur : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["monConnection"].ConnectionString;
        DataSet dataSet;
        SqlDataAdapter adapter;
        public RechercheVoyage_Chauffeur()
        {
            InitializeComponent();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter("select id_voyage,date_voyage,id_chauffeur from voyage;", connectionString);
            dataSet.Clear();
            adapter.Fill(dataSet, "voyage");
            adapter.SelectCommand.CommandText = "select * from chauffeur";
            adapter.Fill(dataSet, "chauffeur");
            ChauffeurList.DisplayMember = "nom";
            ChauffeurList.ValueMember = "id_chauffeur";
            ChauffeurList.DataSource = dataSet.Tables["chauffeur"];
        }

        private void ChauffeurList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                dataSet.Tables["voyage"].DefaultView.RowFilter = $"Id_chauffeur={ChauffeurList.SelectedValue}";
                dataSet.Tables["voyage"].DefaultView.Sort = "id_voyage asc";
                VehiculedataGridView.DataSource = dataSet.Tables["voyage"].DefaultView;
                VehiculedataGridView.Columns["id_chauffeur"].Visible = false;
            }
            catch(SqlException ex)
            {
                MessageBox.Show($" Error : {ex.Message}");
            }
        }
    }
}
