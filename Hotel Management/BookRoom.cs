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
    public partial class BookRoom : Form
    {
        private const string sqlDateFormat = "yyyyMMdd";
        private const string showDateFormat = "dd/MM/yyyy";
        public BookRoom()
        {
            InitializeComponent();
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbRoom.Text) || String.IsNullOrEmpty(txtCustomerName.Text) || String.IsNullOrEmpty(txtCustomerPhone.Text) || String.IsNullOrEmpty(txtPay.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        "ROOM_ID = '" + cbRoom.Text + "' AND " +
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
                    MessageBox.Show("Phòng " + cbRoom.Text + " đã được đặt trong thời gian từ " + Convert.ToDateTime(sqlDataReader["ARRIVE"]).ToString(showDateFormat) + " đến " + Convert.ToDateTime(sqlDataReader["DEPART"]).ToString(showDateFormat) + "!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sqlConnection.Close();

                sqlCommand = new SqlCommand("INSERT INTO BOOKING(ROOM_ID, ARRIVE, DEPART, CUSTOMER_NAME, CUSTOMER_PHONE, PAY) VALUES ('" + cbRoom.Text + "', '" + dtpArrive.Value.ToString(sqlDateFormat) + "', '" + dtpDepart.Value.ToString(sqlDateFormat) + "', '" + txtCustomerName.Text + "', '" + txtCustomerPhone.Text + "', " + txtPay.Text + ")", sqlConnection);

                sqlConnection.Open();
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đặt phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoomState();
                }
                else MessageBox.Show("Đặt phòng lỗi!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpDepart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDepart.Value < dtpArrive.Value)
            {
                MessageBox.Show("Ngày trả phòng phải sau ngày đặt phòng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDepart.Value = dtpArrive.Value;
            }

            LoadRoomState();
        }

        private void dtpArrive_ValueChanged(object sender, EventArgs e)
        {
            if (dtpArrive.Value < DateTime.Today)
            {
                MessageBox.Show("Ngày đặt phòng phải bắt đầu từ hôm nay!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpArrive.Value = DateTime.Today;
            }

            if (dtpArrive.Value > dtpDepart.Value) dtpDepart.Value = dtpArrive.Value;

            LoadRoomState();
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
                    button.Text = "Phòng: " + roomId;
                    button.Tag = roomId;
                    button.Size = new System.Drawing.Size(spaceBtn, spaceBtn);
                    button.Location = new System.Drawing.Point(xBtn, yBtn);
                    button.Click += (s, args) => cbRoom.Text = roomId;

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

        private void BookRoom_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel Management"].ConnectionString);

                SqlCommand sqlCommand = new SqlCommand("SELECT ROOM_ID FROM ROOM", sqlConnection);

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read()) cbRoom.Items.Add(sqlDataReader["ROOM_ID"]);
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dtpArrive.Value = DateTime.Today;
            dtpDepart.Value = DateTime.Now;
        }

        private void cbRoom_SelectedValueChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbRoom.Text))
            {
                txtPay.Clear();
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
                        "ROOM_ID = '" + cbRoom.Text + "' AND " +
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
                    MessageBox.Show("Phòng " + cbRoom.Text + " đã được đặt trong thời gian từ " + Convert.ToDateTime(sqlDataReader["ARRIVE"]).ToString(showDateFormat) + " đến " + Convert.ToDateTime(sqlDataReader["DEPART"]).ToString(showDateFormat) + "!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbRoom.SelectedIndex = -1;
                }
                else
                {
                    sqlConnection.Close();

                    sqlCommand = new SqlCommand("SELECT PRICE FROM ROOM WHERE ROOM_ID = '" + cbRoom.Text + "'", sqlConnection);
                    sqlConnection.Open();
                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.Read()) txtPay.Text = Convert.ToString(Convert.ToInt32(sqlDataReader["PRICE"]) * (dtpDepart.Value.Subtract(dtpArrive.Value).Days + 1));
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
