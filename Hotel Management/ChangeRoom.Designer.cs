namespace Hotel_Management
{
    partial class ChangeRoom
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
            this.pnlRoom = new System.Windows.Forms.Panel();
            this.btnChangeRoom = new System.Windows.Forms.Button();
            this.txtOldPay = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblOldPay = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblOldRoom = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrive = new System.Windows.Forms.Label();
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            this.dtpArrive = new System.Windows.Forms.DateTimePicker();
            this.lblNewRoom = new System.Windows.Forms.Label();
            this.txtNewPay = new System.Windows.Forms.TextBox();
            this.lblNewPay = new System.Windows.Forms.Label();
            this.txtPayDiff = new System.Windows.Forms.TextBox();
            this.lblPayDiff = new System.Windows.Forms.Label();
            this.cbOldRoom = new System.Windows.Forms.ComboBox();
            this.cbNewRoom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pnlRoom
            // 
            this.pnlRoom.AutoScroll = true;
            this.pnlRoom.Location = new System.Drawing.Point(411, 33);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(500, 500);
            this.pnlRoom.TabIndex = 27;
            // 
            // btnChangeRoom
            // 
            this.btnChangeRoom.Location = new System.Drawing.Point(152, 424);
            this.btnChangeRoom.Name = "btnChangeRoom";
            this.btnChangeRoom.Size = new System.Drawing.Size(75, 23);
            this.btnChangeRoom.TabIndex = 26;
            this.btnChangeRoom.Text = "Đổi phòng";
            this.btnChangeRoom.UseVisualStyleBackColor = true;
            this.btnChangeRoom.Click += new System.EventHandler(this.btnChangeRoom_Click);
            // 
            // txtOldPay
            // 
            this.txtOldPay.Location = new System.Drawing.Point(152, 291);
            this.txtOldPay.Name = "txtOldPay";
            this.txtOldPay.ReadOnly = true;
            this.txtOldPay.Size = new System.Drawing.Size(100, 20);
            this.txtOldPay.TabIndex = 25;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(152, 248);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.ReadOnly = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerPhone.TabIndex = 24;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(152, 205);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 23;
            // 
            // lblOldPay
            // 
            this.lblOldPay.AutoSize = true;
            this.lblOldPay.Location = new System.Drawing.Point(38, 295);
            this.lblOldPay.Name = "lblOldPay";
            this.lblOldPay.Size = new System.Drawing.Size(73, 13);
            this.lblOldPay.TabIndex = 21;
            this.lblOldPay.Text = "Thành tiền cũ";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(38, 252);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(77, 13);
            this.lblCustomerPhone.TabIndex = 20;
            this.lblCustomerPhone.Text = "SĐT người đặt";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(38, 209);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(74, 13);
            this.lblCustomerName.TabIndex = 19;
            this.lblCustomerName.Text = "Tên người đặt";
            // 
            // lblOldRoom
            // 
            this.lblOldRoom.AutoSize = true;
            this.lblOldRoom.Location = new System.Drawing.Point(38, 123);
            this.lblOldRoom.Name = "lblOldRoom";
            this.lblOldRoom.Size = new System.Drawing.Size(53, 13);
            this.lblOldRoom.TabIndex = 18;
            this.lblOldRoom.Text = "Phòng cũ";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(38, 80);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(80, 13);
            this.lblDepart.TabIndex = 17;
            this.lblDepart.Text = "Ngày trả phòng";
            // 
            // lblArrive
            // 
            this.lblArrive.AutoSize = true;
            this.lblArrive.Location = new System.Drawing.Point(38, 37);
            this.lblArrive.Name = "lblArrive";
            this.lblArrive.Size = new System.Drawing.Size(84, 13);
            this.lblArrive.TabIndex = 16;
            this.lblArrive.Text = "Ngày đặt phòng";
            // 
            // dtpDepart
            // 
            this.dtpDepart.Location = new System.Drawing.Point(152, 76);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(200, 20);
            this.dtpDepart.TabIndex = 15;
            this.dtpDepart.ValueChanged += new System.EventHandler(this.dtpDepart_ValueChanged);
            // 
            // dtpArrive
            // 
            this.dtpArrive.Location = new System.Drawing.Point(152, 33);
            this.dtpArrive.Name = "dtpArrive";
            this.dtpArrive.Size = new System.Drawing.Size(200, 20);
            this.dtpArrive.TabIndex = 14;
            this.dtpArrive.ValueChanged += new System.EventHandler(this.dtpArrive_ValueChanged);
            // 
            // lblNewRoom
            // 
            this.lblNewRoom.AutoSize = true;
            this.lblNewRoom.Location = new System.Drawing.Point(38, 166);
            this.lblNewRoom.Name = "lblNewRoom";
            this.lblNewRoom.Size = new System.Drawing.Size(57, 13);
            this.lblNewRoom.TabIndex = 28;
            this.lblNewRoom.Text = "Phòng mới";
            // 
            // txtNewPay
            // 
            this.txtNewPay.Location = new System.Drawing.Point(152, 334);
            this.txtNewPay.Name = "txtNewPay";
            this.txtNewPay.ReadOnly = true;
            this.txtNewPay.Size = new System.Drawing.Size(100, 20);
            this.txtNewPay.TabIndex = 31;
            // 
            // lblNewPay
            // 
            this.lblNewPay.AutoSize = true;
            this.lblNewPay.Location = new System.Drawing.Point(38, 338);
            this.lblNewPay.Name = "lblNewPay";
            this.lblNewPay.Size = new System.Drawing.Size(77, 13);
            this.lblNewPay.TabIndex = 30;
            this.lblNewPay.Text = "Thành tiền mới";
            // 
            // txtPayDiff
            // 
            this.txtPayDiff.Location = new System.Drawing.Point(152, 377);
            this.txtPayDiff.Name = "txtPayDiff";
            this.txtPayDiff.ReadOnly = true;
            this.txtPayDiff.Size = new System.Drawing.Size(100, 20);
            this.txtPayDiff.TabIndex = 33;
            // 
            // lblPayDiff
            // 
            this.lblPayDiff.AutoSize = true;
            this.lblPayDiff.Location = new System.Drawing.Point(38, 381);
            this.lblPayDiff.Name = "lblPayDiff";
            this.lblPayDiff.Size = new System.Drawing.Size(61, 13);
            this.lblPayDiff.TabIndex = 32;
            this.lblPayDiff.Text = "Chênh lệch";
            // 
            // cbOldRoom
            // 
            this.cbOldRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOldRoom.FormattingEnabled = true;
            this.cbOldRoom.Location = new System.Drawing.Point(152, 119);
            this.cbOldRoom.Name = "cbOldRoom";
            this.cbOldRoom.Size = new System.Drawing.Size(121, 21);
            this.cbOldRoom.TabIndex = 34;
            this.cbOldRoom.SelectedValueChanged += new System.EventHandler(this.cbOldRoom_SelectedValueChanged);
            // 
            // cbNewRoom
            // 
            this.cbNewRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNewRoom.FormattingEnabled = true;
            this.cbNewRoom.Location = new System.Drawing.Point(152, 162);
            this.cbNewRoom.Name = "cbNewRoom";
            this.cbNewRoom.Size = new System.Drawing.Size(121, 21);
            this.cbNewRoom.TabIndex = 35;
            this.cbNewRoom.SelectedValueChanged += new System.EventHandler(this.cbNewRoom_SelectedValueChanged);
            // 
            // ChangeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 569);
            this.Controls.Add(this.cbNewRoom);
            this.Controls.Add(this.cbOldRoom);
            this.Controls.Add(this.txtPayDiff);
            this.Controls.Add(this.lblPayDiff);
            this.Controls.Add(this.txtNewPay);
            this.Controls.Add(this.lblNewPay);
            this.Controls.Add(this.lblNewRoom);
            this.Controls.Add(this.pnlRoom);
            this.Controls.Add(this.btnChangeRoom);
            this.Controls.Add(this.txtOldPay);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblOldPay);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblOldRoom);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblArrive);
            this.Controls.Add(this.dtpDepart);
            this.Controls.Add(this.dtpArrive);
            this.Name = "ChangeRoom";
            this.Text = "Đổi phòng";
            this.Load += new System.EventHandler(this.ChangeRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRoom;
        private System.Windows.Forms.Button btnChangeRoom;
        private System.Windows.Forms.TextBox txtOldPay;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblOldPay;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblOldRoom;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrive;
        private System.Windows.Forms.DateTimePicker dtpDepart;
        private System.Windows.Forms.DateTimePicker dtpArrive;
        private System.Windows.Forms.Label lblNewRoom;
        private System.Windows.Forms.TextBox txtNewPay;
        private System.Windows.Forms.Label lblNewPay;
        private System.Windows.Forms.TextBox txtPayDiff;
        private System.Windows.Forms.Label lblPayDiff;
        private System.Windows.Forms.ComboBox cbOldRoom;
        private System.Windows.Forms.ComboBox cbNewRoom;
    }
}