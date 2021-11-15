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
    public partial class frmDashboard : Form
    {
        private string username;
        public frmDashboard(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                SqlCommand sqlCommand = new SqlCommand("SELECT FULL_NAME, ROLE_NAME, MANAGER FROM ACCOUNT a, ROLE b WHERE a.ROLE = b.ROLE AND USERNAME = '" + username + "'", sqlConnection);
                sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    lblUser.Text = Convert.ToString(dataReader["FULL_NAME"]);
                    lblRole.Text = Convert.ToString(dataReader["ROLE_NAME"]);

                    tsmManage.Visible = Convert.ToBoolean(dataReader["MANAGER"]);
                }
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsmUserInfo_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);
                
                SqlCommand sqlCommand = new SqlCommand("SELECT USERNAME, FULL_NAME, GENDER, PHONE, ROLE_NAME FROM ACCOUNT a, ROLE b WHERE a.ROLE = b.ROLE AND USERNAME = '" + username + "'", sqlConnection);
                sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    string gender;
                    if (dataReader["GENDER"] == DBNull.Value) gender = "Không xác định";
                    else
                    {
                        bool isFemale = Convert.ToBoolean(dataReader["GENDER"]);
                        if (isFemale) gender = "Nữ";
                        else gender = "Nam";
                    }
                    MessageBox.Show("Tên đăng nhập: " + Convert.ToString(dataReader["USERNAME"]) +
                                    "\nTên người dùng: " + Convert.ToString(dataReader["FULL_NAME"]) +
                                    "\nGiới tính: " + gender +
                                    "\nSố điện thoại: " + Convert.ToString(dataReader["PHONE"]) +
                                    "\nChức vụ: " + Convert.ToString(dataReader["ROLE_NAME"]), "Thông tin tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Close();
        }

        private void tsmChangePass_Click(object sender, EventArgs e)
        {
            var frm = new ChangePass(username);
            frm.ShowDialog();
        }

        private void tsmBookRoom_Click(object sender, EventArgs e)
        {
            var frm = new BookRoom();
            frm.ShowDialog();
        }

        private void tsmChangeRoom_Click(object sender, EventArgs e)
        {
            var frm = new ChangeRoom();
            frm.ShowDialog();
        }

        private void tsmProfit_Click(object sender, EventArgs e)
        {
            var frm = new Profit();
            frm.ShowDialog();
        }

        private void tsmManageAccount_Click(object sender, EventArgs e)
        {
            var frm = new ManageAccount();
            frm.ShowDialog();
        }

        private void tsmManageRole_Click(object sender, EventArgs e)
        {
            var frm = new ManageRole();
            frm.ShowDialog();
        }

        private void tsmManageRoom_Click(object sender, EventArgs e)
        {
            var frm = new ManageRoom();
            frm.ShowDialog();
        }

        private void tsmManageBooking_Click(object sender, EventArgs e)
        {
            var frm = new ManageBooking();
            frm.ShowDialog();
        }
    }
}
