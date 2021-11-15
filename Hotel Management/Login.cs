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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);
                
                SqlCommand sqlCommand = new SqlCommand("SELECT USERNAME FROM ACCOUNT WHERE USERNAME = '" + txtUser.Text + "' AND PASSWORD = '" + txtPass.Text + "'", sqlConnection);
                sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    txtPass.Clear();

                    var frmDashboard = new frmDashboard(Convert.ToString(dataReader["USERNAME"]));
                    sqlConnection.Close();
                    frmDashboard.Closed += (s, args) => Show();
                    frmDashboard.Show();
                }
                else
                {
                    sqlConnection.Close();
                    MessageBox.Show("Sai thông tin đăng nhập!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Close();
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
    }
}
