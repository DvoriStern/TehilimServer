﻿// <auto-generated />
using System;
using DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataContext.Migrations
{
    [DbContext(typeof(Db))]
    [Migration("20240205210109_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Repository.Entity.ChaptersOfTehilim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOfChapters")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChaptersOfTehilims");
                });

            modelBuilder.Entity("Repository.Entity.ChaptersTehilimToRead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChaptersOfTehilimId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChaptersOfTehilimId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("ChaptersTehilimToReads");
                });

            modelBuilder.Entity("Repository.Entity.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Repository.Entity.NameForPrayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameForPray")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalRequest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequestPrayerId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RequestPrayerId");

                    b.HasIndex("UserId");

                    b.ToTable("NameForPrayers");
                });

            modelBuilder.Entity("Repository.Entity.RequestPrayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RequestPrayers");
                });

            modelBuilder.Entity("Repository.Entity.Sharing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsApproval")
                        .HasColumnType("bit");

                    b.Property<int>("Kind")
                        .HasColumnType("int");

                    b.Property<int>("Responses")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Sharings");
                });

            modelBuilder.Entity("Repository.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Repository.Entity.ChaptersTehilimToRead", b =>
                {
                    b.HasOne("Repository.Entity.ChaptersOfTehilim", "ChaptersOfTehilim")
                        .WithMany("ChaptersTehilimToReads")
                        .HasForeignKey("ChaptersOfTehilimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Entity.Group", "Group")
                        .WithMany("ChaptersTehilimToReads")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Entity.User", "User")
                        .WithMany("ChaptersTehilimToReads")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChaptersOfTehilim");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Entity.NameForPrayer", b =>
                {
                    b.HasOne("Repository.Entity.RequestPrayer", "RequestPrayer")
                        .WithMany("NameforPrayers")
                        .HasForeignKey("RequestPrayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Entity.User", "User")
                        .WithMany("NameForPrayers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RequestPrayer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Entity.Sharing", b =>
                {
                    b.HasOne("Repository.Entity.User", "User")
                        .WithMany("Sharing")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Entity.ChaptersOfTehilim", b =>
                {
                    b.Navigation("ChaptersTehilimToReads");
                });

            modelBuilder.Entity("Repository.Entity.Group", b =>
                {
                    b.Navigation("ChaptersTehilimToReads");
                });

            modelBuilder.Entity("Repository.Entity.RequestPrayer", b =>
                {
                    b.Navigation("NameforPrayers");
                });

            modelBuilder.Entity("Repository.Entity.User", b =>
                {
                    b.Navigation("ChaptersTehilimToReads");

                    b.Navigation("NameForPrayers");

                    b.Navigation("Sharing");
                });
#pragma warning restore 612, 618
        }
    }
}
