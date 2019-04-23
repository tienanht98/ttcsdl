namespace CFIT.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContex : DbContext
    {
        public DBContex()
            : base("name=DBContex1")
        {
        }

        public virtual DbSet<TTCDL_ThiSinh> TTCDL_ThiSinh { get; set; }
        public virtual DbSet<TTCSDL_DanhSachThi> TTCSDL_DanhSachThi { get; set; }
        public virtual DbSet<TTCSDL_DSNopTien> TTCSDL_DSNopTien { get; set; }
        public virtual DbSet<TTCSDL_GiaOnThi> TTCSDL_GiaOnThi { get; set; }
        public virtual DbSet<TTCSDL_GiaoVien> TTCSDL_GiaoVien { get; set; }
        public virtual DbSet<TTCSDL_GioiTinh> TTCSDL_GioiTinh { get; set; }
        public virtual DbSet<TTCSDL_HocVien> TTCSDL_HocVien { get; set; }
        public virtual DbSet<TTCSDL_HoiDongThi> TTCSDL_HoiDongThi { get; set; }
        public virtual DbSet<TTCSDL_KyThi> TTCSDL_KyThi { get; set; }
        public virtual DbSet<TTCSDL_NhiemVu> TTCSDL_NhiemVu { get; set; }
        public virtual DbSet<TTCSDL_NhuCau> TTCSDL_NhuCau { get; set; }
        public virtual DbSet<TTCSDL_TrinhDo> TTCSDL_TrinhDo { get; set; }
        public virtual DbSet<TTCSDL_ChiTietHoiDongThi> TTCSDL_ChiTietHoiDongThi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TTCDL_ThiSinh>()
                .Property(e => e.IDThiSinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCDL_ThiSinh>()
                .Property(e => e.SoCMT)
                .HasPrecision(12, 0);

            modelBuilder.Entity<TTCDL_ThiSinh>()
                .Property(e => e.SoDienThoai)
                .HasPrecision(11, 0);

            modelBuilder.Entity<TTCDL_ThiSinh>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<TTCDL_ThiSinh>()
                .HasMany(e => e.TTCSDL_DSNopTien)
                .WithRequired(e => e.TTCDL_ThiSinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TTCSDL_DanhSachThi>()
                .Property(e => e.SBD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_DanhSachThi>()
                .Property(e => e.IDHoiDongThi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_DanhSachThi>()
                .Property(e => e.IDNopTien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_DSNopTien>()
                .Property(e => e.ID_NopTien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_DSNopTien>()
                .Property(e => e.IDThiSinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_DSNopTien>()
                .HasMany(e => e.TTCSDL_DanhSachThi)
                .WithRequired(e => e.TTCSDL_DSNopTien)
                .HasForeignKey(e => e.IDNopTien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TTCSDL_GiaOnThi>()
                .Property(e => e.ID_GiaOnThi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_GiaOnThi>()
                .Property(e => e.GiaOnThi)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TTCSDL_GiaOnThi>()
                .Property(e => e.IDKyThi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_GiaOnThi>()
                .Property(e => e.GiaThi)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TTCSDL_GiaOnThi>()
                .Property(e => e.MaKyThi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_GiaoVien>()
                .Property(e => e.IDGiaoVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_HocVien>()
                .HasMany(e => e.TTCSDL_GiaOnThi)
                .WithRequired(e => e.TTCSDL_HocVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TTCSDL_HoiDongThi>()
                .Property(e => e.IDHoiDongThi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_HoiDongThi>()
                .Property(e => e.MaKyThi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_HoiDongThi>()
                .HasMany(e => e.TTCSDL_DanhSachThi)
                .WithRequired(e => e.TTCSDL_HoiDongThi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TTCSDL_HoiDongThi>()
                .HasMany(e => e.TTCSDL_ChiTietHoiDongThi)
                .WithRequired(e => e.TTCSDL_HoiDongThi)
                .HasForeignKey(e => e.ID_Hoi_Dong_Thi);

            modelBuilder.Entity<TTCSDL_KyThi>()
                .Property(e => e.MaKyThi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_NhiemVu>()
                .Property(e => e.IDNhiemVu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_NhuCau>()
                .HasMany(e => e.TTCSDL_GiaOnThi)
                .WithRequired(e => e.TTCSDL_NhuCau)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TTCSDL_TrinhDo>()
                .HasMany(e => e.TTCSDL_GiaOnThi)
                .WithRequired(e => e.TTCSDL_TrinhDo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TTCSDL_ChiTietHoiDongThi>()
                .Property(e => e.ID_Hoi_Dong_Thi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_ChiTietHoiDongThi>()
                .Property(e => e.IDGiaoVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCSDL_ChiTietHoiDongThi>()
                .Property(e => e.IDNhiemVu)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
