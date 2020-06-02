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

namespace QuanLyNhanSu_BAMBOO.Cap_Nhat_He_Thong
{
    public partial class Frm_ThongTinNhanVien : Form
    {
        public Frm_ThongTinNhanVien()
        {
            InitializeComponent();
        }
       BLL_DanhMuc db;
        string err = string.Empty;
        DataTable dtDanhSach;
        private void Frm_ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            db = new BLL_DanhMuc();
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            dtDanhSach = new DataTable();
            dtDanhSach = db.layDanhSach(ref err);
            dgvDanhSach.DataSource = dtDanhSach;
            lblSoLuong.Text = dtDanhSach.Rows.Count.ToString();
        }
        private void ResetControl()
        {
            lblMaLop.Text = "0";
            txtTenLop.ResetText();
            txtGVCN.ResetText();
            txtTenLop.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (db.Insert(ref err, lblMaLop.Text, txtTenLop.Text, txtGVCN.Text))
            {
                ResetControl();
                HienThiDanhSach();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvDanhSach.EndEdit();
            if (dgvDanhSach.Rows.Count > 0)
            {
                for (int i = dgvDanhSach.Rows.Count - 1; i >= 0; i--)
                {
                    if (dgvDanhSach.Rows[i].Cells["colDelete"].Value.ToString().Equals("1"))
                    {
                        if (db.Xoa(ref err, dgvDanhSach.Rows[i].Cells["colMaNV"].Value.ToString()))
                        {

                        }
                        else
                        {
                            MessageBox.Show(err);
                        }
                    }
                }
                HienThiDanhSach();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgvDanhSach_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.Rows.Count > 0)
            {
                lblMaLop.Text = dgvDanhSach.CurrentRow.Cells["colMaNV"].Value.ToString();
                txtTenLop.Text = dgvDanhSach.CurrentRow.Cells["colTenNV"].Value.ToString();
                txtGVCN.Text = dgvDanhSach.CurrentRow.Cells["colDienThoai"].Value.ToString();
            }
        }
    }
}
