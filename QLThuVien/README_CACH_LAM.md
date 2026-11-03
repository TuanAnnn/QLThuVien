# HƯỚNG DẪN DÀNH CHO M2, M3, M4 (Đọc kỹ trước khi code)

Chào các bạn, M1 đã dựng xong bộ khung Core. Mọi người làm đúng theo kiến trúc sau nhé:

## 1. Dành cho M2 (Hệ thống, Bảo mật & RBAC)
- **Đăng nhập:** Dùng `NguoiDungRepository.GetByTenDangNhap()`. Mật khẩu dưới DB đã được hash SHA-256 (Salt = TenDangNhap). Code verify: `HashPassword(pass, user) == user.MatKhau`.
- **Phân quyền:** Đã có sẵn hàm `PhanQuyenHelper.CoQuyen("Tên Chức Năng", MaVaiTro)` trong thư mục Helpers. Chỉ cần gọi trong `frmMain_Load` để ẩn/hiện menu.

## 2. Dành cho M3 (Danh mục & Nghiệp vụ)
- **Làm form CRUD:** Đã có sẵn `frmMauCRUD`. Hãy copy form này, đổi tên thành `frmQuanLySach`, `frmQuanLyDocGia`... 
- **Gọi dữ liệu:** Không viết LINQ trong Form. Hãy gọi qua Repository. VD: `new SachRepository().GetAll()`.
- **Nghiệp vụ mượn sách:** Dùng hàm `new PhieuMuonRepository().LapPhieuMuon(phieu, listChiTiet)`. Hàm này đã tích hợp sẵn `TransactionScope`, tự động kiểm tra tồn kho và rollback nếu lỗi.

## 3. Dành cho M4 (Report & Chart)
- **Lấy số liệu:** Vào thư mục Repositories, viết thêm các hàm LINQ `GroupBy`, `Sum` (VD: viết trong `SachRepository`) để lấy data đổ vào Chart.
- **Report:** Dùng dữ liệu từ Repository để đẩy vào `ReportDataSource`.