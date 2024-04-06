﻿// <auto-generated />
using System;
using Blog_BrazorWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog_BrazorWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasKey("Id");

                    b.ToTable("Articles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "本文１",
                            CreateDate = new DateTime(2024, 4, 6, 4, 27, 41, 266, DateTimeKind.Local).AddTicks(7246),
                            Title = "タイトル１",
                            UpdateDate = new DateTime(2024, 4, 6, 4, 27, 41, 266, DateTimeKind.Local).AddTicks(7254)
                        },
                        new
                        {
                            Id = 2,
                            Content = "本文２",
                            CreateDate = new DateTime(2024, 4, 6, 4, 27, 41, 266, DateTimeKind.Local).AddTicks(7255),
                            Title = "タイトル２",
                            UpdateDate = new DateTime(2024, 4, 6, 4, 27, 41, 266, DateTimeKind.Local).AddTicks(7255)
                        },
                        new
                        {
                            Id = 3,
                            Content = "本文３",
                            CreateDate = new DateTime(2024, 4, 6, 4, 27, 41, 266, DateTimeKind.Local).AddTicks(7256),
                            Title = "タイトル３",
                            UpdateDate = new DateTime(2024, 4, 6, 4, 27, 41, 266, DateTimeKind.Local).AddTicks(7257)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
