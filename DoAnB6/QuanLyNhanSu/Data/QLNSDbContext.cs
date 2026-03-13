using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyNhanSu.Data
{
    public class QLNSDbContext : DbContext
    {
        // Constructor mặc định (quan trọng cho EF Core khi migration)
        public QLNSDbContext() { }

        // Constructor cho khi truyền options (nếu dùng DI)
        public QLNSDbContext(DbContextOptions<QLNSDbContext> options) : base(options) { }

        // Cấu hình kết nối CSDL
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=LAPTOP-MIPBTPHJ\\SQLEXPRESS;Database=QuanLyNhanSuDB;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=60;",
                    sqlOptions => sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5,
                        maxRetryDelay: TimeSpan.FromSeconds(10),
                        errorNumbersToAdd: null
                    )
                );
            }
        }

        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<BaoHiem> BaoHiems { get; set; }
        public DbSet<ChamCong> ChamCongs { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<Luong> Luongs { get; set; }

    }
}
