using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class ChamCong
    {

        [Key]
        public int Id { get; set; }

        public DateTime Ngay { get; set; } // Trường này đang thiếu dẫn đến lỗi
        public DateTime GioVao { get; set; }
        public DateTime GioRa { get; set; }
        public string? TrangThai { get; set; }
        public string? GhiChu { get; set; }

        public int NhanVienId { get; set; } // Đảm bảo tên là NhanVienId
        public virtual NhanVien NhanVien { get; set; }

    }
}
