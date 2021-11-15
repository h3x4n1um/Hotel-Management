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
    public partial class ManageAccount : Form
    {
        public ManageAccount()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvAccount.Enabled = true;

            btnAdd.Enabled = true;

            txtUser.Enabled = false;
            txtPass.Enabled = false;
            txtFullName.Enabled = false;
            txtPhone.Enabled = false;

            cbGender.Enabled = false;
            cbRole.Enabled = false;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                // ah yes, the fuckery of C# ComboBox in the fucking DataGridTable and I'm too fucking lazy to create GENDER table in the db
                DataTable gender = new DataTable();
                gender.Columns.Add("IS_FEMALE", typeof(bool));
                gender.Columns.Add("NAME", typeof(string));
                
                DataRow dr = gender.NewRow();
                dr[1] = "Không xác định";
                gender.Rows.Add(dr);

                dr = gender.NewRow();
                dr[0] = false;
                dr[1] = "Nam";
                gender.Rows.Add(dr);

                dr = gender.NewRow();
                dr[0] = true;
                dr[1] = "Nữ";
                gender.Rows.Add(dr);

                (dgvAccount.Columns["GENDER"] as DataGridViewComboBoxColumn).ValueMember = "IS_FEMALE";
                (dgvAccount.Columns["GENDER"] as DataGridViewComboBoxColumn).DisplayMember = "NAME";
                (dgvAccount.Columns["GENDER"] as DataGridViewComboBoxColumn).DataSource = gender;

                cbGender.ValueMember = "IS_FEMALE";
                cbGender.DisplayMember = "NAME";
                cbGender.DataSource = gender;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROLE", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                (dgvAccount.Columns["ROLE"] as DataGridViewComboBoxColumn).ValueMember = "ROLE";
                (dgvAccount.Columns["ROLE"] as DataGridViewComboBoxColumn).DisplayMember = "ROLE_NAME";
                (dgvAccount.Columns["ROLE"] as DataGridViewComboBoxColumn).DataSource = dataTable;

                cbRole.ValueMember = "ROLE";
                cbRole.DisplayMember = "ROLE_NAME";
                cbRole.DataSource = dataTable;

                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ACCOUNT", sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgvAccount.DataSource = dataTable;

                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvAccount_SelectionChanged(object sender, EventArgs e)
        {
            int row = dgvAccount.CurrentCell.RowIndex;

            txtUser.Text = Convert.ToString(dgvAccount.Rows[row].Cells["USERNAME"].Value);
            txtPass.Text = Convert.ToString(dgvAccount.Rows[row].Cells["PASSWORD"].Value);
            txtFullName.Text = Convert.ToString(dgvAccount.Rows[row].Cells["FULL_NAME"].Value);
            txtPhone.Text = Convert.ToString(dgvAccount.Rows[row].Cells["PHONE"].Value);

            cbGender.SelectedValue = dgvAccount.Rows[row].Cells["GENDER"].Value;
            cbRole.SelectedValue = dgvAccount.Rows[row].Cells["ROLE"].Value;

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvAccount.Enabled = false;

            txtUser.Enabled = true;
            txtPass.Enabled = true;
            txtFullName.Enabled = true;
            txtPhone.Enabled = true;

            cbGender.Enabled = true;
            cbRole.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtUser.Clear();
            txtPass.Clear();
            txtFullName.Clear();
            txtPhone.Clear();

            cbGender.SelectedIndex = -1;
            cbRole.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvAccount.Enabled = false;

            txtPass.Enabled = true;
            txtFullName.Enabled = true;
            txtPhone.Enabled = true;            

            cbGender.Enabled = true;
            cbRole.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá người dùng " + txtUser.Text + "?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM ACCOUNT WHERE USERNAME='" + txtUser.Text + "'", sqlConnection);

                    sqlConnection.Open();
                    if (sqlCommand.ExecuteNonQuery() > 0) MessageBox.Show("Đã xoá người dùng " + txtUser.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Lỗi khi xoá người dùng " + txtUser.Text + "!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtPass.Text) || String.IsNullOrEmpty(txtFullName.Text) || String.IsNullOrEmpty(txtPhone.Text) || cbGender.SelectedIndex < 0 || cbRole.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có muốn lưu?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                    SqlCommand sqlCommand = new SqlCommand();

                    string cbGenderText = "NULL";
                    if (cbGender.SelectedIndex == 1) cbGenderText = "0";
                    else if (cbGender.SelectedIndex == 2) cbGenderText = "1";

                    //Add
                    if (txtUser.Enabled) sqlCommand = new SqlCommand("INSERT INTO ACCOUNT VALUES ('" + txtUser.Text + "', '" + txtPass.Text + "', '" + txtFullName.Text + "', " + cbGenderText + ", '" + txtPhone.Text + "', '" + cbRole.SelectedValue + "')", sqlConnection);
                    //Edit
                    else sqlCommand = new SqlCommand("UPDATE ACCOUNT SET PASSWORD='" + txtPass.Text + "', FULL_NAME='" + txtFullName.Text + "', GENDER=" + cbGenderText + ", PHONE='" + txtPhone.Text + "', ROLE='" + cbRole.SelectedValue + "' WHERE USERNAME='" + txtUser.Text + "'", sqlConnection);

                    sqlConnection.Open();
                    if (sqlCommand.ExecuteNonQuery() > 0) MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Lỗi khi lưu!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sqlConnection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn huỷ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) LoadData();
        }
    }
}
