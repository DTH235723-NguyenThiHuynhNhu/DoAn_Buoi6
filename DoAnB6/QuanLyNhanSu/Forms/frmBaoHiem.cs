using QuanLyNhanSu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class frmBaoHiem : Form
    {
        QLNSDbContext context = new QLNSDbContext();
        bool xuLyThem = false;
        public frmBaoHiem()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool trangThai)
        {
            btnLuu.Enabled = trangThai;
            btnHuyBo.Enabled = trangThai;

            cboNhanVien.Enabled = trangThai;
            txtLoaiBH.Enabled = trangThai;
            numMucDong.Enabled = trangThai;

            btnThem.Enabled = !trangThai;
            btnSua.Enabled = !trangThai;
            btnXoa.Enabled = !trangThai;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmBaoHiem_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }
        private void LoadData()
        {
            // 1. Load ComboBox Nhân viên
            cboNhanVien.DataSource = context.NhanViens.ToList();
            cboNhanVien.DisplayMember = "TenNV"; // Thay bằng tên cột thực tế trong table NhanVien
            cboNhanVien.ValueMember = "Id";

            // 2. Load DataGridView kèm thông tin Nhân viên
            var danhSach = context.BaoHiems
                .Select(b => new
                {
                    Id = b.Id,
                    TenNV = b.NhanVien.HoTen, // Lấy tên từ bảng liên kết
                    LoaiBH = b.LoaiBH,
                    MucDong = b.MucDong,
                    MaNV = b.MaNV // Giữ MaNV để binding ComboBox
                }).ToList();

            // Dùng BindingSource để đồng bộ các Control
            BindingSource bs = new BindingSource();
            bs.DataSource = danhSach;

            // Clear và gán DataBindings (Cách làm của form cũ bạn gửi)
            txtMaBaoHiem.DataBindings.Clear();
            txtMaBaoHiem.DataBindings.Add("Text", bs, "Id", false, DataSourceUpdateMode.Never);

            txtLoaiBH.DataBindings.Clear();
            txtLoaiBH.DataBindings.Add("Text", bs, "LoaiBH", false, DataSourceUpdateMode.Never);

            numMucDong.DataBindings.Clear();
            numMucDong.DataBindings.Add("Value", bs, "MucDong", false, DataSourceUpdateMode.Never);

            // Đồng bộ ComboBox khi chọn dòng trên Grid
            cboNhanVien.DataBindings.Clear();
            cboNhanVien.DataBindings.Add("SelectedValue", bs, "MaNV", false, DataSourceUpdateMode.Never);

            dgvBaoHiem.DataSource = bs;

            // Ẩn cột MaNV trên Grid cho đẹp
            if (dgvBaoHiem.Columns["MaNV"] != null) dgvBaoHiem.Columns["MaNV"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtMaBaoHiem.Clear();
            txtLoaiBH.Clear();
            numMucDong.Value = 0;
            cboNhanVien.SelectedIndex = -1;
            txtLoaiBH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvBaoHiem.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtLoaiBH.Text) || cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    BaoHiem bh = new BaoHiem
                    {
                        LoaiBH = txtLoaiBH.Text,
                        MucDong = (double)numMucDong.Value,
                        MaNV = (int)cboNhanVien.SelectedValue
                    };
                    context.BaoHiems.Add(bh);
                }
                else
                {
                    int id = Convert.ToInt32(txtMaBaoHiem.Text);
                    var bh = context.BaoHiems.Find(id);
                    if (bh != null)
                    {
                        bh.LoaiBH = txtLoaiBH.Text;
                        bh.MucDong = (double)numMucDong.Value;
                        bh.MaNV = (int)cboNhanVien.SelectedValue;
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo");
                LoadData();
                BatTatChucNang(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBaoHiem.Text)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtMaBaoHiem.Text);
                var bh = context.BaoHiems.Find(id);
                if (bh != null)
                {
                    context.BaoHiems.Remove(bh);
                    context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData(); // Load lại để quay về dòng đang chọn
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}