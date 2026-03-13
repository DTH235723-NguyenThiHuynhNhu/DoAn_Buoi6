using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhanSu.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBaoHiemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LoaiBaoHiem",
                table: "BaoHiems",
                newName: "LoaiBH");

            migrationBuilder.AddColumn<int>(
                name: "MaNV",
                table: "BaoHiems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaNV",
                table: "BaoHiems");

            migrationBuilder.RenameColumn(
                name: "LoaiBH",
                table: "BaoHiems",
                newName: "LoaiBaoHiem");
        }
    }
}
