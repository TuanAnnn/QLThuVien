namespace QLThuVien.Helpers
{
    public static class CurrentUser
    {
        public static int MaND { get; set; }
        public static string TenDangNhap { get; set; }
        public static int MaVaiTro { get; set; }
        public static string HoTen { get; set; }

        public static void Clear()
        {
            MaND = 0;
            TenDangNhap = null;
            MaVaiTro = 0;
            HoTen = null;
        }
    }
}