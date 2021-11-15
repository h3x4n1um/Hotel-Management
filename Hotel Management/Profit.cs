using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Hotel_Management
{
    public partial class Profit : Form
    {
        public Profit()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                const string sqlDateFormat = "yyyyMMdd";

                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                (dgvProfit.Columns["ROOM_ID"] as DataGridViewComboBoxColumn).ValueMember = "ROOM_ID";
                (dgvProfit.Columns["ROOM_ID"] as DataGridViewComboBoxColumn).DisplayMember = "ROOM_ID";
                (dgvProfit.Columns["ROOM_ID"] as DataGridViewComboBoxColumn).DataSource = dataTable;

                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM BOOKING WHERE ARRIVE BETWEEN '" + dtpArrive.Value.ToString(sqlDateFormat) + "' AND '" + dtpDepart.Value.ToString(sqlDateFormat) + "' OR DEPART BETWEEN '" + dtpArrive.Value.ToString(sqlDateFormat) + "' AND '" + dtpDepart.Value.ToString(sqlDateFormat) + "'", sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgvProfit.DataSource = dataTable;

                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Profit_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtpArrive_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtpDepart_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
