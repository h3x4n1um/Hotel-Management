namespace Hotel_Management
{
    partial class BookRoom
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
            this.dtpArrive = new System.Windows.Forms.DateTimePicker();
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            this.lblArrive = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.pnlRoom = new System.Windows.Forms.Panel();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpArrive
            // 
            this.dtpArrive.Location = new System.Drawing.Point(137, 21);
            this.dtpArrive.Name = "dtpArrive";
            this.dtpArrive.Size = new System.Drawing.Size(200, 20);
            this.dtpArrive.TabIndex = 0;
            this.dtpArrive.ValueChanged += new System.EventHandler(this.dtpArrive_ValueChanged);
            // 
            // dtpDepart
            // 
            this.dtpDepart.Location = new System.Drawing.Point(137, 60);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(200, 20);
            this.dtpDepart.TabIndex = 1;
            this.dtpDepart.ValueChanged += new System.EventHandler(this.dtpDepart_ValueChanged);
            // 
            // lblArrive
            // 
            this.lblArrive.AutoSize = true;
            this.lblArrive.Location = new System.Drawing.Point(23, 25);
            this.lblArrive.Name = "lblArrive";
            this.lblArrive.Size = new System.Drawing.Size(84, 13);
            this.lblArrive.TabIndex = 2;
            this.lblArrive.Text = "Ngày đặt phòng";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(23, 64);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(80, 13);
            this.lblDepart.TabIndex = 3;
            this.lblDepart.Text = "Ngày trả phòng";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(23, 103);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(38, 13);
            this.lblRoom.TabIndex = 4;
            this.lblRoom.Text = "Phòng";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(23, 142);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(74, 13);
            this.lblCustomerName.TabIndex = 5;
            this.lblCustomerName.Text = "Tên người đặt";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(23, 181);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(77, 13);
            this.lblCustomerPhone.TabIndex = 6;
            this.lblCustomerPhone.Text = "SĐT người đặt";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(23, 220);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(58, 13);
            this.lblPay.TabIndex = 7;
            this.lblPay.Text = "Thành tiền";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(137, 139);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 9;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(137, 178);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerPhone.TabIndex = 10;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(137, 217);
            this.txtPay.Name = "txtPay";
            this.txtPay.ReadOnly = true;
            this.txtPay.Size = new System.Drawing.Size(100, 20);
            this.txtPay.TabIndex = 11;
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.Location = new System.Drawing.Point(137, 255);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(75, 23);
            this.btnBookRoom.TabIndex = 12;
            this.btnBookRoom.Text = "Đặt phòng";
            this.btnBookRoom.UseVisualStyleBackColor = true;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // pnlRoom
            // 
            this.pnlRoom.AutoScroll = true;
            this.pnlRoom.Location = new System.Drawing.Point(396, 21);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(500, 500);
            this.pnlRoom.TabIndex = 13;
            // 
            // cbRoom
            // 
            this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(137, 99);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(121, 21);
            this.cbRoom.Sorted = true;
            this.cbRoom.TabIndex = 14;
            this.cbRoom.SelectedValueChanged += new System.EventHandler(this.cbRoom_SelectedValueChanged);
            // 
            // BookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 543);
            this.Controls.Add(this.cbRoom);
            this.Controls.Add(this.pnlRoom);
            this.Controls.Add(this.btnBookRoom);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblArrive);
            this.Controls.Add(this.dtpDepart);
            this.Controls.Add(this.dtpArrive);
            this.Name = "BookRoom";
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.BookRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpArrive;
        private System.Windows.Forms.DateTimePicker dtpDepart;
        private System.Windows.Forms.Label lblArrive;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.Panel pnlRoom;
        private System.Windows.Forms.ComboBox cbRoom;
    }
}