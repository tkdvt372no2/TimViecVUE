﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimViec.Infrastructure.Context;

#nullable disable

namespace TimViec.Infrastructure.Migrations
{
    [DbContext(typeof(TimViecContext))]
    partial class TimViecContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TimViec.Domain.Entities.NguoiTimViec.ChungChi", b =>
                {
                    b.Property<int>("ChungChiId")
                        .HasColumnType("int");

                    b.Property<string>("CapBoi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HoSoTimViecId")
                        .HasColumnType("int");

                    b.Property<string>("TenChungChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChungChiId");

                    b.ToTable("ChungChi", (string)null);
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NguoiTimViec.HocVan", b =>
                {
                    b.Property<int>("HocVanId")
                        .HasColumnType("int");

                    b.Property<string>("BangCap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HoSoTimViecId")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTruong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HocVanId");

                    b.ToTable("HocVan", (string)null);
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NguoiTimViec.HoSoTimViec", b =>
                {
                    b.Property<int>("HoSoTimViecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HoSoTimViecId"), 1L, 1);

                    b.Property<int>("ChungChiId")
                        .HasColumnType("int");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HocVanId")
                        .HasColumnType("int");

                    b.Property<string>("MucTieuNgheNghiep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nam")
                        .HasColumnType("int");

                    b.Property<int>("Ngay")
                        .HasColumnType("int");

                    b.Property<int>("NgoaiNguId")
                        .HasColumnType("int");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaiKhoanId")
                        .HasColumnType("int");

                    b.Property<int>("Thang")
                        .HasColumnType("int");

                    b.HasKey("HoSoTimViecId");

                    b.HasIndex("TaiKhoanId")
                        .IsUnique();

                    b.ToTable("HoSoTimViec", (string)null);
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NguoiTimViec.NgoaiNgu", b =>
                {
                    b.Property<int>("NgoaiNguId")
                        .HasColumnType("int");

                    b.Property<string>("ChungChiNgoaiNgu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HoSoTimViecId")
                        .HasColumnType("int");

                    b.Property<string>("NgonNgu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrinhDo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NgoaiNguId");

                    b.ToTable("NgoaiNgu", (string)null);
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NguoiTimViec.ViecLam", b =>
                {
                    b.Property<int>("ViecLamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ViecLamId"), 1L, 1);

                    b.Property<int>("TaiKhoanId")
                        .HasColumnType("int");

                    b.Property<int>("ViecLamNop")
                        .HasColumnType("int");

                    b.HasKey("ViecLamId");

                    b.HasIndex("TaiKhoanId");

                    b.ToTable("ViecLam", (string)null);
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NhaTuyenDung.CongTy", b =>
                {
                    b.Property<int>("CongTyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CongTyId"), 1L, 1);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("https://freedesignfile.com/upload/2017/08/White-office-space-meeting-room-table-Stock-Photo-16.jpg");

                    b.Property<string>("QuocGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoLuoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenCongTy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CongTyId");

                    b.ToTable("CongTy", (string)null);
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NhaTuyenDung.CongViec", b =>
                {
                    b.Property<int>("CongViecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CongViecId"), 1L, 1);

                    b.Property<string>("CapBac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CongTyId")
                        .HasColumnType("int");

                    b.Property<string>("DiaDiem")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("HanNop")
                        .HasColumnType("datetime2");

                    b.Property<string>("HocVan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("KinhNghiem")
                        .HasColumnType("real");

                    b.Property<string>("LoaiCongViec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MucLuong")
                        .HasColumnType("int");

                    b.Property<string>("NganhNghe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaiKhoanId")
                        .HasColumnType("int");

                    b.Property<string>("TenCongViec")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("CongViecId");

                    b.HasIndex("CongTyId");

                    b.HasIndex("TaiKhoanId");

                    b.ToTable("CongViec", (string)null);
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NhaTuyenDung.CongViecDaNop", b =>
                {
                    b.Property<int>("CongViecDaNopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CongViecDaNopId"), 1L, 1);

                    b.Property<int>("CongViecId")
                        .HasColumnType("int");

                    b.Property<int>("IdNguoiNop")
                        .HasColumnType("int");

                    b.HasKey("CongViecDaNopId");

                    b.HasIndex("CongViecId");

                    b.ToTable("CongViecDaNop", (string)null);
                });

            modelBuilder.Entity("TimViec.Domain.Entities.TaiKhoan", b =>
                {
                    b.Property<int>("TaiKhoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaiKhoanId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("https://www.pngkit.com/png/full/88-885453_login-white-on-clear-user-icon.png");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TaiKhoanId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("TaiKhoan", (string)null);
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NguoiTimViec.ChungChi", b =>
                {
                    b.HasOne("TimViec.Domain.Entities.NguoiTimViec.HoSoTimViec", "hoSoTimViec")
                        .WithOne("ChungChi")
                        .HasForeignKey("TimViec.Domain.Entities.NguoiTimViec.ChungChi", "ChungChiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hoSoTimViec");
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NguoiTimViec.HocVan", b =>
                {
                    b.HasOne("TimViec.Domain.Entities.NguoiTimViec.HoSoTimViec", "hoSoTimViec")
                        .WithOne("HocVan")
                        .HasForeignKey("TimViec.Domain.Entities.NguoiTimViec.HocVan", "HocVanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hoSoTimViec");
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NguoiTimViec.HoSoTimViec", b =>
                {
                    b.HasOne("TimViec.Domain.Entities.TaiKhoan", "TaiKhoan")
                        .WithOne("HoSoTimViec")
                        .HasForeignKey("TimViec.Domain.Entities.NguoiTimViec.HoSoTimViec", "TaiKhoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NguoiTimViec.NgoaiNgu", b =>
                {
                    b.HasOne("TimViec.Domain.Entities.NguoiTimViec.HoSoTimViec", "hoSoTimViec")
                        .WithOne("NgoaiNgu")
                        .HasForeignKey("TimViec.Domain.Entities.NguoiTimViec.NgoaiNgu", "NgoaiNguId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hoSoTimViec");
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NguoiTimViec.ViecLam", b =>
                {
                    b.HasOne("TimViec.Domain.Entities.TaiKhoan", "TaiKhoan")
                        .WithMany("ViecLams")
                        .HasForeignKey("TaiKhoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NhaTuyenDung.CongViec", b =>
                {
                    b.HasOne("TimViec.Domain.Entities.NhaTuyenDung.CongTy", "CongTy")
                        .WithMany("congViecs")
                        .HasForeignKey("CongTyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimViec.Domain.Entities.TaiKhoan", "TaiKhoan")
                        .WithMany("CongViecs")
                        .HasForeignKey("TaiKhoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CongTy");

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NhaTuyenDung.CongViecDaNop", b =>
                {
                    b.HasOne("TimViec.Domain.Entities.NhaTuyenDung.CongViec", "CongViec")
                        .WithMany("CongViecDaNops")
                        .HasForeignKey("CongViecId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CongViec");
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NguoiTimViec.HoSoTimViec", b =>
                {
                    b.Navigation("ChungChi")
                        .IsRequired();

                    b.Navigation("HocVan")
                        .IsRequired();

                    b.Navigation("NgoaiNgu")
                        .IsRequired();
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NhaTuyenDung.CongTy", b =>
                {
                    b.Navigation("congViecs");
                });

            modelBuilder.Entity("TimViec.Domain.Entities.NhaTuyenDung.CongViec", b =>
                {
                    b.Navigation("CongViecDaNops");
                });

            modelBuilder.Entity("TimViec.Domain.Entities.TaiKhoan", b =>
                {
                    b.Navigation("CongViecs");

                    b.Navigation("HoSoTimViec")
                        .IsRequired();

                    b.Navigation("ViecLams");
                });
#pragma warning restore 612, 618
        }
    }
}
