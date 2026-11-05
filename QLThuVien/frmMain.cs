using System;
using System.Windows.Forms;
using QLThuVien.Helpers;

namespace QLThuVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent(); // Bắt buộc phải có để dựng giao diện
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ApplyRBAC();
        }

        private void ApplyRBAC()
        {
            // Duyệt tất cả Menu cấp 1 trên thanh MenuStrip
            if (menuStrip1 != null)
            {
                foreach (ToolStripItem item in menuStrip1.Items)
                {
                    // Menu Hệ thống luôn hiển thị cho mọi tài khoản
                    if (item.Name == "menuHeThong") continue;

                    // Phân quyền ẩn/hiện các menu theo Database
                    item.Visible = PhanQuyenHelper.CoQuyen(item.Name, CurrentUser.MaVaiTro);
                }
            }
        }

        private void menuHeThong_Click(object sender, EventArgs e)
        {
            // Giữ lại hàm này để không bị gãy sự kiện trong Designer
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