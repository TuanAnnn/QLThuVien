using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Repositories
{
    public class NguoiDungRepository : MauRepository<NguoiDung>
    {
        public NguoiDung GetByTenDangNhap(string tenDangNhap)
        {
            return db.NguoiDungs.FirstOrDefault(nd => nd.TenDangNhap == tenDangNhap);
        }
    }
}