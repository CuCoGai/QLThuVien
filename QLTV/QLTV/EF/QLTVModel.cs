namespace QLTV.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLTVModel : DbContext
    {
        public QLTVModel()
            : base("name=QLTVModel")
        {
        }

        public virtual DbSet<Dangkycabiet> Dangkycabiets { get; set; }
        public virtual DbSet<Docgia> Docgias { get; set; }
        public virtual DbSet<Khosach> Khosaches { get; set; }
        public virtual DbSet<Muontra> Muontras { get; set; }
        public virtual DbSet<Nhaxuatban> Nhaxuatbans { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Thuthu> Thuthus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dangkycabiet>()
                .Property(e => e.sachma)
                .IsUnicode(false);

            modelBuilder.Entity<Dangkycabiet>()
                .Property(e => e.sodangky)
                .IsUnicode(false);

            modelBuilder.Entity<Dangkycabiet>()
                .Property(e => e.khoma)
                .IsUnicode(false);

            modelBuilder.Entity<Docgia>()
                .Property(e => e.sothe)
                .IsUnicode(false);

            modelBuilder.Entity<Docgia>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Docgia>()
                .Property(e => e.donvi)
                .IsUnicode(false);

            modelBuilder.Entity<Docgia>()
                .Property(e => e.anh)
                .IsUnicode(false);

            modelBuilder.Entity<Docgia>()
                .HasMany(e => e.Muontras)
                .WithOptional(e => e.Docgia)
                .HasForeignKey(e => e.sothema);

            modelBuilder.Entity<Khosach>()
                .Property(e => e.ma)
                .IsUnicode(false);

            modelBuilder.Entity<Khosach>()
                .HasMany(e => e.Dangkycabiets)
                .WithOptional(e => e.Khosach)
                .HasForeignKey(e => e.khoma);

            modelBuilder.Entity<Khosach>()
                .HasMany(e => e.Saches)
                .WithOptional(e => e.Khosach)
                .HasForeignKey(e => e.khoma);

            modelBuilder.Entity<Muontra>()
                .Property(e => e.sothutu)
                .IsUnicode(false);

            modelBuilder.Entity<Muontra>()
                .Property(e => e.sothema)
                .IsUnicode(false);

            modelBuilder.Entity<Muontra>()
                .Property(e => e.sachma)
                .IsUnicode(false);

            modelBuilder.Entity<Muontra>()
                .Property(e => e.thuthuma)
                .IsUnicode(false);

            modelBuilder.Entity<Nhaxuatban>()
                .Property(e => e.ma)
                .IsUnicode(false);

            modelBuilder.Entity<Nhaxuatban>()
                .Property(e => e.sodienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.ma)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.nhaxuatbanma)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.giatien)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.khoma)
                .IsUnicode(false);

            modelBuilder.Entity<Thuthu>()
                .Property(e => e.ma)
                .IsUnicode(false);

            modelBuilder.Entity<Thuthu>()
                .Property(e => e.sodienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<Thuthu>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Thuthu>()
                .Property(e => e.matkhau)
                .IsUnicode(false);
        }
    }
}
