using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class PhongBan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TenPhongBan { get; set; }
        public string MoTa { get; set; }

        // Liên kết với nhân viên
        public ICollection<NhanVien> NhanViens { get; set; }
        
    }

}
