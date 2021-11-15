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
    public partial class ManageRole : Form
    {
        public ManageRole()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvRole.Enabled = true;

            btnAdd.Enabled = true;

            txtRole.Enabled = false;
            txtRoleName.Enabled = false;

            chbManager.Enabled = false;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROLE", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgvRole.DataSource = dataTable;

                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageRole_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvRole_SelectionChanged(object sender, EventArgs e)
        {
            int row = dgvRole.CurrentCell.RowIndex;

            txtRole.Text = Convert.ToString(dgvRole.Rows[row].Cells["ROLE"].Value);
            txtRoleName.Text = Convert.ToString(dgvRole.Rows[row].Cells["ROLE_NAME"].Value);

            chbManager.Checked = Convert.ToBoolean(dgvRole.Rows[row].Cells["MANAGER"].Value);

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvRole.Enabled = false;

            txtRole.Enabled = true;
            txtRoleName.Enabled = true;

            chbManager.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtRole.Clear();
            txtRoleName.Clear();

            chbManager.Checked = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvRole.Enabled = false;

            txtRoleName.Enabled = true;

            chbManager.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá chức vụ " + txtRole.Text + "?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM ROLE WHERE ROLE='" + txtRole.Text + "'", sqlConnection);

                    sqlConnection.Open();
                    if (sqlCommand.ExecuteNonQuery() > 0) MessageBox.Show("Đã xoá chức vụ " + txtRole.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Lỗi khi xoá chức vụ " + txtRole.Text + "!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (String.IsNullOrEmpty(txtRole.Text) || String.IsNullOrEmpty(txtRoleName.Text))
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

                    //Add
                    if (txtRole.Enabled) sqlCommand = new SqlCommand("INSERT INTO ROLE VALUES ('" + txtRole.Text + "', '" + txtRoleName.Text + "', " + Convert.ToInt32(chbManager.Checked) + ")", sqlConnection);
                    //Edit
                    else sqlCommand = new SqlCommand("UPDATE ROLE SET ROLE_NAME='" + txtRoleName.Text + "', MANAGER=" + Convert.ToInt32(chbManager.Checked) + " WHERE ROLE='" + txtRole.Text + "'", sqlConnection);

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
