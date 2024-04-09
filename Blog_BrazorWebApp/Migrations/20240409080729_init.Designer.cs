﻿// <auto-generated />
using System;
using Blog_BrazorWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog_BrazorWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240409080729_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog_BrazorWebApp.Model.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "本文１",
                            CreateDate = new DateTime(2024, 4, 9, 17, 7, 28, 420, DateTimeKind.Local).AddTicks(5925),
                            Title = "タイトル１",
                            UpdateDate = new DateTime(2024, 4, 9, 17, 7, 28, 420, DateTimeKind.Local).AddTicks(5925),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "本文２",
                            CreateDate = new DateTime(2024, 4, 9, 17, 7, 28, 420, DateTimeKind.Local).AddTicks(5928),
                            Title = "タイトル２",
                            UpdateDate = new DateTime(2024, 4, 9, 17, 7, 28, 420, DateTimeKind.Local).AddTicks(5928),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "本文３",
                            CreateDate = new DateTime(2024, 4, 9, 17, 7, 28, 420, DateTimeKind.Local).AddTicks(5930),
                            Title = "タイトル３",
                            UpdateDate = new DateTime(2024, 4, 9, 17, 7, 28, 420, DateTimeKind.Local).AddTicks(5931),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Blog_BrazorWebApp.Model.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("UserAccounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "adminpass",
                            RoleId = 1,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Password = "userpass",
                            RoleId = 2,
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("Blog_BrazorWebApp.Model.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleName = "administrator"
                        },
                        new
                        {
                            Id = 2,
                            RoleName = "user"
                        });
                });

            modelBuilder.Entity("Blog_BrazorWebApp.Model.Article", b =>
                {
                    b.HasOne("Blog_BrazorWebApp.Model.UserAccount", "UserAccount")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("Blog_BrazorWebApp.Model.UserAccount", b =>
                {
                    b.HasOne("Blog_BrazorWebApp.Model.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRole");
                });
#pragma warning restore 612, 618
        }
    }
}
