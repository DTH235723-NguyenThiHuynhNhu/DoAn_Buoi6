using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using QuanLyNhanSu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class frmLuong : Form
    {
        QLNSDbContext context = new QLNSDbContext();
        bool xuLyThem = false;
        int currentMaLuong = 0;
        public frmLuong()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool trangThai)
        {
            // Các nút điều khiển nhập liệu
            btnLuu.Enabled = trangThai;
            btnHuyBo.Enabled = trangThai;

            cboMaNhanVien.Enabled = trangThai;
            txtHeSoLuong.Enabled = trangThai;
            txtLuongCoBan.Enabled = trangThai;
            dtpThangNam.Enabled = trangThai;

            // Phân quyền: Chỉ Quản lý mới thấy các nút này sáng lên khi không ở chế độ nhập
            // Nếu bạn muốn áp dụng phân quyền Buổi 06 vào đây:
            bool laQuanLy = true;
            if (laQuanLy)
            {
                btnThem.Enabled = !trangThai;
                btnSua.Enabled = !trangThai;
                btnXoa.Enabled = !trangThai;
                btnImport.Enabled = !trangThai;
            }
            else
            {
                // Nếu là nhân viên thường: Khóa hết các nút chỉnh sửa
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnImport.Enabled = false;
            }

            txtMaLuong.ReadOnly = true; // Mã lương luôn tự tăng, không cho sửa
        }

        private void frmluong_Load(object sender, EventArgs e)
        {
            LoadData();

            // Load danh sách nhân viên vào Combobox
            cboMaNhanVien.DataSource = context.NhanViens.ToList();
            cboMaNhanVien.DisplayMember = "HoTen"; // Hiển thị tên cho dễ chọn
            cboMaNhanVien.ValueMember = "Id";
            cboMaNhanVien.SelectedIndex = -1;

            BatTatChucNang(false);
        }

        private void LoadData()
        {
            // Reset context để lấy data mới nhất
            context = new QLNSDbContext();

            var danhSach = context.Luongs
                .Include(l => l.NhanVien)
                .Select(l => new
                {
                    l.Id, // Giả sử trong DB bạn đặt là Id thay vì MaLuong
                    l.NhanVienId,
                    HoTen = l.NhanVien.HoTen,
                    l.HeSoLuong,
                    l.LuongCoBan,
                    ThangNam = l.ThangNam.ToString("MM/yyyy") // Format lại ngày hiển thị
                }).ToList();

            dataGridView.DataSource = danhSach;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtMaLuong.Text = "Tự động";
            txtHeSoLuong.Clear();
            txtLuongCoBan.Clear();
            cboMaNhanVien.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboMaNhanVien.SelectedValue == null) return;

                int nvId = (int)cboMaNhanVien.SelectedValue;
                float heSo = float.Parse(txtHeSoLuong.Text);
                decimal luongCB = decimal.Parse(txtLuongCoBan.Text);
                DateTime ngay = dtpThangNam.Value;

                if (xuLyThem)
                {
                    // Kiểm tra trùng lương tháng đó
                    bool trung = context.Luongs.Any(l => l.NhanVienId == nvId && l.ThangNam.Month == ngay.Month && l.ThangNam.Year == ngay.Year);
                    if (trung)
                    {
                        MessageBox.Show("Nhân viên này đã có bảng lương tháng này rồi!");
                        return;
                    }

                    var moi = new Luong
                    {
                        NhanVienId = nvId,
                        HeSoLuong = heSo,
                        LuongCoBan = (double)luongCB,
                        ThangNam = ngay
                    };
                    context.Luongs.Add(moi);
                }
                else
                {
                    var sua = context.Luongs.Find(currentMaLuong);
                    if (sua != null)
                    {
                        sua.HeSoLuong = heSo;
                        sua.LuongCoBan = (double)luongCB;
                        sua.ThangNam = ngay;
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công!");
                frmluong_Load(sender, e);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                currentMaLuong = (int)dataGridView.CurrentRow.Cells[0].Value;
                txtMaLuong.Text = currentMaLuong.ToString();
                txtHeSoLuong.Text = dataGridView.CurrentRow.Cells["HeSoLuong"].Value.ToString();
                txtLuongCoBan.Text = dataGridView.CurrentRow.Cells["LuongCoBan"].Value.ToString();
                cboMaNhanVien.SelectedValue = dataGridView.CurrentRow.Cells["NhanVienId"].Value;

                // Hiển thị họ tên lên label/textbox
                txtHoTen.Text = dataGridView.CurrentRow.Cells["HoTen"].Value.ToString();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "BangLuong.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var ws = workbook.Worksheets.Add("Lương");
                        ws.Cell(1, 1).Value = "Họ Tên";
                        ws.Cell(1, 2).Value = "Hệ Số";
                        ws.Cell(1, 3).Value = "Lương CB";
                        ws.Cell(1, 4).Value = "Tháng";

                        int row = 2;
                        foreach (DataGridViewRow dgr in dataGridView.Rows)
                        {
                            if (dgr.Cells["HoTen"].Value == null) continue;
                            ws.Cell(row, 1).Value = dgr.Cells["HoTen"].Value.ToString();
                            ws.Cell(row, 2).Value = dgr.Cells["HeSoLuong"].Value.ToString();
                            ws.Cell(row, 3).Value = dgr.Cells["LuongCoBan"].Value.ToString();
                            ws.Cell(row, 4).Value = dgr.Cells["ThangNam"].Value.ToString();
                            row++;
                        }
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Xuất file thành công!");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (currentMaLuong > 0 && MessageBox.Show("Xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var xoa = context.Luongs.Find(currentMaLuong);
                if (xoa != null)
                {
                    context.Luongs.Remove(xoa);
                    context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (currentMaLuong > 0)
            {
                xuLyThem = false;
                BatTatChucNang(true);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e) => BatTatChucNang(false);
        private void btnThoat_Click(object sender, EventArgs e) => this.Close();
    }
}

