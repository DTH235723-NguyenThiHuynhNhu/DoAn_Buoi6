using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class NhanVien
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }

        public string GioiTinh { get; set; }

        public string SoDienThoai { get; set; }

        // --- CÁC TRƯỜNG BẠN ĐANG THIẾU DẪN ĐẾN GẠCH ĐỎ ---
        public string CMND { get; set; } // Ngăn đựng CCCD/CMND
        public DateTime NgayVaoLam { get; set; } // Ngăn đựng ngày vào làm
        public string DiaChi { get; set; } // Ngăn đựng địa chỉ
        public string HinhAnh { get; set; } // Ngăn đựng tên file ảnh
        // ------------------------------------------------

        public int PhongBanId { get; set; }
        public virtual PhongBan PhongBan { get; set; }

        public int ChucVuId { get; set; }
        public virtual ChucVu ChucVu { get; set; }

        public virtual ICollection<ChamCong> ChamCongs { get; set; }
        public virtual ICollection<Luong> Luongs { get; set; }
    }
}