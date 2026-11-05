namespace QLThuVien
{
    partial class frmMain
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
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLySach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyVaiTro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuQuanLySach,
            this.menuQuanLyDocGia,
            this.menuQuanLyNguoiDung,
            this.menuQuanLyVaiTro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDoiMatKhau,
            this.menuDangXuat});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(85, 24);
            this.menuHeThong.Text = "Hệ thống";
            this.menuHeThong.Click += new System.EventHandler(this.menuHeThong_Click);
            // 
            // menuDoiMatKhau
            // 
            this.menuDoiMatKhau.Name = "menuDoiMatKhau";
            this.menuDoiMatKhau.Size = new System.Drawing.Size(224, 26);
            this.menuDoiMatKhau.Text = "Đổi mật khẩu";
            this.menuDoiMatKhau.Click += new System.EventHandler(this.menuDoiMatKhau_Click);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(224, 26);
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // menuQuanLySach
            // 
            this.menuQuanLySach.Name = "menuQuanLySach";
            this.menuQuanLySach.Size = new System.Drawing.Size(108, 24);
            this.menuQuanLySach.Text = "Quản lý Sách";
            // 
            // menuQuanLyDocGia
            // 
            this.menuQuanLyDocGia.Name = "menuQuanLyDocGia";
            this.menuQuanLyDocGia.Size = new System.Drawing.Size(129, 24);
            this.menuQuanLyDocGia.Text = "Quản lý Độc giả";
            // 
            // menuQuanLyNguoiDung
            // 
            this.menuQuanLyNguoiDung.Name = "menuQuanLyNguoiDung";
            this.menuQuanLyNguoiDung.Size = new System.Drawing.Size(157, 24);
            this.menuQuanLyNguoiDung.Text = "Quản lý Người dùng";
            this.menuQuanLyNguoiDung.Click += new System.EventHandler(this.menuQuanLyNguoiDung_Click);
            // 
            // menuQuanLyVaiTro
            // 
            this.menuQuanLyVaiTro.Name = "menuQuanLyVaiTro";
            this.menuQuanLyVaiTro.Size = new System.Drawing.Size(153, 24);
            this.menuQuanLyVaiTro.Text = "Quản lý Phân quyền";
            this.menuQuanLyVaiTro.Click += new System.EventHandler(this.menuQuanLyVaiTro_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLySach;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyDocGia;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyVaiTro;
    }
}