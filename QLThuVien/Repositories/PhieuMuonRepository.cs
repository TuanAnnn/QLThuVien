using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace QLThuVien.Repositories
{
    public class PhieuMuonRepository : MauRepository<PhieuMuon>
    {
        public bool LapPhieuMuon(PhieuMuon phieu, List<ChiTietMuon> chiTiets)
        {
            // Sử dụng TransactionScope để đảm bảo toàn vẹn dữ liệu
            using (var scope = new TransactionScope())
            {
                try
                {
                    // 1. Tạo phiếu mượn trước
                    db.PhieuMuons.InsertOnSubmit(phieu);
                    db.SubmitChanges(); // Lúc này phieu.MaPhieu tự động có giá trị

                    foreach (var ct in chiTiets)
                    {
                        // 2. Kiểm tra tồn kho
                        var sach = db.Saches.FirstOrDefault(s => s.MaSach == ct.MaSach);
                        if (sach == null || sach.SoLuongCon < ct.SoLuong)
                        {
                            throw new Exception($"Sách '{sach?.TenSach}' không đủ số lượng tồn kho!");
                        }

                        // 3. Trừ tồn kho
                        sach.SoLuongCon -= ct.SoLuong;

                        // 4. Thêm chi tiết
                        ct.MaPhieu = phieu.MaPhieu;
                        db.ChiTietMuons.InsertOnSubmit(ct);
                    }

                    db.SubmitChanges(); // Lưu tất cả thay đổi
                    scope.Complete();   // Xác nhận hoàn tất (Commit)
                    return true;
                }
                catch (Exception ex)
                {
                    // Nếu có lỗi, scope.Complete() không được gọi -> Tự động Rollback
                    throw new Exception("Lỗi lập phiếu: " + ex.Message);
                }
            }
        }
    }
}