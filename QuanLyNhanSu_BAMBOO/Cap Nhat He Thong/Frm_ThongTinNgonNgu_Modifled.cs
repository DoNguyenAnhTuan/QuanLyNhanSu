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
    public partial class Frm_ThongTinNgonNgu_Modifled : Form
    {
        public Frm_ThongTinNgonNgu_Modifled()
        {
            InitializeComponent();
        }
        public bool Them = false;
        BLL_DanhMuc bd;
        string err = string.Empty;
        int count = 0;
        public NgonNgu ngonNgu;
        private void Frm_ThongTinNgonNgu_Modifled_Load(object sender, EventArgs e)
        {
            bd = new BLL_DanhMuc();
            if (Them)
            {
                txtMaNgonNgu.Text = "0";
                txtTenNgonNgu.Focus();
            }
            else //sửa
            {
                //view thông nhân viên cần sửa
                LayDuLieuVaoControl(ngonNgu);
            }
        }
        private void LayDuLieuVaoControl(NgonNgu ngonNgu)
        {
            txtMaNgonNgu.Text = ngonNgu.MaNgoaiNgu;
            txtTenNgonNgu.Text = ngonNgu.TenNgoaiNgu;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenNgonNgu.Text))
            {
                LayThongTinChucVuTuControl();
                if (bd.CapNhatNgonNgu(ref err, ref count, ngonNgu))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Chưa thêm thành công ngôn ngữ");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tên ngôn ngữ");
                txtTenNgonNgu.Focus();
            }
        }
        private void LayThongTinChucVuTuControl()
        {
            ngonNgu = new NgonNgu();
            ngonNgu.MaNgoaiNgu = txtMaNgonNgu.Text;
            ngonNgu.TenNgoaiNgu = txtTenNgonNgu.Text;


        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
