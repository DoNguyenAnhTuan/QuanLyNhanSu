using QuanLyNhanSu_BAMBOO.DanhMuc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyNhanSu_BAMBOO.Tra_Cuu_Thong_Tin
{
    public partial class Frm_TraCuuLuongNhanVien : Form
    {
        public Frm_TraCuuLuongNhanVien()
        {
            InitializeComponent();
        }
        BLL_TraCuu db;
        string err = string.Empty;
        DataTable dtDanhSach;
        private void Frm_TraCuuLuongNhanVien_Load(object sender, EventArgs e)
        {
            db = new BLL_TraCuu();
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            dtDanhSach = new DataTable();
            dtDanhSach = db.LayDanhSachLuong(ref err);
            dgvLuong.DataSource = dtDanhSach;
            //lblSoLuong.Text = dtDanhSach.Rows.Count.ToString();
        }
        private void ResetControl()
        {
            lblMaLop.Text = "0";
            txtTenLop.ResetText();
            txtGVCN.ResetText();
            txtTenLop.Focus();
        }

        private void dgvLuong_Click(object sender, EventArgs e)
        {
            if (dgvLuong.Rows.Count > 0)
            {
                lblMaLop.Text = dgvLuong.CurrentRow.Cells["colTenViTri"].Value.ToString();
                txtTenLop.Text = dgvLuong.CurrentRow.Cells["colMucLuongI"].Value.ToString();
                txtGVCN.Text = dgvLuong.CurrentRow.Cells["colMucLuongII"].Value.ToString();
                lblSoLuong.Text = dgvLuong.CurrentRow.Cells["colMucLuongIII"].Value.ToString();

            }
        }
    }
}
