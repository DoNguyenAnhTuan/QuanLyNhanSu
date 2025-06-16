
```markdown
# 🧑‍💼 Quản Lý Nhân Sự - WinForms App

**Ứng dụng quản lý nhân sự được xây dựng bằng C# WinForms, cho phép người dùng thêm, sửa, xóa và tìm kiếm thông tin nhân viên.**  
Hệ thống sử dụng SQL Server để lưu trữ dữ liệu và hỗ trợ giao diện thân thiện với người dùng.

---

## 🚀 Tính năng chính

- 📝 Thêm, sửa, xóa thông tin nhân viên
- 🔍 Tìm kiếm nhân viên theo tên, mã số
- 🧾 Quản lý danh sách nhân sự trong tổ chức
- 💾 Kết nối SQL Server để lưu dữ liệu
- 📊 Hiển thị dữ liệu trong bảng DataGridView

---

## 🛠 Công nghệ sử dụng

- **Ngôn ngữ**: C#  
- **Giao diện**: Windows Forms (WinForms)  
- **Cơ sở dữ liệu**: Microsoft SQL Server  
- **Môi trường phát triển**: Visual Studio

---

## 📦 Cấu trúc thư mục

```

QuanLyNhanSu/
├── FormMain.cs         # Giao diện chính
├── FormNhanVien.cs     # Quản lý nhân viên
├── NhanVien.cs         # Class nhân viên (model)
├── DataAccess.cs       # Kết nối CSDL
└── QuanLyNhanSu.sql    # File khởi tạo database

````

---

## 📸 Giao diện minh họa

> Bạn có thể thêm ảnh chụp màn hình vào đây để minh họa giao diện ứng dụng.

---

## 📥 Hướng dẫn chạy dự án

1. Clone repo:
```bash
git clone https://github.com/DoNguyenAnhTuan/QuanLyNhanSu.git
````

2. Mở project bằng **Visual Studio**
3. Cấu hình lại chuỗi kết nối SQL trong file `DataAccess.cs` nếu cần
4. Build và chạy ứng dụng (`F5`)

---

## 🧑‍🎓 Tác giả

**Do Nguyen Anh Tuan**
MSc in Information Technology - LHU
FabLab EIU - Binh Duong 🇻🇳
📫 [https://github.com/DoNguyenAnhTuan](https://github.com/DoNguyenAnhTuan)

---

## 📄 License

This project is licensed under the MIT License.

```

