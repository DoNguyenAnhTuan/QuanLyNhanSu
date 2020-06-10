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
    public partial class Frm_ThongTinNgonNgu : Form
    {
        public Frm_ThongTinNgonNgu()
        {
            InitializeComponent();
        }
        BLL_DanhMuc bd;
        string err = string.Empty;
        int count = 0;
        DataTable dataTable;
        NgonNgu ngonNgu;
        private void Frm_ThongTinNgonNgu_Load(object sender, EventArgs e)
        {
            bd = new BLL_DanhMuc();
            HienThiDanhSachNgonNgu();
        }
        private void HienThiDanhSachNgonNgu()
        {
            DataTable ngonNgu = new DataTable();
            ngonNgu = bd.LayDanhSachNgonNgu(ref err);
            dgvNgonNgu.DataSource = ngonNgu;
        }

        private void dgvNgonNgu_Click(object sender, EventArgs e)
        {
            if (dgvNgonNgu.Rows.Count > 0)
            {
                ngonNgu = new NgonNgu();
                ngonNgu.MaNgoaiNgu = dgvNgonNgu.CurrentRow.Cells["colMaNgonNgu"].Value.ToString();
                ngonNgu.TenNgoaiNgu = dgvNgonNgu.CurrentRow.Cells["colTenNgonNgu"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_ThongTinNgonNgu_Modifled frm_ThongTinNgonNgu_Modifled = new Frm_ThongTinNgonNgu_Modifled();
            frm_ThongTinNgonNgu_Modifled.Them = true;
            frm_ThongTinNgonNgu_Modifled.ShowDialog();
            HienThiDanhSachNgonNgu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnSuu_Click(object sender, EventArgs e)
        {
            Frm_ThongTinNgonNgu_Modifled frm_ThongTinNgonNgu_Modifled = new Frm_ThongTinNgonNgu_Modifled();
            frm_ThongTinNgonNgu_Modifled.Them = false;
            frm_ThongTinNgonNgu_Modifled.ngonNgu = ngonNgu;
            frm_ThongTinNgonNgu_Modifled.ShowDialog();
            HienThiDanhSachNgonNgu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ngonNgu != null)
            {
                if (MessageBox.Show(string.Format("Chương trình sẽ thực hiện thao tác xóa ngôn ngữ {0} khỏi hệ thống\n Việc này sẽ làm cho dữ liệu của nhân viên {1} bị thay đổi và không thể phục hồi\n Bạn có chắc chắn muốn xóa dữ liệu này không?\n Nếu đồng ý chọn OK. Ngược lại chọn Cancel", ngonNgu.TenNgoaiNgu, ngonNgu.TenNgoaiNgu), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    count = 0;
                    if (bd.XoaNgonNguByDeleteByUpdateIsDelete(ref err, ref count, ngonNgu.MaNgoaiNgu))
                    {
                        if (count > 0)
                        {
                            MessageBox.Show("Xóa thành công");
                            HienThiDanhSachNgonNgu();
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
                ExportExcel.ExportExcelByMicrosoft(dgvNgonNgu, "Chuc Vu", save.FileName, 65, "A2");
                // Cls_Main.ExportToExcel(dgvChiTietNhapHang, save.FileName, ref err, "Chi Tiết nhập hàng", "Chủ cửa hàng");
                // MessageBox.Show("Export Thành công");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
