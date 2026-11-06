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

        public new void Update(NguoiDung user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            NguoiDung existingUser = db.NguoiDungs.SingleOrDefault(nd => nd.MaND == user.MaND);
            if (existingUser == null)
            {
                throw new InvalidOperationException("Không tìm thấy người dùng cần cập nhật.");
            }

            existingUser.TenDangNhap = user.TenDangNhap;
            existingUser.MatKhau = user.MatKhau;
            existingUser.HoTen = user.HoTen;
            existingUser.MaVaiTro = user.MaVaiTro;
            db.SubmitChanges();
        }
    }
}