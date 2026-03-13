using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class ChucVu
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string TenChucVu { get; set; }

        // Thêm trường MoTa để khớp với giao diện bạn đang làm
        public string MoTa { get; set; }

        // Giữ lại trường này nếu bạn vẫn muốn quản lý phụ cấp lương
        public double HeSoPhuCap { get; set; }

        // Quan hệ 1 - Nhiều với bảng NhanVien
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }

}
