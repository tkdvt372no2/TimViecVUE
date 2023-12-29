using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimViec.Infrastructure.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThoiGianBD",
                table: "KinhNghiemLamViec");

            migrationBuilder.DropColumn(
                name: "ThoiGianKT",
                table: "KinhNghiemLamViec");

            migrationBuilder.DropColumn(
                name: "AnhDaiDien",
                table: "HoSoTimViec");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ThoiGianBD",
                table: "KinhNghiemLamViec",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ThoiGianKT",
                table: "KinhNghiemLamViec",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "AnhDaiDien",
                table: "HoSoTimViec",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
