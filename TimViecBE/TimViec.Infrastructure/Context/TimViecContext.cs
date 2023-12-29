using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Domain.Entities;
using TimViec.Domain.Entities.NguoiTimViec;
using TimViec.Domain.Entities.NhaTuyenDung;

namespace TimViec.Infrastructure.Context
{
    public class TimViecContext : DbContext
    {
        public TimViecContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<CongViec> CongViecs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<CongTy> CongTys { get; set; }
        public virtual DbSet<HoSoTimViec> HoSoTimViecs { get; set; }
        public virtual DbSet<ViecLam> ViecLams { get; set; }
        public virtual DbSet<ChungChi> ChungChis { get; set; }
        public virtual DbSet<HocVan> HocVans { get; set; }
        public virtual DbSet<NgoaiNgu> NgoaiNgus { get; set; }
        public virtual DbSet<CongViecDaNop> CongViecDaNops { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CongViec>(e =>
            {
                e.ToTable("CongViec");
                e.HasKey(p => p.CongViecId);
                e.HasOne(p => p.CongTy).WithMany(p => p.congViecs).HasForeignKey(p => p.CongTyId);
                e.Property(p => p.TenCongViec).HasMaxLength(200);
                e.Property(p => p.DiaDiem).HasMaxLength(200);
                e.HasOne(p => p.TaiKhoan).WithMany(p => p.CongViecs).HasForeignKey(P => P.TaiKhoanId);
            });
            modelBuilder.Entity<CongTy>(e =>
            {
                e.ToTable("CongTy");
                e.HasKey(p => p.CongTyId);
                e.Property(p => p.HinhAnh).HasDefaultValue("https://freedesignfile.com/upload/2017/08/White-office-space-meeting-room-table-Stock-Photo-16.jpg");
            });
            modelBuilder.Entity<TaiKhoan>(e =>
            {
                e.ToTable("TaiKhoan");
                e.HasKey(p => p.TaiKhoanId);
                e.HasIndex(c => c.UserName).IsUnique();
                e.Property(p => p.HinhAnh)
                .HasDefaultValue("https://www.pngkit.com/png/full/88-885453_login-white-on-clear-user-icon.png");
                e.HasOne(p => p.HoSoTimViec).WithOne(p => p.TaiKhoan);
            });
            modelBuilder.Entity<HoSoTimViec>(e =>
            {
                e.ToTable("HoSoTimViec");
                e.HasKey(e => e.HoSoTimViecId);
            });
            modelBuilder.Entity<ChungChi>(e =>
            {
                e.ToTable("ChungChi");
                e.HasKey(e => e.ChungChiId);
                e.HasOne(p => p.hoSoTimViec).WithOne(p => p.ChungChi).HasForeignKey<ChungChi>(c => c.ChungChiId);
            });
           
            modelBuilder.Entity<NgoaiNgu>(e =>
            {
                e.ToTable("NgoaiNgu");
                e.HasKey(e => e.NgoaiNguId);
                e.HasOne(p => p.hoSoTimViec).WithOne(p => p.NgoaiNgu).HasForeignKey<NgoaiNgu>(c => c.NgoaiNguId);
            });
            modelBuilder.Entity<ViecLam>(e =>
            {
                e.ToTable("ViecLam");
                e.HasKey(e => e.ViecLamId);
                e.HasOne(p => p.TaiKhoan).WithMany(p => p.ViecLams).HasForeignKey(p => p.TaiKhoanId);

            });
            modelBuilder.Entity<CongViecDaNop>(e =>
            {
                e.ToTable("CongViecDaNop");
                e.HasKey(e => e.CongViecDaNopId);
                e.HasOne(p => p.CongViec).WithMany(p => p.CongViecDaNops).HasForeignKey(p => p.CongViecId);
            });
            modelBuilder.Entity<HocVan>(e =>
            {
                e.ToTable("HocVan");
                e.HasKey(p => p.HocVanId);
                e.HasOne(p => p.hoSoTimViec).WithOne(p => p.HocVan).HasForeignKey<HocVan>(p => p.HocVanId);
            });

        }
    }
}
