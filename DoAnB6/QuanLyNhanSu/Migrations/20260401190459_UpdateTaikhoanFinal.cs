using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhanSu.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTaikhoanFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TaiKhoans",
                table: "TaiKhoans");

            migrationBuilder.RenameColumn(
                name: "Quyen",
                table: "TaiKhoans",
                newName: "QuyenHan");

            migrationBuilder.AlterColumn<string>(
                name: "TenDangNhap",
                table: "TaiKhoans",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "MaTaiKhoan",
                table: "TaiKhoans",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "TaiKhoans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HoTen",
                table: "TaiKhoans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaiKhoans",
                table: "TaiKhoans",
                column: "MaTaiKhoan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TaiKhoans",
                table: "TaiKhoans");

            migrationBuilder.DropColumn(
                name: "MaTaiKhoan",
                table: "TaiKhoans");

            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "TaiKhoans");

            migrationBuilder.DropColumn(
                name: "HoTen",
                table: "TaiKhoans");

            migrationBuilder.RenameColumn(
                name: "QuyenHan",
                table: "TaiKhoans",
                newName: "Quyen");

            migrationBuilder.AlterColumn<string>(
                name: "TenDangNhap",
                table: "TaiKhoans",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaiKhoans",
                table: "TaiKhoans",
                column: "TenDangNhap");
        }
    }
}
