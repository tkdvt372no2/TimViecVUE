using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimViec.Infrastructure.Migrations
{
    public partial class update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KinhNghiemLamViec");

            migrationBuilder.DropColumn(
                name: "KinhNghiemLamViecId",
                table: "HoSoTimViec");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KinhNghiemLamViecId",
                table: "HoSoTimViec",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "KinhNghiemLamViec",
                columns: table => new
                {
                    HoSoTimViecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KinhNghiemLamViecId = table.Column<int>(type: "int", nullable: false),
                    ChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CongTy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiCongViec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTaCV = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KinhNghiemLamViec", x => x.HoSoTimViecId);
                    table.ForeignKey(
                        name: "FK_KinhNghiemLamViec_HoSoTimViec_KinhNghiemLamViecId",
                        column: x => x.KinhNghiemLamViecId,
                        principalTable: "HoSoTimViec",
                        principalColumn: "HoSoTimViecId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KinhNghiemLamViec_KinhNghiemLamViecId",
                table: "KinhNghiemLamViec",
                column: "KinhNghiemLamViecId",
                unique: true);
        }
    }
}
