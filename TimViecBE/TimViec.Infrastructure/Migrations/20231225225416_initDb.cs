using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimViec.Infrastructure.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CongTy",
                columns: table => new
                {
                    CongTyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuocGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "https://freedesignfile.com/upload/2017/08/White-office-space-meeting-room-table-Stock-Photo-16.jpg"),
                    SoLuoc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongTy", x => x.CongTyId);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    TaiKhoanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "https://www.pngkit.com/png/full/88-885453_login-white-on-clear-user-icon.png"),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.TaiKhoanId);
                });

            migrationBuilder.CreateTable(
                name: "CongViec",
                columns: table => new
                {
                    CongViecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongViec = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NganhNghe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapBac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KinhNghiem = table.Column<float>(type: "real", nullable: false),
                    MucLuong = table.Column<int>(type: "int", nullable: false),
                    HocVan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiCongViec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaDiem = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CongTyId = table.Column<int>(type: "int", nullable: false),
                    HanNop = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongViec", x => x.CongViecId);
                    table.ForeignKey(
                        name: "FK_CongViec_CongTy_CongTyId",
                        column: x => x.CongTyId,
                        principalTable: "CongTy",
                        principalColumn: "CongTyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CongViec_TaiKhoan_TaiKhoanId",
                        column: x => x.TaiKhoanId,
                        principalTable: "TaiKhoan",
                        principalColumn: "TaiKhoanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoSoTimViec",
                columns: table => new
                {
                    HoSoTimViecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnhDaiDien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngay = table.Column<int>(type: "int", nullable: false),
                    Thang = table.Column<int>(type: "int", nullable: false),
                    Nam = table.Column<int>(type: "int", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MucTieuNgheNghiep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaiKhoanId = table.Column<int>(type: "int", nullable: false),
                    KinhNghiemLamViecId = table.Column<int>(type: "int", nullable: false),
                    HocVanId = table.Column<int>(type: "int", nullable: false),
                    ChungChiId = table.Column<int>(type: "int", nullable: false),
                    NgoaiNguId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSoTimViec", x => x.HoSoTimViecId);
                    table.ForeignKey(
                        name: "FK_HoSoTimViec_TaiKhoan_TaiKhoanId",
                        column: x => x.TaiKhoanId,
                        principalTable: "TaiKhoan",
                        principalColumn: "TaiKhoanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ViecLam",
                columns: table => new
                {
                    ViecLamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViecLamNop = table.Column<int>(type: "int", nullable: false),
                    TaiKhoanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViecLam", x => x.ViecLamId);
                    table.ForeignKey(
                        name: "FK_ViecLam_TaiKhoan_TaiKhoanId",
                        column: x => x.TaiKhoanId,
                        principalTable: "TaiKhoan",
                        principalColumn: "TaiKhoanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CongViecDaNop",
                columns: table => new
                {
                    CongViecDaNopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdNguoiNop = table.Column<int>(type: "int", nullable: false),
                    CongViecId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongViecDaNop", x => x.CongViecDaNopId);
                    table.ForeignKey(
                        name: "FK_CongViecDaNop_CongViec_CongViecId",
                        column: x => x.CongViecId,
                        principalTable: "CongViec",
                        principalColumn: "CongViecId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChungChi",
                columns: table => new
                {
                    ChungChiId = table.Column<int>(type: "int", nullable: false),
                    TenChungChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapBoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoSoTimViecId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChungChi", x => x.ChungChiId);
                    table.ForeignKey(
                        name: "FK_ChungChi_HoSoTimViec_ChungChiId",
                        column: x => x.ChungChiId,
                        principalTable: "HoSoTimViec",
                        principalColumn: "HoSoTimViecId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HocVan",
                columns: table => new
                {
                    HocVanId = table.Column<int>(type: "int", nullable: false),
                    TenTruong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BangCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoSoTimViecId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVan", x => x.HocVanId);
                    table.ForeignKey(
                        name: "FK_HocVan_HoSoTimViec_HocVanId",
                        column: x => x.HocVanId,
                        principalTable: "HoSoTimViec",
                        principalColumn: "HoSoTimViecId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    ThoiGianBD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKT = table.Column<DateTime>(type: "datetime2", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "NgoaiNgu",
                columns: table => new
                {
                    NgoaiNguId = table.Column<int>(type: "int", nullable: false),
                    NgonNgu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrinhDo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChungChiNgoaiNgu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoSoTimViecId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NgoaiNgu", x => x.NgoaiNguId);
                    table.ForeignKey(
                        name: "FK_NgoaiNgu_HoSoTimViec_NgoaiNguId",
                        column: x => x.NgoaiNguId,
                        principalTable: "HoSoTimViec",
                        principalColumn: "HoSoTimViecId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CongViec_CongTyId",
                table: "CongViec",
                column: "CongTyId");

            migrationBuilder.CreateIndex(
                name: "IX_CongViec_TaiKhoanId",
                table: "CongViec",
                column: "TaiKhoanId");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecDaNop_CongViecId",
                table: "CongViecDaNop",
                column: "CongViecId");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoTimViec_TaiKhoanId",
                table: "HoSoTimViec",
                column: "TaiKhoanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KinhNghiemLamViec_KinhNghiemLamViecId",
                table: "KinhNghiemLamViec",
                column: "KinhNghiemLamViecId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_UserName",
                table: "TaiKhoan",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ViecLam_TaiKhoanId",
                table: "ViecLam",
                column: "TaiKhoanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChungChi");

            migrationBuilder.DropTable(
                name: "CongViecDaNop");

            migrationBuilder.DropTable(
                name: "HocVan");

            migrationBuilder.DropTable(
                name: "KinhNghiemLamViec");

            migrationBuilder.DropTable(
                name: "NgoaiNgu");

            migrationBuilder.DropTable(
                name: "ViecLam");

            migrationBuilder.DropTable(
                name: "CongViec");

            migrationBuilder.DropTable(
                name: "HoSoTimViec");

            migrationBuilder.DropTable(
                name: "CongTy");

            migrationBuilder.DropTable(
                name: "TaiKhoan");
        }
    }
}
