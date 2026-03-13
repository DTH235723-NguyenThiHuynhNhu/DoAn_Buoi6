using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class BaoHiem
    {
        [Key]
        public int Id { get; set; }
        public string LoaiBH { get; set; } // BH Y tế, BH Xã hội
        public double MucDong { get; set; }

        public int MaNV { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }

}
