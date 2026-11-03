using System.Linq;

namespace QLThuVien.Helpers
{
    public static class PhanQuyenHelper
    {
        public static bool CoQuyen(string tenChucNang, int maVaiTro)
        {
            using (var db = new QuanLyThuVienDataContext())
            {
                var query = from pq in db.PhanQuyens
                            join cn in db.ChucNangs on pq.MaChucNang equals cn.MaChucNang
                            where pq.MaVaiTro == maVaiTro && cn.TenChucNang == tenChucNang
                            select pq;
                return query.Any();
            }
        }
    }
}