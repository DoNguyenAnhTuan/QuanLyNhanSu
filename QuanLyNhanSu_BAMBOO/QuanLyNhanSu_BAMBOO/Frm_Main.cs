using QuanLyNhanSu_BAMBOO.Cap_Nhat_He_Thong;
using QuanLyNhanSu_BAMBOO.DanhMuc;
using QuanLyNhanSu_BAMBOO.HeThong;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_BAMBOO
{
    public partial class Frm_Main: Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
            frm_DangNhap.ShowDialog();
            lblTenNhanVien.Text = Cls_Main.tenNhanVien;
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
            frm_DangNhap.ShowDialog();
            lblTenNhanVien.Text = Cls_Main.tenNhanVien;
        }

        private void mnuQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            Frm_NhanVien_Main frm_NhanVien_Main = new Frm_NhanVien_Main();
            frm_NhanVien_Main.MdiParent = this;
            frm_NhanVien_Main.Show();
        }

        private void mnuSaoLuu_Click(object sender, EventArgs e)
        {
            Frm_SaoLuuPhucHoi frm_SaoLuuPhucHoi = new Frm_SaoLuuPhucHoi();
            frm_SaoLuuPhucHoi.saoLuuStatus = true;
            frm_SaoLuuPhucHoi.ShowDialog();
        }

        private void mnuPhucHoi_Click(object sender, EventArgs e)
        {
            Frm_SaoLuuPhucHoi frm_SaoLuuPhucHoi = new Frm_SaoLuuPhucHoi();
            frm_SaoLuuPhucHoi.saoLuuStatus = false;
            frm_SaoLuuPhucHoi.ShowDialog();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhau frm_DoiMatKhau = new Frm_DoiMatKhau();
            frm_DoiMatKhau.ShowDialog();
        }

        private void thoátHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnu_TTNV_Click(object sender, EventArgs e)
        {
            Frm_ThongTinNhanVien frm_ThongTinNhanVien = new Frm_ThongTinNhanVien();
            frm_ThongTinNhanVien.ShowDialog();
        }

        private void mnu_TTNN_Click(object sender, EventArgs e)
        {
            Frm_ThongTinNgonNgu frm_ThongTinNgon = new Frm_ThongTinNgonNgu();
            frm_ThongTinNgon.ShowDialog();
        }

        private void mnu_TTCV_Click(object sender, EventArgs e)
        {
            Frm_ThongTinChucVu frm_ThongTinChuc = new Frm_ThongTinChucVu();
            frm_ThongTinChuc.ShowDialog();
        }

        private void mnuTraCuu_Click(object sender, EventArgs e)
        {
            Tra_Cuu_Thong_Tin.Frm_TraCuuLuongNhanVien frm_TraCuuLuongNhanVien = new Tra_Cuu_Thong_Tin.Frm_TraCuuLuongNhanVien();
            frm_TraCuuLuongNhanVien.ShowDialog();
        }
    }
}
