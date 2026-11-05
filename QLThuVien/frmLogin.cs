using System;
using System.Windows.Forms;
using QLThuVien.Helpers;
using QLThuVien.Repositories;

namespace QLThuVien
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;

            // 1. Kiểm tra đầu vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy thông tin người dùng từ Database qua Repository của M1
            NguoiDungRepository repo = new NguoiDungRepository();
            NguoiDung user = repo.GetByTenDangNhap(username);

            // 3. Xác thực SHA-256 với Salt = TenDangNhap theo đúng quy định của M1
            if (user != null && SecurityHelper.HashPassword(password, user) == user.MatKhau)
            {
                // Lưu session đăng nhập
                CurrentUser.MaND = user.MaND;
                CurrentUser.TenDangNhap = user.TenDangNhap;
                CurrentUser.MaVaiTro = user.MaVaiTro ?? 0;
                CurrentUser.HoTen = user.HoTen;

                // Mở Form Main
                this.Hide();
                frmMain main = new frmMain();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}