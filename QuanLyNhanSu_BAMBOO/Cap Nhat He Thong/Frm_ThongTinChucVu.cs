using MyLibrary;
using QuanLyNhanSu_BAMBOO.DanhMuc;
using QuanLyNhanSu_BAMBOO.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_BAMBOO.Cap_Nhat_He_Thong 
{
    public partial class Frm_ThongTinChucVu : Form
    {
        public Frm_ThongTinChucVu()
        {
            InitializeComponent();
        }
        BLL_DanhMuc bd;
        string err = string.Empty;
        int count = 0;
        DataTable dataTable;
        ChucVu chucVu;
        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_ThongTinChucVu_Modifled frm_ThongTinChuc = new Frm_ThongTinChucVu_Modifled();
            frm_ThongTinChuc.Them = true;
            frm_ThongTinChuc.ShowDialog();
            HienThiDanhSachChucVu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Frm_ThongTinChucVu_Modifled frm_ThongTinChucVu_Modifled = new Frm_ThongTinChucVu_Modifled();
            frm_ThongTinChucVu_Modifled.Them = false;
            frm_ThongTinChucVu_Modifled.chucVu = chucVu;
            frm_ThongTinChucVu_Modifled.ShowDialog();
            HienThiDanhSachChucVu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (chucVu != null)
            {
                if (MessageBox.Show(string.Format("Chương trình sẽ thực hiện thao tác xóa chức vụ {0} khỏi hệ thống\n Việc này sẽ làm cho dữ liệu của nhân viên {1} bị thay đổi và không thể phục hồi\n Bạn có chắc chắn muốn xóa dữ liệu này không?\n Nếu đồng ý chọn OK. Ngược lại chọn Cancel", chucVu.TenChucVu, chucVu.TenChucVu), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    count = 0;
                    if (bd.XoaChucVuByDeleteByUpdateIsDelete(ref err, ref count, chucVu.MaChucVu))
                    {
                        if (count > 0)
                        {
                            MessageBox.Show("Xóa thành công");
                            HienThiDanhSachChucVu();
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công\n" + err);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công\n" + err);
                    }
                }
            }
        }

        private void btnEE_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Nơi chứa file Exprot Excel";
            save.DefaultExt = "xls";
            save.AddExtension = true;
            save.Filter = "File Excel (*.xls)|*.xls";
            save.RestoreDirectory = true;
            save.FileName = string.Format("ExportExcel_{0}{1:00}{2:00}{3:00}{4:00}{5:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            if (save.ShowDialog() == DialogResult.OK)
            {
                // Cls_Main.ExportExcelByMicrosoft(dgvDanhSachNhanVien, "Danh sách nhân viên", save.FileName, 65, "A2");
                ExportExcel.ExportExcelByMicrosoft(dgvChucVu, "Chuc Vu", save.FileName, 65, "A2");
                // Cls_Main.ExportToExcel(dgvChiTietNhapHang, save.FileName, ref err, "Chi Tiết nhập hàng", "Chủ cửa hàng");
                // MessageBox.Show("Export Thành công");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_ThongTinChucVu_Load(object sender, EventArgs e)
        {
            bd = new BLL_DanhMuc();
            HienThiDanhSachChucVu();
        }
        private void HienThiDanhSachChucVu()
        {
            DataTable chucVu = new DataTable();
            chucVu = bd.LayDanhSachChucVu(ref err);
            dgvChucVu.DataSource = chucVu;
        }

        private void dgvChucVu_Click(object sender, EventArgs e)
        {
            if (dgvChucVu.Rows.Count > 0)
            {
                chucVu = new ChucVu();
                chucVu.MaChucVu = dgvChucVu.CurrentRow.Cells["colMaChucVu"].Value.ToString();
                chucVu.TenChucVu = dgvChucVu.CurrentRow.Cells["colTenChucVu"].Value.ToString();           
            }
        }
    }
}
