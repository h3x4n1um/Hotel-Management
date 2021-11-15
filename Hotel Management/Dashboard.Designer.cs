namespace Hotel_Management
{
    partial class frmDashboard
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
            this.lblUserDesc = new System.Windows.Forms.Label();
            this.lblRoleDesc = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsmUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBookRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangeRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProfit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageRole = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageBooking = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserDesc
            // 
            this.lblUserDesc.AutoSize = true;
            this.lblUserDesc.Location = new System.Drawing.Point(629, 402);
            this.lblUserDesc.Name = "lblUserDesc";
            this.lblUserDesc.Size = new System.Drawing.Size(65, 13);
            this.lblUserDesc.TabIndex = 0;
            this.lblUserDesc.Text = "Người dùng:";
            // 
            // lblRoleDesc
            // 
            this.lblRoleDesc.AutoSize = true;
            this.lblRoleDesc.Location = new System.Drawing.Point(644, 428);
            this.lblRoleDesc.Name = "lblRoleDesc";
            this.lblRoleDesc.Size = new System.Drawing.Size(50, 13);
            this.lblRoleDesc.TabIndex = 1;
            this.lblRoleDesc.Text = "Chức vụ:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(700, 402);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(88, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User Placeholder";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(700, 428);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(88, 13);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Role Placeholder";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(295, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "CHƯƠNG TRÌNH QUẢN LÝ KHÁCH SẠN";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(270, 68);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(256, 13);
            this.lblCourse.TabIndex = 7;
            this.lblCourse.Text = "Học phần: Phát triển ứng dụng trên Windows CT251";
            // 
            // ptbLogo
            // 
            this.ptbLogo.ImageLocation = "img/Can_Tho_University_Logo.png";
            this.ptbLogo.Location = new System.Drawing.Point(322, 123);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(152, 138);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 8;
            this.ptbLogo.TabStop = false;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(284, 278);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(229, 26);
            this.lblAuthor.TabIndex = 9;
            this.lblAuthor.Text = "Sinh viên thực hiện: Nguyễn Thanh Hoàng Hải\r\nMSSV: B1812339";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Giảng viên: Nguyễn Công Danh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsmUser
            // 
            this.tsmUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmChangePass,
            this.tsmUserInfo,
            this.tsmLogOut});
            this.tsmUser.Name = "tsmUser";
            this.tsmUser.Size = new System.Drawing.Size(69, 20);
            this.tsmUser.Text = "Tài khoản";
            // 
            // tsmChangePass
            // 
            this.tsmChangePass.Name = "tsmChangePass";
            this.tsmChangePass.Size = new System.Drawing.Size(177, 22);
            this.tsmChangePass.Text = "Đổi mật khẩu";
            this.tsmChangePass.Click += new System.EventHandler(this.tsmChangePass_Click);
            // 
            // tsmUserInfo
            // 
            this.tsmUserInfo.Name = "tsmUserInfo";
            this.tsmUserInfo.Size = new System.Drawing.Size(177, 22);
            this.tsmUserInfo.Text = "Thông tin tài khoản";
            this.tsmUserInfo.Click += new System.EventHandler(this.tsmUserInfo_Click);
            // 
            // tsmLogOut
            // 
            this.tsmLogOut.Name = "tsmLogOut";
            this.tsmLogOut.Size = new System.Drawing.Size(177, 22);
            this.tsmLogOut.Text = "Đăng xuất";
            this.tsmLogOut.Click += new System.EventHandler(this.tsmLogOut_Click);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUser,
            this.tsmFunction,
            this.tsmManage});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 24);
            this.msMenu.TabIndex = 5;
            this.msMenu.Text = "Menu";
            // 
            // tsmFunction
            // 
            this.tsmFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBookRoom,
            this.tsmChangeRoom,
            this.tsmProfit});
            this.tsmFunction.Name = "tsmFunction";
            this.tsmFunction.Size = new System.Drawing.Size(77, 20);
            this.tsmFunction.Text = "Chức năng";
            // 
            // tsmBookRoom
            // 
            this.tsmBookRoom.Name = "tsmBookRoom";
            this.tsmBookRoom.Size = new System.Drawing.Size(130, 22);
            this.tsmBookRoom.Text = "Đặt phòng";
            this.tsmBookRoom.Click += new System.EventHandler(this.tsmBookRoom_Click);
            // 
            // tsmChangeRoom
            // 
            this.tsmChangeRoom.Name = "tsmChangeRoom";
            this.tsmChangeRoom.Size = new System.Drawing.Size(130, 22);
            this.tsmChangeRoom.Text = "Đổi phòng";
            this.tsmChangeRoom.Click += new System.EventHandler(this.tsmChangeRoom_Click);
            // 
            // tsmProfit
            // 
            this.tsmProfit.Name = "tsmProfit";
            this.tsmProfit.Size = new System.Drawing.Size(180, 22);
            this.tsmProfit.Text = "Thống kê";
            this.tsmProfit.Click += new System.EventHandler(this.tsmProfit_Click);
            // 
            // tsmManage
            // 
            this.tsmManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManageAccount,
            this.tsmManageRole,
            this.tsmManageRoom,
            this.tsmManageBooking});
            this.tsmManage.Name = "tsmManage";
            this.tsmManage.Size = new System.Drawing.Size(60, 20);
            this.tsmManage.Text = "Quản lý";
            // 
            // tsmManageAccount
            // 
            this.tsmManageAccount.Name = "tsmManageAccount";
            this.tsmManageAccount.Size = new System.Drawing.Size(180, 22);
            this.tsmManageAccount.Text = "Người dùng";
            this.tsmManageAccount.Click += new System.EventHandler(this.tsmManageAccount_Click);
            // 
            // tsmManageRole
            // 
            this.tsmManageRole.Name = "tsmManageRole";
            this.tsmManageRole.Size = new System.Drawing.Size(180, 22);
            this.tsmManageRole.Text = "Chức vụ";
            this.tsmManageRole.Click += new System.EventHandler(this.tsmManageRole_Click);
            // 
            // tsmManageRoom
            // 
            this.tsmManageRoom.Name = "tsmManageRoom";
            this.tsmManageRoom.Size = new System.Drawing.Size(180, 22);
            this.tsmManageRoom.Text = "Phòng";
            this.tsmManageRoom.Click += new System.EventHandler(this.tsmManageRoom_Click);
            // 
            // tsmManageBooking
            // 
            this.tsmManageBooking.Name = "tsmManageBooking";
            this.tsmManageBooking.Size = new System.Drawing.Size(180, 22);
            this.tsmManageBooking.Text = "Lịch đặt phòng";
            this.tsmManageBooking.Click += new System.EventHandler(this.tsmManageBooking_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblRoleDesc);
            this.Controls.Add(this.lblUserDesc);
            this.Controls.Add(this.msMenu);
            this.Name = "frmDashboard";
            this.Text = "Bảng điều khiển";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserDesc;
        private System.Windows.Forms.Label lblRoleDesc;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tsmUser;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePass;
        private System.Windows.Forms.ToolStripMenuItem tsmUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmLogOut;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmFunction;
        private System.Windows.Forms.ToolStripMenuItem tsmBookRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmManage;
        private System.Windows.Forms.ToolStripMenuItem tsmChangeRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmProfit;
        private System.Windows.Forms.ToolStripMenuItem tsmManageAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmManageRole;
        private System.Windows.Forms.ToolStripMenuItem tsmManageRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmManageBooking;
    }
}