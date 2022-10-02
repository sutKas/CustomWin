﻿// <auto-generated />
using System;
using CustomWin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomWin.Migrations
{
    [DbContext(typeof(LottoDbContext))]
    partial class LottoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomWin.Models.Lottery", b =>
                {
                    b.Property<int>("LotteryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DrawDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LottoCategory")
                        .HasColumnType("int");

                    b.Property<string>("LottoSignature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prizes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SyManagerId")
                        .HasColumnType("int");

                    b.Property<int>("WinnerId")
                        .HasColumnType("int");

                    b.HasKey("LotteryId");

                    b.HasIndex("SyManagerId");

                    b.HasIndex("WinnerId");

                    b.ToTable("Lotteries");
                });

            modelBuilder.Entity("CustomWin.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("CustomWin.Models.PurchasedLottery", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("LotteryId")
                        .HasColumnType("int");

                    b.HasKey("PlayerId", "LotteryId");

                    b.HasIndex("LotteryId");

                    b.ToTable("PurchasedLotteries");
                });

            modelBuilder.Entity("CustomWin.Models.SystemManager", b =>
                {
                    b.Property<int>("SyManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SyManagerId");

                    b.ToTable("SystemManagers");
                });

            modelBuilder.Entity("CustomWin.Models.Winner", b =>
                {
                    b.Property<int>("WinnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WinnerId");

                    b.ToTable("Winners");
                });

            modelBuilder.Entity("CustomWin.Models.Lottery", b =>
                {
                    b.HasOne("CustomWin.Models.SystemManager", "SystemManager")
                        .WithMany("Lotteries")
                        .HasForeignKey("SyManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomWin.Models.Winner", "Winner")
                        .WithMany("Lotteries")
                        .HasForeignKey("WinnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SystemManager");

                    b.Navigation("Winner");
                });

            modelBuilder.Entity("CustomWin.Models.PurchasedLottery", b =>
                {
                    b.HasOne("CustomWin.Models.Lottery", "Lottery")
                        .WithMany("PurchasedLotteries")
                        .HasForeignKey("LotteryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomWin.Models.Player", "Player")
                        .WithMany("PurchasedLotteries")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lottery");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("CustomWin.Models.Lottery", b =>
                {
                    b.Navigation("PurchasedLotteries");
                });

            modelBuilder.Entity("CustomWin.Models.Player", b =>
                {
                    b.Navigation("PurchasedLotteries");
                });

            modelBuilder.Entity("CustomWin.Models.SystemManager", b =>
                {
                    b.Navigation("Lotteries");
                });

            modelBuilder.Entity("CustomWin.Models.Winner", b =>
                {
                    b.Navigation("Lotteries");
                });
#pragma warning restore 612, 618
        }
    }
}