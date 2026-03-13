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

    public partial class frmChucVu : Form
    {
        QLNSDbContext context = new QLNSDbContext();
        bool xuLyThem = false;
        BindingSource bindingSource = new BindingSource();
        public frmChucVu()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool trangThai)
        {
            btnLuu.Enabled = trangThai;
            btnHuyBo.Enabled = trangThai;

            txtTenChucVu.Enabled = trangThai;
            txtMoTa.Enabled = trangThai;
            txtMaChucVu.Enabled = false; // Mã luôn khóa vì tự tăng

            btnThem.Enabled = !trangThai;
            btnSua.Enabled = !trangThai;
            btnXoa.Enabled = !trangThai;
            dataGridView.Enabled = !trangThai;
        }
        private void LoadData()
        {
            // Lấy dữ liệu mới nhất từ DB
            var danhSach = context.ChucVus.ToList();
            bindingSource.DataSource = danhSach;
            dataGridView.DataSource = bindingSource;

            // Xóa các liên kết cũ để tránh lỗi chồng chéo
            txtMaChucVu.DataBindings.Clear();
            txtTenChucVu.DataBindings.Clear();
            txtMoTa.DataBindings.Clear();

            // Thiết lập Binding (Khi chọn dòng trên lưới, Textbox tự đổi)
            txtMaChucVu.DataBindings.Add("Text", bindingSource, "Id", true, DataSourceUpdateMode.Never);
            txtTenChucVu.DataBindings.Add("Text", bindingSource, "TenChucVu", true, DataSourceUpdateMode.Never);
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", true, DataSourceUpdateMode.Never);

            // Ẩn cột quan hệ nếu có
            if (dataGridView.Columns["NhanViens"] != null)
                dataGridView.Columns["NhanViens"].Visible = false;
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            LoadData();
            BatTatChucNang(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtMaChucVu.Text = "Tự tăng";
            txtTenChucVu.Clear();
            txtMoTa.Clear();
            txtTenChucVu.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
            txtTenChucVu.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenChucVu.Text))
            {
                MessageBox.Show("Vui lòng nhập tên chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    // Thêm mới
                    ChucVu cv = new ChucVu
                    {
                        TenChucVu = txtTenChucVu.Text,
                        MoTa = txtMoTa.Text,
                        HeSoPhuCap = 0
                    };
                    context.ChucVus.Add(cv);
                }
                else
                {
                    // Cập nhật
                    int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
                    var cv = context.ChucVus.Find(id);
                    if (cv != null)
                    {
                        cv.TenChucVu = txtTenChucVu.Text;
                        cv.MoTa = txtMoTa.Text;
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công!", "Thông báo");
                LoadData();
                BatTatChucNang(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
            string ten = dataGridView.CurrentRow.Cells["TenChucVu"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa chức vụ '{ten}'?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var cv = context.ChucVus.Find(id);
                    if (cv != null)
                    {
                        context.ChucVus.Remove(cv);
                        context.SaveChanges();
                        LoadData();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa vì chức vụ này đã có nhân viên!", "Lỗi khóa ngoại");
                }
            }

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            LoadData();
            BatTatChucNang(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
