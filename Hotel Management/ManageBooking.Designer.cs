namespace Hotel_Management
{
    partial class ManageBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbRoomId = new System.Windows.Forms.ComboBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrive = new System.Windows.Forms.Label();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROOM_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ARRIVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPART = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPay = new System.Windows.Forms.Label();
            this.dtpArrive = new System.Windows.Forms.DateTimePicker();
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(955, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(848, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1004, 262);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(904, 262);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(804, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbRoomId
            // 
            this.cbRoomId.FormattingEnabled = true;
            this.cbRoomId.Location = new System.Drawing.Point(886, 53);
            this.cbRoomId.Name = "cbRoomId";
            this.cbRoomId.Size = new System.Drawing.Size(121, 21);
            this.cbRoomId.TabIndex = 9;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(886, 223);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(100, 20);
            this.txtPay.TabIndex = 14;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(886, 155);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 12;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(886, 189);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerPhone.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(886, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 8;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(787, 193);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(77, 13);
            this.lblCustomerPhone.TabIndex = 6;
            this.lblCustomerPhone.Text = "SĐT người đặt";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(787, 159);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(54, 13);
            this.lblCustomerName.TabIndex = 5;
            this.lblCustomerName.Text = "Người đặt";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(787, 125);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(47, 13);
            this.lblDepart.TabIndex = 4;
            this.lblDepart.Text = "Ngày trả";
            // 
            // lblArrive
            // 
            this.lblArrive.AutoSize = true;
            this.lblArrive.Location = new System.Drawing.Point(787, 91);
            this.lblArrive.Name = "lblArrive";
            this.lblArrive.Size = new System.Drawing.Size(51, 13);
            this.lblArrive.TabIndex = 3;
            this.lblArrive.Text = "Ngày đặt";
            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Location = new System.Drawing.Point(787, 57);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(38, 13);
            this.lblRoomId.TabIndex = 2;
            this.lblRoomId.Text = "Phòng";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(787, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ROOM_ID,
            this.ARRIVE,
            this.DEPART,
            this.CUSTOMER_NAME,
            this.CUSTOMER_PHONE,
            this.PAY});
            this.dgvBooking.Location = new System.Drawing.Point(12, 12);
            this.dgvBooking.MultiSelect = false;
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.Size = new System.Drawing.Size(750, 375);
            this.dgvBooking.TabIndex = 0;
            this.dgvBooking.SelectionChanged += new System.EventHandler(this.dgvAccount_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ROOM_ID
            // 
            this.ROOM_ID.DataPropertyName = "ROOM_ID";
            this.ROOM_ID.HeaderText = "Phòng";
            this.ROOM_ID.Name = "ROOM_ID";
            this.ROOM_ID.ReadOnly = true;
            this.ROOM_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ARRIVE
            // 
            this.ARRIVE.DataPropertyName = "ARRIVE";
            this.ARRIVE.HeaderText = "Ngày đặt";
            this.ARRIVE.Name = "ARRIVE";
            this.ARRIVE.ReadOnly = true;
            this.ARRIVE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DEPART
            // 
            this.DEPART.DataPropertyName = "DEPART";
            this.DEPART.HeaderText = "Ngày trả";
            this.DEPART.Name = "DEPART";
            this.DEPART.ReadOnly = true;
            this.DEPART.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DEPART.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CUSTOMER_NAME
            // 
            this.CUSTOMER_NAME.DataPropertyName = "CUSTOMER_NAME";
            this.CUSTOMER_NAME.HeaderText = "Người đặt";
            this.CUSTOMER_NAME.Name = "CUSTOMER_NAME";
            this.CUSTOMER_NAME.ReadOnly = true;
            this.CUSTOMER_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CUSTOMER_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CUSTOMER_PHONE
            // 
            this.CUSTOMER_PHONE.DataPropertyName = "CUSTOMER_PHONE";
            this.CUSTOMER_PHONE.HeaderText = "SĐT người đặt";
            this.CUSTOMER_PHONE.Name = "CUSTOMER_PHONE";
            this.CUSTOMER_PHONE.ReadOnly = true;
            this.CUSTOMER_PHONE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PAY
            // 
            this.PAY.DataPropertyName = "PAY";
            this.PAY.HeaderText = "Thành tiền";
            this.PAY.Name = "PAY";
            this.PAY.ReadOnly = true;
            this.PAY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(787, 227);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(58, 13);
            this.lblPay.TabIndex = 7;
            this.lblPay.Text = "Thành tiền";
            // 
            // dtpArrive
            // 
            this.dtpArrive.Location = new System.Drawing.Point(886, 87);
            this.dtpArrive.Name = "dtpArrive";
            this.dtpArrive.Size = new System.Drawing.Size(200, 20);
            this.dtpArrive.TabIndex = 10;
            // 
            // dtpDepart
            // 
            this.dtpDepart.Location = new System.Drawing.Point(886, 121);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(200, 20);
            this.dtpDepart.TabIndex = 11;
            this.dtpDepart.ValueChanged += new System.EventHandler(this.dtpDepart_ValueChanged);
            // 
            // ManageBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 403);
            this.Controls.Add(this.dtpDepart);
            this.Controls.Add(this.dtpArrive);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbRoomId);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblArrive);
            this.Controls.Add(this.lblRoomId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvBooking);
            this.Name = "ManageBooking";
            this.Text = "Quản lý lịch đặt phòng";
            this.Load += new System.EventHandler(this.ManageBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbRoomId;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrive;
        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ROOM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARRIVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPART;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAY;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.DateTimePicker dtpArrive;
        private System.Windows.Forms.DateTimePicker dtpDepart;
    }
}