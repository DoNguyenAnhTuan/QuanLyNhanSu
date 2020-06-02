namespace QuanLyNhanSu_BAMBOO
{
    partial class Frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtNốiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaoLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhucHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatTTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TTNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TTNN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TTCV = new System.Windows.Forms.ToolStripMenuItem();
            this.TraCuuTTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTenNhanVien = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.CapNhatTTToolStripMenuItem,
            this.TraCuuTTToolStripMenuItem,
            this.thoátHệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat,
            this.kếtNốiToolStripMenuItem,
            this.mnuSaoLuu,
            this.mnuPhucHoi,
            this.mnuQuanLyTaiKhoan,
            this.phânQuyềnToolStripMenuItem,
            this.mnuDoiMatKhau,
            this.mnuThoat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(167, 22);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // kếtNốiToolStripMenuItem
            // 
            this.kếtNốiToolStripMenuItem.Name = "kếtNốiToolStripMenuItem";
            this.kếtNốiToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kếtNốiToolStripMenuItem.Text = "Kết nối";
            // 
            // mnuSaoLuu
            // 
            this.mnuSaoLuu.Name = "mnuSaoLuu";
            this.mnuSaoLuu.Size = new System.Drawing.Size(167, 22);
            this.mnuSaoLuu.Text = "Sao lưu";
            this.mnuSaoLuu.Click += new System.EventHandler(this.mnuSaoLuu_Click);
            // 
            // mnuPhucHoi
            // 
            this.mnuPhucHoi.Name = "mnuPhucHoi";
            this.mnuPhucHoi.Size = new System.Drawing.Size(167, 22);
            this.mnuPhucHoi.Text = "Phục hồi";
            this.mnuPhucHoi.Click += new System.EventHandler(this.mnuPhucHoi_Click);
            // 
            // mnuQuanLyTaiKhoan
            // 
            this.mnuQuanLyTaiKhoan.Name = "mnuQuanLyTaiKhoan";
            this.mnuQuanLyTaiKhoan.Size = new System.Drawing.Size(167, 22);
            this.mnuQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.mnuQuanLyTaiKhoan.Click += new System.EventHandler(this.mnuQuanLyTaiKhoan_Click);
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.phânQuyềnToolStripMenuItem.Text = "Phân quyền";
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(167, 22);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(167, 22);
            this.mnuThoat.Text = "Thoát";
            // 
            // CapNhatTTToolStripMenuItem
            // 
            this.CapNhatTTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_TTNV,
            this.mnu_TTNN,
            this.mnu_TTCV});
            this.CapNhatTTToolStripMenuItem.Name = "CapNhatTTToolStripMenuItem";
            this.CapNhatTTToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.CapNhatTTToolStripMenuItem.Text = "Cập Nhật Hệ Thống";
            // 
            // mnu_TTNV
            // 
            this.mnu_TTNV.Name = "mnu_TTNV";
            this.mnu_TTNV.Size = new System.Drawing.Size(191, 22);
            this.mnu_TTNV.Text = "Thông Tin Nhân Viên";
            this.mnu_TTNV.Click += new System.EventHandler(this.mnu_TTNV_Click);
            // 
            // mnu_TTNN
            // 
            this.mnu_TTNN.Name = "mnu_TTNN";
            this.mnu_TTNN.Size = new System.Drawing.Size(191, 22);
            this.mnu_TTNN.Text = "Thông Tin Ngoại Ngữ ";
            this.mnu_TTNN.Click += new System.EventHandler(this.mnu_TTNN_Click);
            // 
            // mnu_TTCV
            // 
            this.mnu_TTCV.Name = "mnu_TTCV";
            this.mnu_TTCV.Size = new System.Drawing.Size(191, 22);
            this.mnu_TTCV.Text = "Thông Tin Chức Vụ";
            this.mnu_TTCV.Click += new System.EventHandler(this.mnu_TTCV_Click);
            // 
            // TraCuuTTToolStripMenuItem
            // 
            this.TraCuuTTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTraCuu});
            this.TraCuuTTToolStripMenuItem.Name = "TraCuuTTToolStripMenuItem";
            this.TraCuuTTToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.TraCuuTTToolStripMenuItem.Text = "Tra Cứu Thông Tin";
            // 
            // mnuTraCuu
            // 
            this.mnuTraCuu.Name = "mnuTraCuu";
            this.mnuTraCuu.Size = new System.Drawing.Size(209, 22);
            this.mnuTraCuu.Text = "Tra Cứu Lương Nhân Viên";
            this.mnuTraCuu.Click += new System.EventHandler(this.mnuTraCuu_Click);
            // 
            // thoátHệThốngToolStripMenuItem
            // 
            this.thoátHệThốngToolStripMenuItem.Name = "thoátHệThốngToolStripMenuItem";
            this.thoátHệThốngToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.thoátHệThốngToolStripMenuItem.Text = "Thoát Hệ Thống";
            this.thoátHệThốngToolStripMenuItem.Click += new System.EventHandler(this.thoátHệThốngToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblTenNhanVien});
            this.statusStrip1.Location = new System.Drawing.Point(0, 366);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(770, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(176, 17);
            this.toolStripStatusLabel1.Text = "Hệ thống được đăng nhập bởi : ";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenNhanVien.ForeColor = System.Drawing.Color.Blue;
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(29, 17);
            this.lblTenNhanVien.Text = "N/A";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 388);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.Text = "Nhóm BAMBOO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem kếtNốiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSaoLuu;
        private System.Windows.Forms.ToolStripMenuItem mnuPhucHoi;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem CapNhatTTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TraCuuTTToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblTenNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnu_TTNV;
        private System.Windows.Forms.ToolStripMenuItem mnu_TTNN;
        private System.Windows.Forms.ToolStripMenuItem mnu_TTCV;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuu;
        private System.Windows.Forms.ToolStripMenuItem thoátHệThốngToolStripMenuItem;
    }
}

