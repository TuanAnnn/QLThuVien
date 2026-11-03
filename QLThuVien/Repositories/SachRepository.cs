using System.Collections.Generic;
using System.Linq;

namespace QLThuVien.Repositories
{
    public class SachRepository : MauRepository<Sach>
    {
        public List<Sach> GetSachConHang()
        {
            return db.Saches.Where(s => s.SoLuongCon > 0).ToList();
        }

        public Sach GetById(int maSach)
        {
            return db.Saches.FirstOrDefault(s => s.MaSach == maSach);
        }
    }
}