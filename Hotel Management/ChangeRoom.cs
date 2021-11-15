using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Hotel_Management
{
    public partial class ChangeRoom : Form
    {
        private const string sqlDateFormat = "yyyyMMdd";
        private const string showDateFormat = "dd/MM/yyyy";

        public ChangeRoom()
        {
            InitializeComponent();
        }

        private void LoadRoomState()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM ROOM", sqlConnection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                int roomCount = dataTable.Rows.Count;
                int roomEdgeBtn = Convert.ToInt32(Math.Ceiling(Math.Sqrt(Convert.ToDouble(roomCount))));

                int xBtn = 0;
                int yBtn = 0;
                int spaceBtn = 100;

                string sqlArriveCompare = dtpArrive.Value.ToString(sqlDateFormat);
                string sqlDepartCompare = dtpDepart.Value.ToString(sqlDateFormat);
                pnlRoom.Controls.Clear();
                for (int i = 0; i < roomCount; ++i)
                {
                    DataRow dataRow = dataTable.Rows[i];

                    string roomId = Convert.ToString(dataRow["ROOM_ID"]);

                    Button button = new Button();
                    button.Text = "Phòng: " + Convert.ToString(dataRow["ROOM_ID"]);
                    button.Tag = roomId;
                    button.Size = new System.Drawing.Size(spaceBtn, spaceBtn);
                    button.Location = new System.Drawing.Point(xBtn, yBtn);
                    button.Click += (s, args) => cbOldRoom.Text = roomId;

                    SqlCommand sqlCommand = new SqlCommand(
                        "SELECT " +
                            "ROOM_ID, " +
                            "ARRIVE, " +
                            "DEPART " +
                        "FROM " +
                            "BOOKING " +
                        "WHERE " +
                            "ROOM_ID = '" + roomId + "' AND " +
                            "(" +
                                "'" + sqlArriveCompare + "' BETWEEN ARRIVE AND DEPART OR " +
                                "'" + sqlDepartCompare + "' BETWEEN ARRIVE AND DEPART OR " +
                                "ARRIVE BETWEEN '" + sqlArriveCompare + "' AND '" + sqlDepartCompare + "' OR " +
                                "DEPART BETWEEN '" + sqlArriveCompare + "' AND '" + sqlDepartCompare + "'" +
                            ")",
                        sqlConnection
                    );

                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        DateTime sqlArrive = Convert.ToDateTime(sqlDataReader["ARRIVE"]);
                        DateTime sqlDepart = Convert.ToDateTime(sqlDataReader["DEPART"]);

                        button.Text += "\nĐã được đặt" +
                                       "\nTừ: " + sqlArrive.ToString(showDateFormat) +
                                       "\nĐến: " + sqlDepart.ToString(showDateFormat);
                        button.BackColor = Color.FromName("HotPink");
                        button.Click += (s, args) =>
                        {
                            dtpArrive.Value = sqlArrive;
                            dtpDepart.Value = sqlDepart;
                        };
                    }
                    else
                    {
                        button.Text += "\nGiá: " + Convert.ToString(Convert.ToInt32(dataRow["PRICE"]) / 1000) + 'k';
                        button.BackColor = Color.FromName("LightGreen");
                    }
                    sqlConnection.Close();

                    pnlRoom.Controls.Add(button);

                    if ((i + 1) % roomEdgeBtn == 0)
                    {
                        xBtn = 0;
                        yBtn += spaceBtn;
                    }
                    else xBtn += spaceBtn;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeRoom_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                SqlCommand sqlCommand = new SqlCommand("SELECT ROOM_ID FROM ROOM", sqlConnection);

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    cbOldRoom.Items.Add(sqlDataReader["ROOM_ID"]);
                    cbNewRoom.Items.Add(sqlDataReader["ROOM_ID"]);
                }
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dtpArrive.Value = DateTime.Today;
        }

        private void cbOldRoom_SelectedValueChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbOldRoom.Text))
            {
                txtCustomerName.Clear();
                txtCustomerPhone.Clear();
                txtOldPay.Clear();
                lblPayDiff.Text = "Chênh lệch";
                txtPayDiff.Clear();
                return;
            }

            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                SqlCommand sqlCommand = new SqlCommand(
                    "SELECT " +
                        "ROOM_ID, " +
                        "CUSTOMER_NAME, " +
                        "CUSTOMER_PHONE, " +
                        "PAY " +
                    "FROM " +
                        "BOOKING " +
                    "WHERE " +
                        "ROOM_ID = '" + cbOldRoom.Text + "' AND " +
                        "ARRIVE = '" + dtpArrive.Value.ToString(sqlDateFormat) + "' AND " +
                        "DEPART = '" + dtpDepart.Value.ToString(sqlDateFormat) + "'",
                    sqlConnection
                );

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    txtCustomerName.Text = Convert.ToString(sqlDataReader["CUSTOMER_NAME"]);
                    txtCustomerPhone.Text = Convert.ToString(sqlDataReader["CUSTOMER_PHONE"]);
                    txtOldPay.Text = Convert.ToString(sqlDataReader["PAY"]);
                }
                else
                {
                    MessageBox.Show("Phòng " + cbOldRoom.Text + " không được đặt trong thời gian từ " + dtpArrive.Value.ToString(showDateFormat) + " đền " + dtpDepart.Value.ToString(showDateFormat) + "!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbOldRoom.SelectedIndex = -1;
                }
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpArrive_ValueChanged(object sender, EventArgs e)
        {
            if (dtpArrive.Value > dtpDepart.Value) dtpDepart.Value = dtpArrive.Value;

            LoadRoomState();
        }

        private void dtpDepart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDepart.Value < dtpArrive.Value)
            {
                MessageBox.Show("Ngày trả phòng phải sau ngày đặt phòng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDepart.Value = dtpArrive.Value;
            }

            if (dtpDepart.Value < DateTime.Today)
            {
                MessageBox.Show("Chỉ có thể sửa những phòng đang sử dụng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDepart.Value = DateTime.Today;
            }

            LoadRoomState();
        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbOldRoom.Text) || String.IsNullOrEmpty(cbNewRoom.Text) || String.IsNullOrEmpty(txtCustomerName.Text) || String.IsNullOrEmpty(txtCustomerPhone.Text) || String.IsNullOrEmpty(txtOldPay.Text) || String.IsNullOrEmpty(txtNewPay.Text) || String.IsNullOrEmpty(txtPayDiff.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                SqlCommand sqlCommand = new SqlCommand(
                    "SELECT " +
                        "ID " +
                    "FROM " +
                        "BOOKING " +
                    "WHERE " +
                        "ROOM_ID = '" + cbOldRoom.Text + "' AND " +
                        "ARRIVE = '" + dtpArrive.Value.ToString(sqlDateFormat) + "' AND " +
                        "DEPART = '" + dtpDepart.Value.ToString(sqlDateFormat) + "' AND " +
                        "CUSTOMER_PHONE = '" + txtCustomerPhone.Text + "' AND " +
                        "PAY = " + txtOldPay.Text,
                    sqlConnection
                );

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    string id = Convert.ToString(sqlDataReader["ID"]);
                    sqlConnection.Close();

                    sqlCommand = new SqlCommand("UPDATE BOOKING SET ROOM_ID = '" + cbNewRoom.Text + "', PAY = " + txtNewPay.Text + " WHERE ID = " + id, sqlConnection);

                    sqlConnection.Open();
                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đổi phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRoomState();
                    }
                    else MessageBox.Show("Lỗi khi đổi phòng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Lỗi khi tìm phòng đổi!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbNewRoom_SelectedValueChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbNewRoom.Text))
            {
                txtNewPay.Clear();
                lblPayDiff.Text = "Chênh lệch";
                txtPayDiff.Clear();
                return;
            }

            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                string sqlArriveCompare = dtpArrive.Value.ToString(sqlDateFormat);
                string sqlDepartCompare = dtpDepart.Value.ToString(sqlDateFormat);

                SqlCommand sqlCommand = new SqlCommand(
                    "SELECT " +
                        "ROOM_ID, " +
                        "ARRIVE, " +
                        "DEPART " +
                    "FROM " +
                        "BOOKING " +
                    "WHERE " +
                        "ROOM_ID = '" + cbNewRoom.Text + "' AND " +
                        "(" +
                            "'" + sqlArriveCompare + "' BETWEEN ARRIVE AND DEPART OR " +
                            "'" + sqlDepartCompare + "' BETWEEN ARRIVE AND DEPART OR " +
                            "ARRIVE BETWEEN '" + sqlArriveCompare + "' AND '" + sqlDepartCompare + "' OR " +
                            "DEPART BETWEEN '" + sqlArriveCompare + "' AND '" + sqlDepartCompare + "'" +
                        ")",
                    sqlConnection
                );

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    MessageBox.Show("Phòng " + cbNewRoom.Text + " đã được đặt trong thời gian từ " + Convert.ToDateTime(sqlDataReader["ARRIVE"]).ToString(showDateFormat) + " đến " + Convert.ToDateTime(sqlDataReader["DEPART"]).ToString(showDateFormat) + "!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbNewRoom.SelectedIndex = -1;
                }
                else
                {
                    sqlConnection.Close();

                    sqlCommand = new SqlCommand("SELECT PRICE FROM ROOM WHERE ROOM_ID = '" + cbNewRoom.Text + "'", sqlConnection);
                    sqlConnection.Open();
                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.Read()) txtNewPay.Text = Convert.ToString(Convert.ToInt32(sqlDataReader["PRICE"]) * (dtpDepart.Value.Subtract(dtpArrive.Value).Days + 1));

                    int oldPay = Convert.ToInt32(txtOldPay.Text);
                    int newPay = Convert.ToInt32(txtNewPay.Text);
                    int payDiff = newPay - oldPay;

                    if (payDiff < 0)
                    {
                        lblPayDiff.Text = "Trả khách";
                        payDiff *= -1;
                    }
                    else lblPayDiff.Text = "Thu khách";

                    txtPayDiff.Text = payDiff.ToString();
                }
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
