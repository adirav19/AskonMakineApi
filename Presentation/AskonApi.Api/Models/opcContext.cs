using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AskonApi.Api.Models
{
    public partial class opcContext : DbContext
    {
        public opcContext()
        {
        }

        public opcContext(DbContextOptions<opcContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GunlukMakine> GunlukMakines { get; set; } = null!;
        public virtual DbSet<GunlukMakineC> GunlukMakineCs { get; set; } = null!;
        public virtual DbSet<OpcDataLive> OpcDataLives { get; set; } = null!;
        public virtual DbSet<OpcDatum> OpcData { get; set; } = null!;
        public virtual DbSet<OpcLantek> OpcLanteks { get; set; } = null!;
        public virtual DbSet<OpcLiveWorkcode> OpcLiveWorkcodes { get; set; } = null!;
        public virtual DbSet<OpcMachine> OpcMachines { get; set; } = null!;
        public virtual DbSet<OpcSuretut> OpcSuretuts { get; set; } = null!;
        public virtual DbSet<Vardiya> Vardiyas { get; set; } = null!;
        public virtual DbSet<VardiyaC> VardiyaCs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SQLSRV\\DB2;Initial Catalog=opc;User ID=opc_client;Password=abc123* ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GunlukMakine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gunluk_Makine");

                entity.Property(e => e.Aktif2)
                    .HasColumnType("time(0)")
                    .HasColumnName("aktif2");

                entity.Property(e => e.Baslangic2)
                    .HasMaxLength(4000)
                    .HasColumnName("baslangic2");

                entity.Property(e => e.Bitis2)
                    .HasMaxLength(4000)
                    .HasColumnName("bitis2");

                entity.Property(e => e.Duruş2)
                    .HasColumnType("time(0)")
                    .HasColumnName("duruş2");

                entity.Property(e => e.Erisimsiz2)
                    .HasColumnType("time(0)")
                    .HasColumnName("erisimsiz2");

                entity.Property(e => e.Finish2)
                    .HasColumnType("time(0)")
                    .HasColumnName("finish2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idw).HasColumnName("IDw");

                entity.Property(e => e.Kesim2)
                    .HasColumnType("time(0)")
                    .HasColumnName("kesim2");

                entity.Property(e => e.KesimAktifOran)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("kesim_aktif_oran");

                entity.Property(e => e.MachineNick)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("machine_nick")
                    .IsFixedLength();

                entity.Property(e => e.Mesai)
                    .HasMaxLength(4000)
                    .HasColumnName("mesai");

                entity.Property(e => e.OranAktif)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("oran_aktif");

                entity.Property(e => e.OranKesim)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("oran_kesim");

                entity.Property(e => e.Seconds).HasColumnName("seconds");

                entity.Property(e => e.Vardiyaw)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<GunlukMakineC>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gunluk_Makine_C");

                entity.Property(e => e.Aktif2)
                    .HasColumnType("time(0)")
                    .HasColumnName("aktif2");

                entity.Property(e => e.Baslangic2)
                    .HasMaxLength(4000)
                    .HasColumnName("baslangic2");

                entity.Property(e => e.Bitis2)
                    .HasMaxLength(4000)
                    .HasColumnName("bitis2");

                entity.Property(e => e.Duruş2)
                    .HasColumnType("time(0)")
                    .HasColumnName("duruş2");

                entity.Property(e => e.Erisimsiz2)
                    .HasColumnType("time(0)")
                    .HasColumnName("erisimsiz2");

                entity.Property(e => e.Finish2)
                    .HasColumnType("time(0)")
                    .HasColumnName("finish2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idw).HasColumnName("IDw");

                entity.Property(e => e.Kesim2)
                    .HasColumnType("time(0)")
                    .HasColumnName("kesim2");

                entity.Property(e => e.KesimAktifOran)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("kesim_aktif_oran");

                entity.Property(e => e.MachineNick)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("machine_nick")
                    .IsFixedLength();

                entity.Property(e => e.Mesai)
                    .HasMaxLength(4000)
                    .HasColumnName("mesai");

                entity.Property(e => e.OranAktif)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("oran_aktif");

                entity.Property(e => e.OranKesim)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("oran_kesim");

                entity.Property(e => e.Seconds).HasColumnName("seconds");

                entity.Property(e => e.Vardiyaw)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OpcDataLive>(entity =>
            {
                entity.ToTable("opc_data_live");

                entity.HasIndex(e => e.Id, "opc_data_Index01")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AAlarms)
                    .HasMaxLength(2048)
                    .IsUnicode(false)
                    .HasColumnName("aAlarms")
                    .IsFixedLength();

                entity.Property(e => e.DataType).HasColumnName("data_type");

                entity.Property(e => e.FTotalGasAircm3).HasColumnName("fTotalGasAircm3");

                entity.Property(e => e.FTotalGasN2cm3).HasColumnName("fTotalGasN2cm3");

                entity.Property(e => e.FTotalGasO2cm3).HasColumnName("fTotalGasO2cm3");

                entity.Property(e => e.MachineFinish).HasColumnName("Machine_Finish");

                entity.Property(e => e.MachineId).HasColumnName("machine_ID");

                entity.Property(e => e.MachineStart).HasColumnName("Machine_Start");

                entity.Property(e => e.MachineStop).HasColumnName("Machine_Stop");

                entity.Property(e => e.NEstimatedTime).HasColumnName("nEstimatedTime");

                entity.Property(e => e.ReadNo).HasColumnName("read_no");

                entity.Property(e => e.ReadTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Read_Time");

                entity.Property(e => e.SFinishTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sFinishTime")
                    .IsFixedLength();

                entity.Property(e => e.SGasType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("sGasType")
                    .IsFixedLength();

                entity.Property(e => e.SStartTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sStartTime")
                    .IsFixedLength();

                entity.Property(e => e.SltdProgramName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sltdProgramName")
                    .IsFixedLength();

                entity.Property(e => e.SltdProgramNameShort)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sltdProgramNameShort")
                    .IsFixedLength();
            });

            modelBuilder.Entity<OpcDatum>(entity =>
            {
                entity.ToTable("opc_data");

                entity.HasIndex(e => e.Id, "opc_data_Index01")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AAlarms)
                    .HasMaxLength(2048)
                    .IsUnicode(false)
                    .HasColumnName("aAlarms")
                    .IsFixedLength();

                entity.Property(e => e.DataType).HasColumnName("data_type");

                entity.Property(e => e.FTotalGasAircm3).HasColumnName("fTotalGasAircm3");

                entity.Property(e => e.FTotalGasN2cm3).HasColumnName("fTotalGasN2cm3");

                entity.Property(e => e.FTotalGasO2cm3).HasColumnName("fTotalGasO2cm3");

                entity.Property(e => e.MachineFinish).HasColumnName("Machine_Finish");

                entity.Property(e => e.MachineId).HasColumnName("machine_ID");

                entity.Property(e => e.MachineStart).HasColumnName("Machine_Start");

                entity.Property(e => e.MachineStop).HasColumnName("Machine_Stop");

                entity.Property(e => e.NEstimatedTime).HasColumnName("nEstimatedTime");

                entity.Property(e => e.ReadNo).HasColumnName("read_no");

                entity.Property(e => e.ReadTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Read_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SFinishTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sFinishTime")
                    .IsFixedLength();

                entity.Property(e => e.SGasType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("sGasType")
                    .IsFixedLength();

                entity.Property(e => e.SStartTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sStartTime")
                    .IsFixedLength();

                entity.Property(e => e.SltdProgramName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sltdProgramName")
                    .IsFixedLength();

                entity.Property(e => e.SltdProgramNameShort)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sltdProgramNameShort")
                    .IsFixedLength();
            });

            modelBuilder.Entity<OpcLantek>(entity =>
            {
                entity.ToTable("opc_lantek");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cdate)
                    .HasColumnType("datetime")
                    .HasColumnName("cdate");

                entity.Property(e => e.Cnc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CNC");

                entity.Property(e => e.Etime).HasColumnName("ETime");

                entity.Property(e => e.JobOrder)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobRef)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Jobname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("jobname");

                entity.Property(e => e.MatRef)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MatRef1)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("MatRef_1");

                entity.Property(e => e.Norder).HasColumnName("NOrder");

                entity.Property(e => e.NstRef)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Sarea).HasColumnName("SArea");

                entity.Property(e => e.ShtRef)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShtRefOrg)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Slength).HasColumnName("SLength");

                entity.Property(e => e.Sprofit).HasColumnName("SProfit");

                entity.Property(e => e.SprofitS).HasColumnName("SProfitS");

                entity.Property(e => e.Sthickness).HasColumnName("SThickness");

                entity.Property(e => e.Suarea).HasColumnName("SUArea");

                entity.Property(e => e.Suweight).HasColumnName("SUWeight");

                entity.Property(e => e.Sweight).HasColumnName("SWeight");

                entity.Property(e => e.Swidth).HasColumnName("SWidth");

                entity.Property(e => e.Sxmax).HasColumnName("SXMax");

                entity.Property(e => e.Symax).HasColumnName("SYMax");

                entity.Property(e => e.WrkRef)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpcLiveWorkcode>(entity =>
            {
                entity.ToTable("opc_live_workcodes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobNo)
                    .HasMaxLength(10)
                    .HasColumnName("job_No");

                entity.Property(e => e.MacId).HasColumnName("mac_ID");

                entity.Property(e => e.RecDt)
                    .HasColumnType("datetime")
                    .HasColumnName("rec_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Saat)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("saat")
                    .IsFixedLength();

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih");
            });

            modelBuilder.Entity<OpcMachine>(entity =>
            {
                entity.ToTable("opc_machines");

                entity.HasIndex(e => e.Id, "opc_machines_Index01")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MachineAskonName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Machine_Askon_Name")
                    .IsFixedLength();

                entity.Property(e => e.MachineComment)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("machine_comment")
                    .IsFixedLength();

                entity.Property(e => e.MachineIp)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("machine_IP")
                    .IsFixedLength();

                entity.Property(e => e.MachineName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("machine_name")
                    .IsFixedLength();

                entity.Property(e => e.MachineNick)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("machine_nick")
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("machine_no")
                    .IsFixedLength();

                entity.Property(e => e.MachinePath)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("machine_path")
                    .IsFixedLength();

                entity.Property(e => e.MachineProjectCode)
                    .HasColumnName("machine_project_code")
                    .HasComment("OPC Uyumlu ve olmayan makinelerin farklı ayrıştırılmaları için hazırlanmış bir alandır.");

                entity.Property(e => e.MachineReadable).HasColumnName("machine_Readable");

                entity.Property(e => e.MachineWorkgroup).HasColumnName("machine_workgroup");

                entity.Property(e => e.MachineWtype).HasColumnName("machine_Wtype");
            });

            modelBuilder.Entity<OpcSuretut>(entity =>
            {
                entity.ToTable("opc_suretut");

                entity.HasIndex(e => e.Id, "opc_suretut_Index01")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aciklama");

                entity.Property(e => e.Aktif).HasColumnName("aktif");

                entity.Property(e => e.Durus).HasColumnName("durus");

                entity.Property(e => e.Erisimsiz).HasColumnName("erisimsiz");

                entity.Property(e => e.Finish).HasColumnName("finish");

                entity.Property(e => e.Kesim).HasColumnName("kesim");

                entity.Property(e => e.MakId).HasColumnName("mak_ID");

                entity.Property(e => e.RecDt)
                    .HasColumnType("datetime")
                    .HasColumnName("rec_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefSayisal).HasColumnName("ref_sayisal");

                entity.Property(e => e.RefString)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ref_string");

                entity.Property(e => e.Saat)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("saat")
                    .IsFixedLength();

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih");
            });

            modelBuilder.Entity<Vardiya>(entity =>
            {
                entity.ToTable("vardiya");

                entity.HasIndex(e => e.Id, "vardiya_Index01")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Baslangic).HasColumnName("baslangic");

                entity.Property(e => e.Bitis).HasColumnName("bitis");

                entity.Property(e => e.Grup).HasColumnName("grup");

                entity.Property(e => e.Gundegisimi).HasColumnName("gundegisimi");

                entity.Property(e => e.GundegisimiA).HasColumnName("gundegisimi_a");

                entity.Property(e => e.Gunduz).HasColumnName("gunduz");

                entity.Property(e => e.Vardiya1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Vardiya")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VardiyaC>(entity =>
            {
                entity.ToTable("vardiyaC");

                entity.HasIndex(e => e.Id, "vardiya_Index0101")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Baslangic).HasColumnName("baslangic");

                entity.Property(e => e.Bitis).HasColumnName("bitis");

                entity.Property(e => e.Grup).HasColumnName("grup");

                entity.Property(e => e.Gundegisimi).HasColumnName("gundegisimi");

                entity.Property(e => e.GundegisimiA).HasColumnName("gundegisimi_a");

                entity.Property(e => e.Gunduz).HasColumnName("gunduz");

                entity.Property(e => e.Vardiya)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
