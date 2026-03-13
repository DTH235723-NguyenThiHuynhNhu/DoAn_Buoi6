using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
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
using ClosedXML.Excel;

namespace QuanLyNhanSu.Forms
{
    public partial class frmNhanVien : Form
    {
        QLNSDbContext context = new QLNSDbContext();
        bool xuLyThem = false;
        int idSelected;
        string imagesFolder = Path.Combine(Application.StartupPath, "Images");
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool enable)
        {
            txtHoTen.Enabled = enable;
            txtDiaChi.Enabled = enable;
            txtDienThoai.Enabled = enable;
            txtCCCD.Enabled = enable;
            txtGioiTinh.Enabled = enable;
            dtpNgaySinh.Enabled = enable;
            dtpNgayVaoLam.Enabled = enable;
            cboChucVu.Enabled = enable;
            cboPhongBan.Enabled = enable;
            btnDoiAnh.Enabled = enable;

            btnLuu.Enabled = enable;
            btnHuyBo.Enabled = enable;

            btnThem.Enabled = !enable;
            btnSua.Enabled = !enable;
            btnXoa.Enabled = !enable;
            btnThoat.Enabled = !enable;
            btnXuat.Enabled = !enable;
            btnImport.Enabled = !enable;
        }
        private void LoadData()
        {
            // Sử dụng Include để lấy dữ liệu từ bảng liên quan
            var nvList = context.NhanViens
                .Include(n => n.ChucVu)
                .Include(n => n.PhongBan)
                .ToList();

            BindingSource bin = new BindingSource();
            bin.DataSource = nvList;
            dataGridView.DataSource = bin;

            // Xóa binding cũ trước khi add mới
            txtMaNV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtCCCD.DataBindings.Clear();
            txtGioiTinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Clear();
            dtpNgayVaoLam.DataBindings.Clear();
            cboChucVu.DataBindings.Clear();
            cboPhongBan.DataBindings.Clear();
            txtPath.DataBindings.Clear();

            // Thiết lập Binding
            txtMaNV.DataBindings.Add("Text", bin, "Id", true, DataSourceUpdateMode.Never);
            txtHoTen.DataBindings.Add("Text", bin, "HoTen", true, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", bin, "DiaChi", true, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Add("Text", bin, "SoDienThoai", true, DataSourceUpdateMode.Never);
            txtCCCD.DataBindings.Add("Text", bin, "CMND", true, DataSourceUpdateMode.Never);
            txtGioiTinh.DataBindings.Add("Text", bin, "GioiTinh", true, DataSourceUpdateMode.Never);
            dtpNgaySinh.DataBindings.Add("Value", bin, "NgaySinh", true, DataSourceUpdateMode.Never);
            dtpNgayVaoLam.DataBindings.Add("Value", bin, "NgayVaoLam", true, DataSourceUpdateMode.Never);

            // Binding ComboBox
            cboChucVu.DataBindings.Add("SelectedValue", bin, "ChucVuId", true, DataSourceUpdateMode.Never);
            cboPhongBan.DataBindings.Add("SelectedValue", bin, "PhongBanId", true, DataSourceUpdateMode.Never);

            // Binding Path ảnh để hiển thị lên PictureBox
            txtPath.DataBindings.Add("Text", bin, "HinhAnh", true, DataSourceUpdateMode.Never);
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu cho các ComboBox trước
            cboChucVu.DataSource = context.ChucVus.ToList();
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "Id";

            cboPhongBan.DataSource = context.PhongBans.ToList();
            cboPhongBan.DisplayMember = "TenPhongBan";
            cboPhongBan.ValueMember = "Id";

            LoadData();
            BatTatChucNang(false);
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Ảnh (*.jpg;*.png)|*.jpg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = ofd.FileName; // Lưu đường dẫn tạm
                    picHinhAnh.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPath.Text))
                {
                    picHinhAnh.Image = null;
                    return;
                }

