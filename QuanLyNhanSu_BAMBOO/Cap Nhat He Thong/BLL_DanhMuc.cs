using QuanLyNhanSu_BAMBOO.Cap_Nhat_He_Thong;
using QuanLyNhanSu_BAMBOO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_BAMBOO.DanhMuc
{
   public class BLL_DanhMuc
    {
       Database data;

       public BLL_DanhMuc()
       {
            data = new Database();
       }

        public DataTable layDanhSach(ref string err)
        {
            return data.GetDataTable(ref err, "PSP_tblQLNS_select", CommandType.StoredProcedure, null);
        }
        public bool Xoa(ref string err, string MaNhanVien)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_QLNS_Xoa", CommandType.StoredProcedure,
                new SqlParameter("@MaNhanVien", MaNhanVien));
        }
        public bool Insert(ref string err, string MaNhanVien, string TenNhanVien, string DienThoai)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_QLNS_Insert_Update", CommandType.StoredProcedure,
                new SqlParameter("@MaNhanVien", MaNhanVien),
                new SqlParameter("@TenNhanVien", TenNhanVien),
                new SqlParameter("@DienThoai", DienThoai));
        }

        public DataTable LayDanhSachChucVu(ref string err)
        {
            return data.GetDataTable(ref err, "PSP_ChucVu_Select", CommandType.StoredProcedure, null);
        }
        public bool CapNhatChucVu(ref string err, ref int count, ChucVu chucVu)
        {
            return data.MyExcuteNonQuery(ref err, ref count, "PSP_ChucVu_InsertUpdate", CommandType.StoredProcedure,
                new SqlParameter("@MaChucVu", chucVu.MaChucVu),
                new SqlParameter("@TenChucVu", chucVu.TenChucVu));
               
        }
        public DataTable layDanhSachChucVu(ref string err)
        {
            return data.GetDataTable(ref err, "PSP_tblChucVu_select", CommandType.StoredProcedure, null);
        }
        public bool XoaChucVu(ref string err, string MaChucVu)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_ChucVu_Xoa", CommandType.StoredProcedure,
                new SqlParameter("@MaChucVu", MaChucVu));
        }
        public bool XoaChucVuByDelete(ref string err, ref int count, string maChucVu)
        {
            return data.MyExcuteNonQuery(ref err, ref count, "PSP_ChucVu_Delete", CommandType.StoredProcedure,
                new SqlParameter("@MaChucVu", maChucVu));
        }

        public bool XoaChucVuByDeleteByUpdateIsDelete(ref string err, ref int count, string maChucVu)
        {
            return data.MyExcuteNonQuery(ref err, ref count, "PSP_ChucVu_DeleteByUpdateIsDelete", CommandType.StoredProcedure,
                new SqlParameter("@MaChucVu", maChucVu));
        }

        public DataTable LayDanhSachNgonNgu(ref string err)
        {
            return data.GetDataTable(ref err, "PSP_NgonNgu_Select", CommandType.StoredProcedure, null);
        }
        public bool CapNhatNgonNgu(ref string err, ref int count, NgonNgu ngonNgu)
        {
            return data.MyExcuteNonQuery(ref err, ref count, "PSP_NgonNgu_InsertUpdate", CommandType.StoredProcedure,
                new SqlParameter("@MaNgonNgu", ngonNgu.MaNgoaiNgu),
                new SqlParameter("@TenNgonNgu", ngonNgu.TenNgoaiNgu));

        }
        public bool XoaNgonNguByDelete(ref string err, ref int count, string maNgonNgu)
        {
            return data.MyExcuteNonQuery(ref err, ref count, "PSP_NgonNgu_Delete", CommandType.StoredProcedure,
                new SqlParameter("@MaNgonNgu", maNgonNgu));
        }

        public bool XoaNgonNguByDeleteByUpdateIsDelete(ref string err, ref int count, string maNgonNgu)
        {
            return data.MyExcuteNonQuery(ref err, ref count, "PSP_NgonNgu_DeleteByUpdateIsDelete", CommandType.StoredProcedure,
                new SqlParameter("@MaNgonNgu", maNgonNgu));
        }
    }
}
