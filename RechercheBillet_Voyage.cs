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
    public partial class RechercheBillet_Voyage : Form
    {
        GereData gereData = new GereData();
        DataSet dataSet;
        SqlDataAdapter adapter;
        public RechercheBillet_Voyage()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("select id_voyage from voyage;", gereData.Connction);
            dataSet = new DataSet();
            dataSet.Clear();
            adapter.Fill(dataSet, "Voyage");
            adapter.SelectCommand.CommandText = "select * from billet;";
            adapter.Fill(dataSet, "Billet");
            Voyagelist.ValueMember = "id_voyage";
            Voyagelist.DisplayMember = "id_voyage";
            Voyagelist.DataSource = dataSet.Tables["Voyage"];
        }

        private void Voyagelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataSet.Tables["Billet"].DefaultView.RowFilter = $"id_voyage={Voyagelist.SelectedValue}";
                dataSet.Tables["Billet"].DefaultView.Sort = $"n_billet";
                BilletdataGridView.DataSource = dataSet.Tables["Billet"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error :"+ex.Message);
            }
        }
    }
}
