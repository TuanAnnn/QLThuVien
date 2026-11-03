using System.Collections.Generic;
using System.Linq;

namespace QLThuVien.Repositories
{
    public class DocGiaRepository : MauRepository<DocGia>
    {
        public DocGia GetById(int maDocGia)
        {
            return db.DocGias.FirstOrDefault(d => d.MaDocGia == maDocGia);
        }
    }
}