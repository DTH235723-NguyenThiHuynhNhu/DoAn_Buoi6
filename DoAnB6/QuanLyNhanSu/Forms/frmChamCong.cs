using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyNhanSu.Data;
using ClosedXML.Excel;

namespace QuanLyNhanSu.Forms
{
    public partial class frmChamCong : Form
    {
        private BindingSource bindingSource = new BindingSource();
        QLNSDbContext context = new QLNSDbContext();
        int currentId = 0; // Thay cho biến id để tránh nhầm lẫn
        BindingList<DanhSachChamCong> dsChamCong = new BindingList<DanhSachChamCong>();
        public frmChamCong()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool trangThai)
        {
            cboMaNhanVien.Enabled = trangThai;
            dtpGioVao.Enabled = trangThai;
            dtpGioRa.Enabled = trangThai;
            dtpNgayLam.Enabled = trangThai;
            txtGhiChu.Enabled = trangThai;
            cboTrangThai.Enabled = trangThai;
            // txtMaChamCong và txtHoTen thường để ReadOnly
            txtMaChamCong.ReadOnly = true;
            txtHoTen.ReadOnly = true;
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dtpGioVao_ValueChanged(object sender, EventArgs e)
        {

        }
        private void frmChamCong_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            // Load Combobox Nhân viên
            cboMaNhanVien.DataSource = context.NhanViens.ToList();
            cboMaNhanVien.DisplayMember = "Id"; // Hoặc MaNhanVien tùy DB
            cboMaNhanVien.ValueMember = "Id";
            cboMaNhanVien.SelectedIndex = -1;

            // Load Combobox Trạng thái
            cboTrangThai.DataSource = new List<string> { "Có mặt", "Nghỉ có phép", "Nghỉ không phép" };
            cboTrangThai.SelectedIndex = -1;

            // Load dữ liệu mặc định ngày hôm nay
            LoadDanhSachChamCong(dtpChonNgay.Value);

            // Cấu hình DataGridView
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Mã CC", Name = "colId", Width = 60 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaNhanVien", HeaderText = "Mã NV", Name = "colMaNV", Width = 70 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTen", HeaderText = "Họ Tên", Name = "colHoTen", Width = 150 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Ngay", HeaderText = "Ngày", Name = "colNgay" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "GioVao", HeaderText = "Giờ Vào", Name = "colGioVao" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "GioRa", HeaderText = "Giờ Ra", Name = "colGioRa" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TrangThai", HeaderText = "Trạng Thái", Name = "colTrangThai" });

            dataGridView.DataSource = bindingSource;
        }

        private void LoadDanhSachChamCong(DateTime ngay)
        {
            var query = context.ChamCongs
                .Include(c => c.NhanVien)
                .Where(c => c.Ngay.Date == ngay.Date)
                .Select(c => new DanhSachChamCong
                {
                    Id = c.Id,
                    MaNhanVien = c.NhanVien.Id,
                    HoTen = c.NhanVien.HoTen,
                    Ngay = c.Ngay,
                    GioVao = c.GioVao,
                    GioRa = c.GioRa,
                    TrangThai = c.TrangThai ?? "Có mặt",
                    GhiChu = c.GhiChu
                }).ToList();

            dsChamCong = new BindingList<DanhSachChamCong>(query);
            bindingSource.DataSource = dsChamCong;
            BindControls();
        }

        private void BindControls()
        {
            txtMaChamCong.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();
            dtpNgayLam.DataBindings.Clear();
            dtpGioVao.DataBindings.Clear();
            dtpGioRa.DataBindings.Clear();

            if (bindingSource.Count > 0)
            {
                txtMaChamCong.DataBindings.Add("Text", bindingSource, "Id");
                txtHoTen.DataBindings.Add("Text", bindingSource, "HoTen");
                txtGhiChu.DataBindings.Add("Text", bindingSource, "GhiChu");
                dtpNgayLam.DataBindings.Add("Value", bindingSource, "Ngay");
                dtpGioVao.DataBindings.Add("Value", bindingSource, "GioVao");
                dtpGioRa.DataBindings.Add("Value", bindingSource, "GioRa");

                // Cập nhật ComboBox tương ứng
                var current = (DanhSachChamCong)bindingSource.Current;
                cboMaNhanVien.SelectedValue = current.MaNhanVien;
                cboTrangThai.SelectedItem = current.TrangThai;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            currentId = 0; // Chế độ thêm mới
            txtMaChamCong.Text = "Tự động";
            txtHoTen.Clear();
            txtGhiChu.Clear();
            cboMaNhanVien.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboMaNhanVien.SelectedValue == null) return;

            int nvid = (int)cboMaNhanVien.SelectedValue;
            DateTime ngay = dtpNgayLam.Value.Date;

            if (currentId == 0) // Thêm mới
            {
                var moi = new ChamCong
                {
                    NhanVienId = nvid,
                    Ngay = ngay,
                    GioVao = dtpGioVao.Value,
                    GioRa = dtpGioRa.Value,
                    TrangThai = cboTrangThai.Text,
                    GhiChu = txtGhiChu.Text
                };
                context.ChamCongs.Add(moi);
            }
            else // Sửa
            {
                var sua = context.ChamCongs.Find(currentId);
                if (sua != null)
                {
                    sua.TrangThai = cboTrangThai.Text;
                    sua.GhiChu = txtGhiChu.Text;
                    sua.GioVao = dtpGioVao.Value;
                    sua.GioRa = dtpGioRa.Value;
                }
            }
            context.SaveChanges();
            LoadDanhSachChamCong(dtpChonNgay.Value);
            BatTatChucNang(false);
            MessageBox.Show("Đã lưu thành công!");
        }

        // --- CODE MẪU BUỔI 05: XUẤT EXCEL ---
        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Mã NV", typeof(int));
                    dt.Columns.Add("Họ Tên", typeof(string));
                    dt.Columns.Add("Ngày", typeof(DateTime));
                    dt.Columns.Add("Trạng Thái", typeof(string));

                    foreach (var item in dsChamCong)
                        dt.Rows.Add(item.MaNhanVien, item.HoTen, item.Ngay, item.TrangThai);

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(dt, "ChamCong");
                        wb.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show("Xuất Excel thành công!");
                }
            }
        }

        // --- CODE MẪU BUỔI 05: NHẬP EXCEL ---
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook wb = new XLWorkbook(ofd.FileName))
                {
                    var sheet = wb.Worksheet(1);
                    var rows = sheet.RangeUsed().RowsUsed().Skip(1);
                    foreach (var row in rows)
                    {
                        int maNV = row.Cell(1).GetValue<int>();
                        // Logic thêm vào DB tương tự nút Lưu...
                    }
                }
                context.SaveChanges();
                LoadDanhSachChamCong(dtpChonNgay.Value);
            }
        }

        private void dtpChonNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSachChamCong(dtpChonNgay.Value);
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                currentId = (int)dataGridView.CurrentRow.Cells["colId"].Value;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e) => frmChamCong_Load(sender, e);
        private void btnThoat_Click(object sender, EventArgs e) => this.Close();
    }

    // Class phụ trợ để hiển thị lên lưới
    public class DanhSachChamCong
    {
        public int Id { get; set; }
        public int MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime Ngay { get; set; }
        public DateTime GioVao { get; set; }
        public DateTime GioRa { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }
    }
}
