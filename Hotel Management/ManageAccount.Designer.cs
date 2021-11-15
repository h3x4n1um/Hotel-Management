namespace Hotel_Management
{
    partial class ManageAccount
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
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULL_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USERNAME,
            this.PASSWORD,
            this.FULL_NAME,
            this.GENDER,
            this.PHONE,
            this.ROLE});
            this.dgvAccount.Location = new System.Drawing.Point(12, 12);
            this.dgvAccount.MultiSelect = false;
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.Size = new System.Drawing.Size(650, 422);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.SelectionChanged += new System.EventHandler(this.dgvAccount_SelectionChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(684, 24);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(81, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Tên đăng nhập";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(684, 58);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(52, 13);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Mật khẩu";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(684, 92);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(82, 13);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Tên người dùng";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(684, 126);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(47, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Giới tính";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(684, 160);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(684, 194);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(47, 13);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Chức vụ";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(783, 20);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(783, 54);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 8;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(783, 89);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(783, 157);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 11;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(783, 122);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 21);
            this.cbGender.TabIndex = 10;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(783, 190);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(121, 21);
            this.cbRole.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(691, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(791, 233);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(891, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(735, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(842, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // USERNAME
            // 
            this.USERNAME.DataPropertyName = "USERNAME";
            this.USERNAME.HeaderText = "Tên đăng nhập";
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ReadOnly = true;
            this.USERNAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PASSWORD
            // 
            this.PASSWORD.DataPropertyName = "PASSWORD";
            this.PASSWORD.HeaderText = "Mật khẩu";
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.ReadOnly = true;
            this.PASSWORD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FULL_NAME
            // 
            this.FULL_NAME.DataPropertyName = "FULL_NAME";
            this.FULL_NAME.HeaderText = "Tên người dùng";
            this.FULL_NAME.Name = "FULL_NAME";
            this.FULL_NAME.ReadOnly = true;
            this.FULL_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GENDER
            // 
            this.GENDER.DataPropertyName = "GENDER";
            this.GENDER.HeaderText = "Giới tính";
            this.GENDER.Name = "GENDER";
            this.GENDER.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "PHONE";
            this.PHONE.HeaderText = "Số điện thoại";
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            this.PHONE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ROLE
            // 
            this.ROLE.DataPropertyName = "ROLE";
            this.ROLE.HeaderText = "Chức vụ";
            this.ROLE.Name = "ROLE";
            this.ROLE.ReadOnly = true;
            // 
            // ManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 447);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dgvAccount);
            this.Name = "ManageAccount";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULL_NAME;
        private System.Windows.Forms.DataGridViewComboBoxColumn GENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewComboBoxColumn ROLE;
    }
}