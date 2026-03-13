using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhanSu.Migrations
{
    /// <inheritdoc />
    public partial class UpdateChamCong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nam",
                table: "ChamCongs");

            migrationBuilder.DropColumn(
                name: "SoNgayCong",
                table: "ChamCongs");

            migrationBuilder.DropColumn(
                name: "Thang",
                table: "ChamCongs");

            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "ChamCongs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GioRa",
                table: "ChamCongs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "GioVao",
                table: "ChamCongs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Ngay",
                table: "ChamCongs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "ChamCongs",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "ChamCongs");

            migrationBuilder.DropColumn(
                name: "GioRa",
                table: "ChamCongs");

            migrationBuilder.DropColumn(
                name: "GioVao",
                table: "ChamCongs");

            migrationBuilder.DropColumn(
                name: "Ngay",
                table: "ChamCongs");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "ChamCongs");

            migrationBuilder.AddColumn<int>(
                name: "Nam",
                table: "ChamCongs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoNgayCong",
                table: "ChamCongs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Thang",
                table: "ChamCongs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
