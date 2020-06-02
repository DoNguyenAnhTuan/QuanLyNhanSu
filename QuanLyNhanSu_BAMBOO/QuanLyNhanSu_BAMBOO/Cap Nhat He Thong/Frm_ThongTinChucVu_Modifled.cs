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
    public partial class Frm_ThongTinChucVu_Modifled : Form
    {
        public Frm_ThongTinChucVu_Modifled()
        {
            InitializeComponent();
        }
        public bool Them = false;
        BLL_DanhMuc bd;
        string err = string.Empty;
        int count = 0;
        public ChucVu chucVu;
        private void Frm_ThongTinChucVu_Modifled_Load(object sender, EventArgs e)
        {
            bd = new BLL_DanhMuc();
            if (Them)
            {
                txtMaChucVu.Text = "0";
                txtTenChucVu.Focus();
            }
            else //sửa
            {
                //view thông nhân viên cần sửa
                LayDuLieuVaoControl(chucVu);
            }
        }
        private void LayDuLieuVaoControl(ChucVu chucVu)
        {
            txtMaChucVu.Text = chucVu.MaChucVu;
            txtTenChucVu.Text = chucVu.TenChucVu;  
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenChucVu.Text))
            {
                LayThongTinChucVuTuControl();
                if (bd.CapNhatChucVu(ref err, ref count, chucVu))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Chưa thêm thành công chức vụ");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tên chức vụ");
                txtTenChucVu.Focus();
            }
        }
        private void LayThongTinChucVuTuControl()
        {
            chucVu = new ChucVu();
            chucVu.MaChucVu = txtMaChucVu.Text;
            chucVu.TenChucVu = txtTenChucVu.Text;
           

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
