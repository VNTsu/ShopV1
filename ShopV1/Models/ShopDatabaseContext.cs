using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ShopV1.Models
{
    public partial class ShopDatabaseContext : DbContext
    {
        public ShopDatabaseContext()
        {
        }

        public ShopDatabaseContext(DbContextOptions<ShopDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminAccount> AdminAccount { get; set; }
        public virtual DbSet<AnhSanPham> AnhSanPham { get; set; }
        public virtual DbSet<BangTin> BangTin { get; set; }
        public virtual DbSet<DanhMuc> DanhMuc { get; set; }
        public virtual DbSet<DonHang> DonHang { get; set; }
        public virtual DbSet<GioHang> GioHang { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-1N4AMLI;Database=shopquanao;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminAccount>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fullname)
                    .HasColumnName("fullname")
                    .HasMaxLength(40);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnhSanPham>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdSanpahm).HasColumnName("id_sanpahm");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<BangTin>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anhdaidien)
                    .HasColumnName("anhdaidien")
                    .HasMaxLength(100);

                entity.Property(e => e.Noidung).HasColumnName("noidung");

                entity.Property(e => e.Tieude)
                    .HasColumnName("tieude")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.Ten)
                    .HasColumnName("ten")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DonHang>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diachi)
                    .HasColumnName("diachi")
                    .HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Ghichu)
                    .HasColumnName("ghichu")
                    .HasMaxLength(200);

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.MaDonhang)
                    .HasColumnName("ma_donhang")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Stats).HasColumnName("stats");

                entity.Property(e => e.TenKhachhang)
                    .HasColumnName("ten_khachhang")
                    .HasMaxLength(50);

                entity.Property(e => e.Tongtien).HasColumnName("tongtien");
            });

            modelBuilder.Entity<GioHang>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdSanpham)
                    .IsRequired()
                    .HasColumnName("id_sanpham")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.SoLuong).HasColumnName("so_luong");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnhSanpham)
                    .HasColumnName("anh_sanpham")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GiaKm).HasColumnName("gia_km");

                entity.Property(e => e.GiaSanpham).HasColumnName("gia_sanpham");

                entity.Property(e => e.IdDanhmuc).HasColumnName("id_danhmuc");

                entity.Property(e => e.MaSanphan)
                    .HasColumnName("ma_sanphan")
                    .HasMaxLength(40);

                entity.Property(e => e.Mau)
                    .HasColumnName("mau")
                    .HasMaxLength(20);

                entity.Property(e => e.Mota)
                    .HasColumnName("mota")
                    .HasColumnType("text");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasMaxLength(20);

                entity.Property(e => e.SoLuong).HasColumnName("so_luong");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TenSanpham)
                    .HasColumnName("ten_sanpham")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diachi)
                    .HasColumnName("diachi")
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Gioitinh)
                    .HasColumnName("gioitinh")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Matkhau)
                    .IsRequired()
                    .HasColumnName("matkhau")
                    .HasMaxLength(20);

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("ngaysinh")
                    .HasColumnType("date");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenKhachhang)
                    .HasColumnName("ten_khachhang")
                    .HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
