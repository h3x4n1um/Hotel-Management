namespace Hotel_Management
{
    partial class Profit
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
            this.lblArrive = new System.Windows.Forms.Label();
            this.dtpArrive = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            this.dgvProfit = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROOM_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ARRIVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPART = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArrive
            // 
            this.lblArrive.AutoSize = true;
            this.lblArrive.Location = new System.Drawing.Point(24, 36);
            this.lblArrive.Name = "lblArrive";
            this.lblArrive.Size = new System.Drawing.Size(51, 13);
            this.lblArrive.TabIndex = 0;
            this.lblArrive.Text = "Ngày đặt";
            // 
            // dtpArrive
            // 
            this.dtpArrive.Location = new System.Drawing.Point(81, 32);
            this.dtpArrive.Name = "dtpArrive";
            this.dtpArrive.Size = new System.Drawing.Size(200, 20);
            this.dtpArrive.TabIndex = 1;
            this.dtpArrive.ValueChanged += new System.EventHandler(this.dtpArrive_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày trả";
            // 
            // dtpDepart
            // 
            this.dtpDepart.Location = new System.Drawing.Point(577, 32);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(200, 20);
            this.dtpDepart.TabIndex = 3;
            this.dtpDepart.ValueChanged += new System.EventHandler(this.dtpDepart_ValueChanged);
            // 
            // dgvProfit
            // 
            this.dgvProfit.AllowUserToAddRows = false;
            this.dgvProfit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ROOM_ID,
            this.ARRIVE,
            this.DEPART,
            this.CUSTOMER_NAME,
            this.CUSTOMER_PHONE,
            this.PAY});
            this.dgvProfit.Location = new System.Drawing.Point(27, 63);
            this.dgvProfit.MultiSelect = false;
            this.dgvProfit.Name = "dgvProfit";
            this.dgvProfit.ReadOnly = true;
            this.dgvProfit.Size = new System.Drawing.Size(750, 375);
            this.dgvProfit.TabIndex = 4;
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
            // Profit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProfit);
            this.Controls.Add(this.dtpDepart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpArrive);
            this.Controls.Add(this.lblArrive);
            this.Name = "Profit";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.Profit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArrive;
        private System.Windows.Forms.DateTimePicker dtpArrive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDepart;
        private System.Windows.Forms.DataGridView dgvProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ROOM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARRIVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPART;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAY;
    }
}