                // Nếu là đường dẫn đầy đủ (khi đang chọn ảnh mới)
                if (File.Exists(txtPath.Text))
                {
                    picHinhAnh.ImageLocation = txtPath.Text;
                }
                else // Nếu chỉ là tên file (khi load từ DB)
                {
                    string fullPath = Path.Combine(imagesFolder, txtPath.Text);
                    if (File.Exists(fullPath)) picHinhAnh.ImageLocation = fullPath;
                    else picHinhAnh.Image = null;
                }
            }
            catch { picHinhAnh.Image = null; }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("V please enter Name!");
                return;
            }

            try
            {
                string tenFileAnh = "";
                // Nếu người dùng có chọn ảnh mới (đường dẫn chứa dấu \)
                if (txtPath.Text.Contains("\\"))
                {
                    tenFileAnh = Guid.NewGuid().ToString() + Path.GetExtension(txtPath.Text);
                    File.Copy(txtPath.Text, Path.Combine(imagesFolder, tenFileAnh), true);
                }
                else
                {
                    tenFileAnh = txtPath.Text; // Giữ nguyên tên cũ
                }

                if (xuLyThem)
                {
                    NhanVien nv = new NhanVien
                    {
                        HoTen = txtHoTen.Text,
                        NgaySinh = dtpNgaySinh.Value,
                        GioiTinh = txtGioiTinh.Text,
                        CMND = txtCCCD.Text,
                        NgayVaoLam = dtpNgayVaoLam.Value,
                        DiaChi = txtDiaChi.Text,
                        SoDienThoai = txtDienThoai.Text,
                        HinhAnh = tenFileAnh,
                        PhongBanId = (int)cboPhongBan.SelectedValue,
                        ChucVuId = (int)cboChucVu.SelectedValue
                    };
                    context.NhanViens.Add(nv);
                }
                else
                {
                    var nv = context.NhanViens.Find(int.Parse(txtMaNV.Text));
                    if (nv != null)
                    {
                        nv.HoTen = txtHoTen.Text;
                        nv.NgaySinh = dtpNgaySinh.Value;
                        nv.GioiTinh = txtGioiTinh.Text;
                        nv.CMND = txtCCCD.Text;
                        nv.NgayVaoLam = dtpNgayVaoLam.Value;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.SoDienThoai = txtDienThoai.Text;
                        nv.HinhAnh = tenFileAnh;
                        nv.PhongBanId = (int)cboPhongBan.SelectedValue;
                        nv.ChucVuId = (int)cboChucVu.SelectedValue;
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công!");
                LoadData();
                BatTatChucNang(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtMaNV.Text = "0";
            txtHoTen.Clear();
            txtPath.Clear();
            txtHoTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text)) return;
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text)) return;
            if (MessageBox.Show("Xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var nv = context.NhanViens.Find(int.Parse(txtMaNV.Text));
                if (nv != null)
                {
                    context.NhanViens.Remove(nv);
                    context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(false);
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy danh sách nhân viên kèm thông tin Phòng ban, Chức vụ
                var nvList = context.NhanViens.Include(n => n.ChucVu).Include(n => n.PhongBan).ToList();

                using (var workbook = new XLWorkbook())
                {
                    var ws = workbook.Worksheets.Add("NhanVien");

                    // 1. Tạo tiêu đề cột
                    string[] headers = { "Mã NV", "Họ Tên", "Ngày Sinh", "Giới Tính", "CCCD", "Ngày Vào Làm", "Địa Chỉ", "SĐT", "Phòng Ban", "Chức Vụ" };
                    for (int i = 0; i < headers.Length; i++)
                    {
                        ws.Cell(1, i + 1).Value = headers[i];
                        ws.Cell(1, i + 1).Style.Font.Bold = true;
                        ws.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                    }

                    // 2. Điền dữ liệu
                    int row = 2;
                    foreach (var nv in nvList)
                    {
                        ws.Cell(row, 1).Value = nv.Id;
                        ws.Cell(row, 2).Value = nv.HoTen;
                        ws.Cell(row, 3).Value = nv.NgaySinh.ToShortDateString();
                        ws.Cell(row, 4).Value = nv.GioiTinh;
                        ws.Cell(row, 5).Value = nv.CMND;
                        ws.Cell(row, 6).Value = nv.NgayVaoLam.ToShortDateString();
                        ws.Cell(row, 7).Value = nv.DiaChi;
                        ws.Cell(row, 8).Value = nv.SoDienThoai;
                        ws.Cell(row, 9).Value = nv.PhongBan?.TenPhongBan;
                        ws.Cell(row, 10).Value = nv.ChucVu?.TenChucVu;
                        row++;
                    }

                    ws.Columns().AdjustToContents(); // Tự căn chỉnh độ rộng cột

                    // 3. Lưu file
                    SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Files|*.xlsx", FileName = "DanhSachNhanVien.xlsx" };
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }
    }
}
