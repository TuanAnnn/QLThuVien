using System.Security.Cryptography;
using System.Text;
using QLThuVien.Repositories;

namespace QLThuVien.Helpers
{
    public static class SecurityHelper
    {
        // Salt = TenDangNhap theo đúng quy định của M1
        public static string HashPassword(string rawPassword, NguoiDung user)
        {
            if (user == null || string.IsNullOrEmpty(user.TenDangNhap)) return string.Empty;

            string rawData = rawPassword + user.TenDangNhap;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}