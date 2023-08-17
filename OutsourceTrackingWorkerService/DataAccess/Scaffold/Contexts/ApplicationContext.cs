using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OutsourceTrackingWorkerService.DataAccess.Scaffold.Entities;

namespace OutsourceTrackingWorkerService.DataAccess.Scaffold.Contexts
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NtsWmIsemritraV> NtsWmIsemritraVs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                var builder = new ConfigurationBuilder().SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(builder.GetValue<string>($"{builder.GetValue<string>("WorkMode")}:Conn"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NtsWmIsemritraV>(entity =>
            {
                entity.ToTable("NTS_WM_ISEMRITRA_V");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.DemirKodu)
                    .HasMaxLength(50)
                    .HasColumnName("DEMIR_KODU");

                entity.Property(e => e.Hmdepokodu).HasColumnName("HMDEPOKODU");

                entity.Property(e => e.Isemrino)
                    .HasMaxLength(50)
                    .HasColumnName("ISEMRINO");

                entity.Property(e => e.Isemritarihi)
                    .HasColumnType("date")
                    .HasColumnName("ISEMRITARIHI");

                entity.Property(e => e.Istkodu)
                    .HasMaxLength(50)
                    .HasColumnName("ISTKODU");

                entity.Property(e => e.Kapatildi)
                    .HasMaxLength(10)
                    .HasColumnName("KAPATILDI");

                entity.Property(e => e.Kayittarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("KAYITTARIHI");

                entity.Property(e => e.MakinaNo).HasColumnName("MAKINA_NO");

                entity.Property(e => e.Mamuldepokodu).HasColumnName("MAMULDEPOKODU");

                entity.Property(e => e.Miktar)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("MIKTAR");

                entity.Property(e => e.Opkodu)
                    .HasMaxLength(50)
                    .HasColumnName("OPKODU");

                entity.Property(e => e.Opno)
                    .HasMaxLength(50)
                    .HasColumnName("OPNO");

                entity.Property(e => e.Refisemrino)
                    .HasMaxLength(50)
                    .HasColumnName("REFISEMRINO");

                entity.Property(e => e.StokAdi)
                    .HasMaxLength(50)
                    .HasColumnName("STOK_ADI");

                entity.Property(e => e.StokKodu)
                    .HasMaxLength(50)
                    .HasColumnName("STOK_KODU");

                entity.Property(e => e.Takipno).HasColumnName("TAKIPNO");

                entity.Property(e => e.TeslimTarihi)
                    .HasColumnType("date")
                    .HasColumnName("TESLIM_TARIHI");

                entity.Property(e => e.Uretilen)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("URETILEN");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
