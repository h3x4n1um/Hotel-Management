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
    public partial class ChangePass : Form
    {
        private string username;
        public ChangePass(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Huỷ thay đổi mật khẩu?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Close();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string password = txtNewPass.Text;
            string confirmPassword = txtConfirmPass.Text;

            if (password.CompareTo(confirmPassword) != 0)
            {
                MessageBox.Show("Mật khẩu nhập không khớp!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            
            if (MessageBox.Show("Bạn có muốn thay đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                    SqlCommand sqlCommand = new SqlCommand("UPDATE ACCOUNT SET PASSWORD = '" + password + "' WHERE USERNAME = '" + username + "'", sqlConnection);
                    sqlConnection.Open();
                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        sqlConnection.Close();
                        MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        sqlConnection.Close();
                        MessageBox.Show("Không thể đổi mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChangePass_Load(object sender, EventArgs e)
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

                    txtUser.Text = Convert.ToString(dataReader["USERNAME"]);
                    txtFullName.Text = Convert.ToString(dataReader["FULL_NAME"]);
                    txtGender.Text = gender;
                    txtPhone.Text = Convert.ToString(dataReader["PHONE"]);
                    txtRoleName.Text = Convert.ToString(dataReader["ROLE_NAME"]);
                }

                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePass_Shown(object sender, EventArgs e)
        {
            txtNewPass.Focus();
        }
    }
}
