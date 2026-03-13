using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TaiKhoan
{
    [Key]
    public int MaTaiKhoan { get; set; } // Phải có MaTaiKhoan (int)

    [Required]
    public string TenDangNhap { get; set; }

    [Required]
    public string MatKhau { get; set; }

    public string HoTen { get; set; }
    public string QuyenHan { get; set; } // Phải có QuyenHan (string)
    public string GhiChu { get; set; }
}
