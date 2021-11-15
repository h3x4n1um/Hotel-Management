namespace Hotel_Management
{
    partial class ManageRole
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
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANAGER = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chbManager = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRole
            // 
            this.dgvRole.AllowUserToAddRows = false;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ROLE,
            this.ROLE_NAME,
            this.MANAGER});
            this.dgvRole.Location = new System.Drawing.Point(12, 12);
            this.dgvRole.MultiSelect = false;
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.ReadOnly = true;
            this.dgvRole.Size = new System.Drawing.Size(350, 350);
            this.dgvRole.TabIndex = 0;
            this.dgvRole.SelectionChanged += new System.EventHandler(this.dgvRole_SelectionChanged);
            // 
            // ROLE
            // 
            this.ROLE.DataPropertyName = "ROLE";
            this.ROLE.HeaderText = "Mã chức vụ";
            this.ROLE.Name = "ROLE";
            this.ROLE.ReadOnly = true;
            this.ROLE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ROLE_NAME
            // 
            this.ROLE_NAME.DataPropertyName = "ROLE_NAME";
            this.ROLE_NAME.HeaderText = "Chức vụ";
            this.ROLE_NAME.Name = "ROLE_NAME";
            this.ROLE_NAME.ReadOnly = true;
            this.ROLE_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MANAGER
            // 
            this.MANAGER.DataPropertyName = "MANAGER";
            this.MANAGER.HeaderText = "Quyền quản lý";
            this.MANAGER.Name = "MANAGER";
            this.MANAGER.ReadOnly = true;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(493, 51);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(100, 20);
            this.txtRoleName.TabIndex = 4;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(493, 17);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 20);
            this.txtRole.TabIndex = 3;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(394, 55);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(47, 13);
            this.lblRoleName.TabIndex = 2;
            this.lblRoleName.Text = "Chức vụ";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(394, 21);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(64, 13);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Mã chức vụ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(531, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(424, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(580, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(480, 118);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(380, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chbManager
            // 
            this.chbManager.AutoSize = true;
            this.chbManager.Location = new System.Drawing.Point(493, 86);
            this.chbManager.Name = "chbManager";
            this.chbManager.Size = new System.Drawing.Size(94, 17);
            this.chbManager.TabIndex = 5;
            this.chbManager.Text = "Quyền quản lý";
            this.chbManager.UseVisualStyleBackColor = true;
            // 
            // ManageRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 376);
            this.Controls.Add(this.chbManager);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.dgvRole);
            this.Name = "ManageRole";
            this.Text = "Quản lý chức vụ";
            this.Load += new System.EventHandler(this.ManageRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chbManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLE_NAME;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MANAGER;
    }
}