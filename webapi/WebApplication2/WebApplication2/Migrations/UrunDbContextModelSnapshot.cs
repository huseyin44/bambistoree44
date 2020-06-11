﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(UrunDbContext))]
    partial class UrunDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.4.20220.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.Urun", b =>
                {
                    b.Property<int>("UrunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("indirimlifiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kategori")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("marka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("renk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resim2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urunozellik")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UrunId");

                    b.ToTable("Uruns");
                });
#pragma warning restore 612, 618
        }
    }
}
