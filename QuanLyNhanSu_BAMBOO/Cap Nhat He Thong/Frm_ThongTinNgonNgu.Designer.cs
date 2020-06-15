namespace QuanLyNhanSu_BAMBOO.Cap_Nhat_He_Thong
{
    partial class Frm_ThongTinNgonNgu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThongTinNgonNgu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnSuu = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnEE = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.dgvNgonNgu = new System.Windows.Forms.DataGridView();
            this.colMaNgonNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNgonNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgonNgu)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 254);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(405, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnLuu,
            this.btnSuu,
            this.btnXoa,
            this.btnEE,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(405, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(41, 22);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(56, 22);
            this.btnLuu.Text = "Nộp Bài ";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSuu
            // 
            this.btnSuu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSuu.Image = ((System.Drawing.Image)(resources.GetObject("btnSuu.Image")));
            this.btnSuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuu.Name = "btnSuu";
            this.btnSuu.Size = new System.Drawing.Size(30, 22);
            this.btnSuu.Text = "Sửa";
            this.btnSuu.Click += new System.EventHandler(this.btnSuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(31, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnEE
            // 
            this.btnEE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEE.Image = ((System.Drawing.Image)(resources.GetObject("btnEE.Image")));
            this.btnEE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEE.Name = "btnEE";
            this.btnEE.Size = new System.Drawing.Size(75, 22);
            this.btnEE.Text = "Export Excel";
            this.btnEE.Click += new System.EventHandler(this.btnEE_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(41, 22);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvNgonNgu
            // 
            this.dgvNgonNgu.AllowUserToAddRows = false;
            this.dgvNgonNgu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvNgonNgu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNgonNgu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNgonNgu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNgonNgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNgonNgu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNgonNgu,
            this.colTenNgonNgu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNgonNgu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNgonNgu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNgonNgu.Location = new System.Drawing.Point(0, 25);
            this.dgvNgonNgu.Name = "dgvNgonNgu";
            this.dgvNgonNgu.ReadOnly = true;
            this.dgvNgonNgu.RowHeadersVisible = false;
            this.dgvNgonNgu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNgonNgu.Size = new System.Drawing.Size(405, 229);
            this.dgvNgonNgu.TabIndex = 6;
            this.dgvNgonNgu.Click += new System.EventHandler(this.dgvNgonNgu_Click);
            // 
            // colMaNgonNgu
            // 
            this.colMaNgonNgu.DataPropertyName = "MaNgoaiNgu";
            this.colMaNgonNgu.HeaderText = "Mã Ngôn Ngữ";
            this.colMaNgonNgu.Name = "colMaNgonNgu";
            this.colMaNgonNgu.ReadOnly = true;
            // 
            // colTenNgonNgu
            // 
            this.colTenNgonNgu.DataPropertyName = "TenNgoaiNgu";
            this.colTenNgonNgu.HeaderText = "Tên Ngôn Ngữ";
            this.colTenNgonNgu.Name = "colTenNgonNgu";
            this.colTenNgonNgu.ReadOnly = true;
            this.colTenNgonNgu.Width = 300;
            // 
            // Frm_ThongTinNgonNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 276);
            this.Controls.Add(this.dgvNgonNgu);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Frm_ThongTinNgonNgu";
            this.Text = "Thông Tin Ngôn Ngữ";
            this.Load += new System.EventHandler(this.Frm_ThongTinNgonNgu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgonNgu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnSuu;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnEE;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.DataGridView dgvNgonNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNgonNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNgonNgu;
    }
}