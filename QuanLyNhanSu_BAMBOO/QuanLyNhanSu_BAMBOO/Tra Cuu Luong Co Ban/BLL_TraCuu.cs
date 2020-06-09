using QuanLyNhanSu_BAMBOO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_BAMBOO.Tra_Cuu_Thong_Tin
{
    public class BLL_TraCuu
    {
        Database data;
        public BLL_TraCuu()
        {
            data = new Database();
        }
        public DataTable LayDanhSachLuong(ref string err)
        {
            return data.GetDataTable(ref err, "PSP_DanhSachLuong_select", CommandType.StoredProcedure, null);
        }
    }
}
