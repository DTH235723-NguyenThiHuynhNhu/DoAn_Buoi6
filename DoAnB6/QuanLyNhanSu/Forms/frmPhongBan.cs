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
    public partial class frmPhongBan : Form
    {
        QLNSDbContext context = new QLNSDbContext();
        bool xuLyThem = false;
        public frmPhongBan()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool trangThai)
        {
            btnLuu.Enabled = trangThai;
            btnHuyBo.Enabled = trangThai;
            txtTenPhong.Enabled = trangThai;
            txtMoTa.Enabled = trangThai;
            txtMaPhong.Enabled = false; // Luôn khóa mã tự tăng

            btnThem.Enabled = !trangThai;
            btnSua.Enabled = !trangThai;
            btnXoa.Enabled = !trangThai;
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }

        private void LoadData()
        {
            // Lấy dữ liệu từ bảng PhongBans mới
            dataGridView.DataSource = context.PhongBans.ToList();
            if (dataGridView.Columns["NhanViens"] != null)
                dataGridView.Columns["NhanViens"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtMoTa.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (xuLyThem)
            {
                context.PhongBans.Add(new PhongBan
                {
                    TenPhongBan = txtTenPhong.Text,
                    MoTa = txtMoTa.Text
                });
            }
            else
            {
                int id = int.Parse(txtMaPhong.Text);
                var pb = context.PhongBans.Find(id);
                if (pb != null)
                {
                    pb.TenPhongBan = txtTenPhong.Text;
                    pb.MoTa = txtMoTa.Text;
                }
            }
            context.SaveChanges();
            LoadData();
            BatTatChucNang(false);
        }
    }
}
