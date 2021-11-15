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
    public partial class ManageBooking : Form
    {
        public ManageBooking()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvBooking.Enabled = true;

            btnAdd.Enabled = true;

            txtId.Enabled = false;
            txtCustomerName.Enabled = false;
            txtCustomerPhone.Enabled = false;
            txtPay.Enabled = false;

            cbRoomId.Enabled = false;

            dtpArrive.Enabled = false;
            dtpDepart.Enabled = false;

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
                (dgvBooking.Columns["ROOM_ID"] as DataGridViewComboBoxColumn).ValueMember = "ROOM_ID";
                (dgvBooking.Columns["ROOM_ID"] as DataGridViewComboBoxColumn).DisplayMember = "ROOM_ID";
                (dgvBooking.Columns["ROOM_ID"] as DataGridViewComboBoxColumn).DataSource = dataTable;

                cbRoomId.ValueMember = "ROOM_ID";
                cbRoomId.DisplayMember = "ROOM_ID";
                cbRoomId.DataSource = dataTable;

                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM BOOKING", sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgvBooking.DataSource = dataTable;

                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageBooking_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvAccount_SelectionChanged(object sender, EventArgs e)
        {
            int row = dgvBooking.CurrentCell.RowIndex;

            txtId.Text = Convert.ToString(dgvBooking.Rows[row].Cells["ID"].Value);
            txtCustomerName.Text = Convert.ToString(dgvBooking.Rows[row].Cells["CUSTOMER_NAME"].Value);
            txtCustomerPhone.Text = Convert.ToString(dgvBooking.Rows[row].Cells["CUSTOMER_PHONE"].Value);
            txtPay.Text = Convert.ToString(dgvBooking.Rows[row].Cells["PAY"].Value);

            cbRoomId.SelectedValue = dgvBooking.Rows[row].Cells["ROOM_ID"].Value;

            dtpArrive.Value = Convert.ToDateTime(dgvBooking.Rows[row].Cells["ARRIVE"].Value);
            dtpDepart.Value = Convert.ToDateTime(dgvBooking.Rows[row].Cells["DEPART"].Value);

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void dtpDepart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDepart.Value < dtpArrive.Value)
            {
                MessageBox.Show("Ngày trả phòng phải sau ngày đặt phòng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDepart.Value = dtpArrive.Value;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvBooking.Enabled = false;

            txtId.Enabled = true;
            txtCustomerName.Enabled = true;
            txtCustomerPhone.Enabled = true;
            txtPay.Enabled = true;

            cbRoomId.Enabled = true;

            dtpArrive.Enabled = true;
            dtpDepart.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtId.Clear();
            txtId.ReadOnly = true;
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            txtPay.Clear();

            cbRoomId.SelectedIndex = -1;

            dtpArrive.Value = DateTime.Today;
            dtpDepart.Value = DateTime.Now;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvBooking.Enabled = false;

            txtCustomerName.Enabled = true;
            txtCustomerPhone.Enabled = true;
            txtPay.Enabled = true;

            cbRoomId.Enabled = true;

            dtpArrive.Enabled = true;
            dtpDepart.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá lịch đặt " + txtId.Text + "?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM BOOKING WHERE ID=" + txtId.Text, sqlConnection);

                    sqlConnection.Open();
                    if (sqlCommand.ExecuteNonQuery() > 0) MessageBox.Show("Đã xoá lịch đặt " + txtId.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Lỗi khi xoá lịch đặt " + txtId.Text + "!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (String.IsNullOrEmpty(txtCustomerName.Text) || String.IsNullOrEmpty(txtCustomerPhone.Text) || String.IsNullOrEmpty(txtPay.Text) || cbRoomId.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có muốn lưu?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    const string sqlDateFormat = "yyyyMMdd";

                    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                    SqlCommand sqlCommand = new SqlCommand();

                    //Add
                    if (txtId.Enabled) sqlCommand = new SqlCommand("INSERT INTO BOOKING (ROOM_ID, ARRIVE, DEPART, CUSTOMER_NAME, CUSTOMER_PHONE, PAY) VALUES ('" + cbRoomId.Text + "', '" + dtpArrive.Value.ToString(sqlDateFormat) + "', '" + dtpDepart.Value.ToString(sqlDateFormat) + "', '" + txtCustomerName.Text + "', '" + txtCustomerPhone.Text + "', " + txtPay.Text + ")", sqlConnection);
                    //Edit
                    else sqlCommand = new SqlCommand("UPDATE BOOKING SET ROOM_ID='" + cbRoomId.Text + "', ARRIVE='" + dtpArrive.Value.ToString(sqlDateFormat) + "', DEPART='" + dtpDepart.Value.ToString(sqlDateFormat) + "', CUSTOMER_NAME='" + txtCustomerName.Text + "', CUSTOMER_PHONE='" + txtCustomerPhone.Text + "', PAY=" + txtPay.Text + " WHERE ID=" + txtId.Text, sqlConnection);

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
