using System;
using System.Windows.Forms;
using QLThuVien.Helpers;

namespace QLThuVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent(); 
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ApplyRBAC();
        }

        private void ApplyRBAC()
        {
            if (menuStrip1 != null)
            {
                foreach (ToolStripItem item in menuStrip1.Items)
                {
                    if (item.Name == "menuHeThong") continue;

                    string tenChucNang = "";
                    if (item.Name == "menuQuanLyNguoiDung") tenChucNang = "Quản lý Tài khoản";
                    else if (item.Name == "menuQuanLyVaiTro") tenChucNang = "Quản lý Tài khoản"; 
                    else if (item.Name == "menuQuanLySach") tenChucNang = "Quản lý Sách";
                    else if (item.Name == "menuQuanLyDocGia") tenChucNang = "Quản lý Độc giả";
                    else if (item.Name == "menuLapPhieuMuon") tenChucNang = "Lập phiếu mượn";
                    else if (item.Name == "menuBaoCao") tenChucNang = "Báo cáo - Thống kê";

                   
                    if (string.IsNullOrEmpty(tenChucNang))
                    {
                        item.Visible = true;
                    }
                    else
                    {
                        item.Visible = PhanQuyenHelper.CoQuyen(tenChucNang, CurrentUser.MaVaiTro);
                    }
                }
            }
        }

        private void menuHeThong_Click(object sender, EventArgs e)
        {
          
        }

        private void menuDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            CurrentUser.Clear();
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

        private void menuQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            frmUserManagement frm = new frmUserManagement();
            frm.ShowDialog();
        }

        private void menuQuanLyVaiTro_Click(object sender, EventArgs e)
        {
            frmRoleManagement frm = new frmRoleManagement();
            frm.ShowDialog();
        }
    }
}