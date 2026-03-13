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
using BC = BCrypt.Net.BCrypt;

namespace QuanLyNhanSu.Forms
{
    public partial class frmTaiKhoan : Form
    {
        QLNSDbContext context = new QLNSDbContext();
        bool xuLyThem = false;
        int maTKDangChon = 0;
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool trangThai)
        {
            btnLuu.Enabled = trangThai;
            btnHuyBo.Enabled = trangThai;

            // Mã tài khoản thường là tự tăng nên để ReadOnly
            txtMaTaiKhoan.ReadOnly = true;
            txtHoTen.Enabled = trangThai;
            txtTenDangNhap.Enabled = trangThai;
            txtMatKhau.Enabled = trangThai;
            cboQuyenHan.Enabled = trangThai;
            txtGhiChu.Enabled = trangThai;

            btnThem.Enabled = !trangThai;
            btnSua.Enabled = !trangThai;
            btnXoa.Enabled = !trangThai;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            // Thiết kế danh sách quyền hạn cho ComboBox
            cboQuyenHan.Items.Clear();
            cboQuyenHan.Items.Add("Admin");
            cboQuyenHan.Items.Add("User");

            LoadData();
            BatTatChucNang(false);
        }

        // 2. Hàm Load dữ liệu lên Grid và Binding vào TextBox
        private void LoadData()
        {
            // Làm mới dữ liệu từ DB
            context = new QLNSDbContext();
            var danhSach = context.TaiKhoans.ToList();

            // Sử dụng BindingSource để khi chọn dòng trên Grid, TextBox tự nhảy theo
            BindingSource bs = new BindingSource();
            bs.DataSource = danhSach;
            dataGridView.DataSource = bs;

            // Xóa các liên kết cũ và tạo liên kết mới cho TextBox
            txtMaTaiKhoan.DataBindings.Clear();
            txtMaTaiKhoan.DataBindings.Add("Text", bs, "MaTaiKhoan", true, DataSourceUpdateMode.Never);

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", bs, "HoTen", true, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bs, "TenDangNhap", true, DataSourceUpdateMode.Never);

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", bs, "MatKhau", true, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("Text", bs, "QuyenHan", true, DataSourceUpdateMode.Never);

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", bs, "GhiChu", true, DataSourceUpdateMode.Never);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtMaTaiKhoan.Text = "Tự động";
            txtHoTen.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtGhiChu.Clear();
            cboQuyenHan.SelectedIndex = 1; // Mặc định là User

            txtHoTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            // Lưu lại ID đang chọn để tí nữa Update
            maTKDangChon = Convert.ToInt32(dataGridView.CurrentRow.Cells["MaTaiKhoan"].Value);
            txtTenDangNhap.Enabled = false; // Không cho sửa tên đăng nhập để tránh lỗi
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu cơ bản
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng không để trống Tên đăng nhập và Mật khẩu!");
                return;
            }

            if (xuLyThem)
            {
                // Thêm mới tài khoản
                TaiKhoan tk = new TaiKhoan
                {
                    HoTen = txtHoTen.Text,
                    TenDangNhap = txtTenDangNhap.Text,
                    // Mã hóa mật khẩu trước khi lưu vào DB
                    MatKhau = BC.HashPassword(txtMatKhau.Text),
                    QuyenHan = cboQuyenHan.Text,
                    GhiChu = txtGhiChu.Text
                };
                context.TaiKhoans.Add(tk);
            }
            else
            {
                // Cập nhật tài khoản cũ
                var tk = context.TaiKhoans.Find(maTKDangChon);
                if (tk != null)
                {
                    tk.HoTen = txtHoTen.Text;
                    tk.QuyenHan = cboQuyenHan.Text;
                    tk.GhiChu = txtGhiChu.Text;

                    // Nếu người dùng nhập mật khẩu mới (không phải dạng đã mã hóa) thì mới hash lại
                    if (!txtMatKhau.Text.StartsWith("$2a$") && !string.IsNullOrEmpty(txtMatKhau.Text))
                    {
                        tk.MatKhau = BC.HashPassword(txtMatKhau.Text);
                    }
                }
            }

            context.SaveChanges();
            MessageBox.Show("Đã lưu thông tin tài khoản!");
            LoadData();
            BatTatChucNang(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["MaTaiKhoan"].Value);
            if (MessageBox.Show("Bạn có muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var tk = context.TaiKhoans.Find(id);
                if (tk != null)
                {
                    context.TaiKhoans.Remove(tk);
                    context.SaveChanges();
                    LoadData();
                }
            }
        }

        // Hàm này giúp hiện dấu * cho cột mật khẩu trên lưới cho chuyên nghiệp
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "MatKhau" && e.Value != null)
            {
                e.Value = new string('*', 8);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e) => BatTatChucNang(false);
        private void btnThoat_Click(object sender, EventArgs e) => this.Close();
    }
}