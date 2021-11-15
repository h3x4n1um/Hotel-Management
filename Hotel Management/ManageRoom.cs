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
    public partial class ManageRoom : Form
    {
        public ManageRoom()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvRoom.Enabled = true;

            btnAdd.Enabled = true;

            txtRoomId.Enabled = false;
            txtPrice.Enabled = false;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgvRoom.DataSource = dataTable;

                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageRoom_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvRoom_SelectionChanged(object sender, EventArgs e)
        {
            int row = dgvRoom.CurrentCell.RowIndex;

            txtRoomId.Text = Convert.ToString(dgvRoom.Rows[row].Cells["ROOM_ID"].Value);
            txtPrice.Text = Convert.ToString(dgvRoom.Rows[row].Cells["PRICE"].Value);

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvRoom.Enabled = false;

            txtRoomId.Enabled = true;
            txtPrice.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtRoomId.Clear();
            txtPrice.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvRoom.Enabled = false;

            txtPrice.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá phòng " + txtRoomId.Text + "?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM ROOM WHERE ROOM_ID='" + txtRoomId.Text + "'", sqlConnection);

                    sqlConnection.Open();
                    if (sqlCommand.ExecuteNonQuery() > 0) MessageBox.Show("Đã xoá phòng " + txtRoomId.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Lỗi khi xoá phòng " + txtRoomId.Text + "!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (String.IsNullOrEmpty(txtRoomId.Text) || String.IsNullOrEmpty(txtPrice.Text))
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
                    if (txtRoomId.Enabled) sqlCommand = new SqlCommand("INSERT INTO ROOM VALUES ('" + txtRoomId.Text + "', " + txtPrice.Text + ")", sqlConnection);
                    //Edit
                    else sqlCommand = new SqlCommand("UPDATE ROOM SET PRICE=" + txtPrice.Text + " WHERE ROOM_ID='" + txtRoomId.Text + "'", sqlConnection);

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
